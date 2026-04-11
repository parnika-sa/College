from flask import Flask, request, jsonify
import google.generativeai as genai
import mysql.connector
import json
from datetime import date

app = Flask(__name__)

# ================================================================
#  CONFIGURATION — Replace with your Gemini API Key
#  Get free key from: https://aistudio.google.com/app/apikey
# ================================================================
GEMINI_API_KEY = "AIzaSyDPMKGZPjUi4zAI2gV9igKMuK9DFClQYmA"
genai.configure(api_key=GEMINI_API_KEY)

DB_CONFIG = {
    "host": "localhost",
    "user": "root",
    "password": "S19r22y26",
    "database": "college_erp"
}

# ================================================================
#  DB HELPER — READ ONLY
# ================================================================
def db_read(query):
    try:
        conn = mysql.connector.connect(**DB_CONFIG)
        cur  = conn.cursor(dictionary=True)
        cur.execute(query)
        rows = cur.fetchall()
        conn.close()
        return [{k: str(v) if v is not None else "N/A" for k, v in r.items()} for r in rows]
    except Exception as e:
        print(f"DB Read Error: {e}")
        return []

# ================================================================
#  SYSTEM PROMPT RULES
# ================================================================
STRICT_RULES = """
You are a College ERP AI Assistant. You ONLY answer questions about the college data provided below.

RULES YOU MUST ALWAYS FOLLOW:
1. ONLY use the data given in this prompt. Never guess or make up numbers.
2. If the information is not in the data → say "This information is not available in the system."
3. Be conversational and helpful. Answer clearly in simple English.
4. For lists, use a clean readable format — no markdown symbols like **, ##, ```.
5. Numbers must exactly match the data. Count actual records carefully.
6. This system is READ-ONLY. If the user asks to add/remove/update anything, say:
   "Write access is currently disabled. Please contact the administrator to make changes."
7. Always address the user appropriately (Admin / Teacher / Student).
8. For attendance warnings, clearly highlight if a student is below 75%.
9. Keep responses concise but complete. Do not repeat the same info multiple times.
10. TODAY's date is: {today}
"""

# ================================================================
#  CONTEXT BUILDERS
# ================================================================
def ctx_admin(message):
    students = db_read("""
        SELECT s.roll_no, s.first_name, s.last_name, s.gender,
               s.semester, s.phone, s.email, c.course_name
        FROM students s
        LEFT JOIN courses c ON c.course_id = s.course_id
        ORDER BY s.roll_no""")

    teachers = db_read("""
        SELECT t.emp_code, t.first_name, t.last_name,
               t.email, t.phone, d.dept_name
        FROM teachers t
        LEFT JOIN departments d ON d.dept_id = t.dept_id""")

    fee_summary = db_read("""
        SELECT COUNT(*) AS total_records,
               SUM(amount) AS total_fees,
               SUM(paid_amount) AS total_paid,
               SUM(amount - paid_amount) AS total_pending,
               SUM(status = 'Pending') AS pending_count,
               SUM(status = 'Paid') AS paid_count
        FROM fees""")

    all_fees = db_read("""
        SELECT s.roll_no, s.first_name, s.last_name,
               f.fee_type, f.amount, f.paid_amount,
               (f.amount - f.paid_amount) AS balance,
               f.status, f.due_date
        FROM fees f
        JOIN students s ON s.student_id = f.student_id
        ORDER BY f.status DESC, s.roll_no""")

    low_attendance = db_read("""
        SELECT s.roll_no, s.first_name, s.last_name,
               ROUND(SUM(a.status = 'Present') * 100.0 / COUNT(*), 1) AS attendance_pct
        FROM attendance a
        JOIN students s ON s.student_id = a.student_id
        GROUP BY a.student_id
        HAVING attendance_pct < 75
        ORDER BY attendance_pct""")

    results = db_read("""
        SELECT s.roll_no, s.first_name, s.last_name,
               sub.subject_name, r.total_marks, r.grade, r.semester
        FROM results r
        JOIN students s ON s.student_id = r.student_id
        JOIN subjects sub ON sub.subject_id = r.subject_id
        ORDER BY s.roll_no, r.semester""")

    courses = db_read("SELECT course_name, course_code FROM courses")
    depts   = db_read("SELECT dept_name FROM departments")

    system_prompt = STRICT_RULES.format(today=date.today()) + f"""

You are talking to the ADMIN — they can view all data.

COLLEGE DATA:
=============

TOTAL STUDENTS: {len(students)}
STUDENTS LIST:
{json.dumps(students, indent=2)}

TOTAL TEACHERS: {len(teachers)}
TEACHERS LIST:
{json.dumps(teachers, indent=2)}

COURSES OFFERED:
{json.dumps(courses, indent=2)}

DEPARTMENTS:
{json.dumps(depts, indent=2)}

FEE SUMMARY:
{json.dumps(fee_summary, indent=2)}

DETAILED FEE RECORDS:
{json.dumps(all_fees, indent=2)}

STUDENTS WITH LOW ATTENDANCE (below 75%):
{json.dumps(low_attendance, indent=2)}

ACADEMIC RESULTS:
{json.dumps(results, indent=2)}
"""
    return system_prompt


def ctx_teacher(user_id, message):
    teacher = db_read(f"""
        SELECT t.teacher_id, t.emp_code, t.first_name, t.last_name,
               t.dept_id, d.dept_name
        FROM teachers t
        LEFT JOIN departments d ON d.dept_id = t.dept_id
        WHERE t.teacher_id = {user_id}""")

    if not teacher:
        return "You are a College ERP assistant. Only answer questions about college data."

    t   = teacher[0]
    did = t['dept_id']

    students = db_read(f"""
        SELECT s.student_id, s.roll_no, s.first_name, s.last_name, s.semester
        FROM students s
        JOIN courses c ON c.course_id = s.course_id
        WHERE c.dept_id = {did}
        ORDER BY s.roll_no""")

    subjects = db_read(f"""
        SELECT subject_name, subject_code, semester
        FROM subjects
        WHERE course_id IN (SELECT course_id FROM courses WHERE dept_id = {did})""")

    attendance = db_read(f"""
        SELECT s.roll_no, s.first_name, s.last_name, sub.subject_name,
               COUNT(*) AS total_classes,
               SUM(a.status = 'Present') AS present_count,
               ROUND(SUM(a.status = 'Present') * 100.0 / COUNT(*), 1) AS attendance_pct
        FROM attendance a
        JOIN students s ON s.student_id = a.student_id
        JOIN subjects sub ON sub.subject_id = a.subject_id
        JOIN courses c ON c.course_id = s.course_id
        WHERE c.dept_id = {did}
        GROUP BY a.student_id, a.subject_id
        ORDER BY s.roll_no""")

    low_att = db_read(f"""
        SELECT s.roll_no, s.first_name, s.last_name,
               ROUND(SUM(a.status = 'Present') * 100.0 / COUNT(*), 1) AS attendance_pct
        FROM attendance a
        JOIN students s ON s.student_id = a.student_id
        JOIN courses c ON c.course_id = s.course_id
        WHERE c.dept_id = {did}
        GROUP BY a.student_id
        HAVING attendance_pct < 75""")

    results = db_read(f"""
        SELECT s.roll_no, s.first_name, s.last_name,
               sub.subject_name, r.internal_marks, r.external_marks,
               r.total_marks, r.grade, r.semester
        FROM results r
        JOIN students s ON s.student_id = r.student_id
        JOIN subjects sub ON sub.subject_id = r.subject_id
        JOIN courses c ON c.course_id = s.course_id
        WHERE c.dept_id = {did}
        ORDER BY s.roll_no, r.semester""")

    system_prompt = STRICT_RULES.format(today=date.today()) + f"""

You are talking to TEACHER: {t['first_name']} {t['last_name']}
Department: {t['dept_name']}
You can only see data for your department.

YOUR DEPARTMENT DATA:
=====================

STUDENTS IN YOUR DEPARTMENT ({len(students)} total):
{json.dumps(students, indent=2)}

SUBJECTS YOU TEACH:
{json.dumps(subjects, indent=2)}

ATTENDANCE RECORDS:
{json.dumps(attendance, indent=2)}

STUDENTS WITH LOW ATTENDANCE (below 75%):
{json.dumps(low_att, indent=2)}

STUDENT RESULTS:
{json.dumps(results, indent=2)}
"""
    return system_prompt


def ctx_student(user_id):
    student = db_read(f"""
        SELECT s.roll_no, s.first_name, s.last_name, s.email, s.phone,
               s.gender, s.semester, s.admission_year,
               c.course_name, c.course_code, d.dept_name
        FROM students s
        LEFT JOIN courses c ON c.course_id = s.course_id
        LEFT JOIN departments d ON d.dept_id = c.dept_id
        WHERE s.student_id = {user_id}""")

    if not student:
        return "You are a College ERP assistant."

    s = student[0]

    attendance = db_read(f"""
        SELECT sub.subject_name,
               COUNT(*) AS total_classes,
               SUM(a.status = 'Present') AS present_count,
               ROUND(SUM(a.status = 'Present') * 100.0 / COUNT(*), 1) AS attendance_pct
        FROM attendance a
        JOIN subjects sub ON sub.subject_id = a.subject_id
        WHERE a.student_id = {user_id}
        GROUP BY a.subject_id""")

    overall_att = db_read(f"""
        SELECT ROUND(SUM(status = 'Present') * 100.0 / COUNT(*), 1) AS overall_pct
        FROM attendance
        WHERE student_id = {user_id}""")

    fees = db_read(f"""
        SELECT fee_type, amount, paid_amount,
               (amount - paid_amount) AS balance, status, due_date
        FROM fees
        WHERE student_id = {user_id}
        ORDER BY status DESC""")

    results = db_read(f"""
        SELECT sub.subject_name, r.semester,
               r.internal_marks, r.external_marks,
               r.total_marks, r.grade
        FROM results r
        JOIN subjects sub ON sub.subject_id = r.subject_id
        WHERE r.student_id = {user_id}
        ORDER BY r.semester DESC""")

    ovr         = overall_att[0]['overall_pct'] if overall_att else 'N/A'
    att_warning = "WARNING: Your attendance is below 75% — you are at risk of detention!" if (ovr != 'N/A' and float(ovr) < 75) else "Your attendance is satisfactory."
    pending_fees = sum(float(f['balance']) for f in fees if f['balance'] != 'N/A')

    system_prompt = STRICT_RULES.format(today=date.today()) + f"""

You are talking to STUDENT: {s['first_name']} {s['last_name']}
You can ONLY answer questions about THIS student's own data.
This is a read-only view — you cannot change any data.

STUDENT PROFILE:
{json.dumps(s, indent=2)}

OVERALL ATTENDANCE: {ovr}%
ATTENDANCE STATUS: {att_warning}

SUBJECT-WISE ATTENDANCE:
{json.dumps(attendance, indent=2)}

TOTAL PENDING FEES: Rs.{pending_fees:.0f}
FEE DETAILS:
{json.dumps(fees, indent=2)}

ACADEMIC RESULTS:
{json.dumps(results, indent=2)}
"""
    return system_prompt


# ================================================================
#  CHAT ENDPOINT
# ================================================================
@app.route("/chat", methods=["POST"])
def chat():
    try:
        data    = request.json
        message = data.get("message", "").strip()
        role    = data.get("role", "student")
        user_id = data.get("user_id", 0)

        if not message:
            return jsonify({"reply": "Please type a message."})

        # Build context based on role
        if role == "admin":
            system_context = ctx_admin(message)
        elif role == "teacher":
            system_context = ctx_teacher(user_id, message)
        else:
            system_context = ctx_student(user_id)

        # Call Gemini API
        model = genai.GenerativeModel(
            model_name="gemini-2.0-flash",
            system_instruction=system_context
        )

        response = model.generate_content(
            message,
            generation_config=genai.types.GenerationConfig(
                temperature=0.2,       # Low = more accurate/factual
                max_output_tokens=1500,
            )
        )

        reply = response.text.strip()
        return jsonify({"reply": reply})

    except Exception as e:
        print(f"Chat Error: {e}")
        return jsonify({"reply": f"Sorry, an error occurred. Please try again. (Error: {str(e)})"})


# ================================================================
#  HEALTH CHECK
# ================================================================
@app.route("/ping", methods=["GET"])
def ping():
    return jsonify({"status": "online", "model": "gemini-2.0-flash"})


if __name__ == "__main__":
    print("=" * 50)
    print("  College ERP AI — Gemini Powered (Read-Only)")
    print("  http://localhost:5000")
    print("=" * 50)
    app.run(host="0.0.0.0", port=5000, debug=False)