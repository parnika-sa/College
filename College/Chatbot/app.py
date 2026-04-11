from flask import Flask, request, jsonify
from groq import Groq
import mysql.connector
import json
from datetime import date

app = Flask(__name__)

# ================================================================
#  CONVERSATION HISTORY  (in-memory per user session)
#  Key: "role_userid"  e.g. "student_3", "admin_0"
#  Value: list of {"role": ..., "content": ...} dicts
#  Max 20 messages kept per user to avoid token overflow
# ================================================================
MAX_HISTORY = 20
conversation_store = {}

# ================================================================
#  CONFIGURATION
#  Get FREE Groq API Key from: https://console.groq.com/keys
#  Model: llama-3.3-70b-versatile (Best accuracy, completely free)
# ================================================================
GROQ_API_KEY = ""   # <-- Paste your Groq key here
client = Groq(api_key=GROQ_API_KEY)

DB_CONFIG = {
    "host": "localhost",
    "user": "root",
    "password": "S19r22y26",
    "database": "college_erp"
}

# ================================================================
#  DB HELPER — READ ONLY
# ================================================================
def safe_float(val, default=100):
    """Safely convert a value to float; returns default if conversion fails."""
    try:
        return float(val)
    except (TypeError, ValueError):
        return default


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
#  SYSTEM PROMPT RULES  (Enhanced for maximum accuracy)
# ================================================================
STRICT_RULES = """
You are a College ERP AI Assistant named "ERP Assistant" for a college management system.

=== ABSOLUTE RULES — NEVER BREAK THESE ===

1. DATA ACCURACY (CRITICAL):
   - ONLY use the EXACT data provided in this prompt. NEVER invent, estimate, or guess any number.
   - When counting students/teachers/records → count the ACTUAL items in the JSON list, do not use any other number.
   - When stating fees, marks, attendance % → copy EXACTLY from the data, no rounding unless data shows it.
   - If a field is "N/A" in the data → say "Not available" in your response.

2. MISSING INFORMATION:
   - If the user asks something NOT in the data → respond: "This information is not available in the system."
   - Do NOT try to answer from general knowledge. Only the provided data is valid.

3. FORMATTING (VERY IMPORTANT for college display):
   - NO markdown symbols: no **, no ##, no ```, no bullet points with *.
   - Use plain numbered lists (1. 2. 3.) or simple dashes (-) for lists.
   - Use clear section headers with just a colon (e.g., "Attendance: 72.5%")
   - Keep responses clean, professional, and easy to read on screen.
   - Do NOT repeat the same information in multiple places.

4. READ-ONLY SYSTEM:
   - If user asks to add, edit, update, delete, or modify any data → say:
     "This is a read-only system. Please contact the administrator to make changes."
   - Never pretend to make changes.

5. ROLE-BASED RESPONSES:
   - Always address the logged-in user by their role (Admin / Teacher / Student).
   - Students: Only answer about THEIR OWN data. Never reveal other students' data.
   - Teachers: Only answer about their department's data.
   - Admin: Can see all data.

6. ATTENDANCE ALERTS:
   - Always clearly flag attendance below 75% with: "ALERT: Below 75% - Risk of detention"
   - For overall attendance summaries, list students below 75% first.

7. LANGUAGE & TONE:
   - Be professional, helpful, and concise.
   - If user writes in Hindi/Hinglish, you may respond in simple English (college-appropriate).
   - Do not use informal language.

8. TODAY's DATE: {today}

===========================================
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

    attendance_all = db_read("""
        SELECT s.roll_no, s.first_name, s.last_name,
               ROUND(SUM(a.status = 'Present') * 100.0 / COUNT(*), 1) AS attendance_pct
        FROM attendance a
        JOIN students s ON s.student_id = a.student_id
        GROUP BY a.student_id
        ORDER BY attendance_pct""")

    low_attendance = [
        r for r in attendance_all
        if r.get('attendance_pct') not in ('N/A', None, '')
        and safe_float(r.get('attendance_pct')) < 75
    ]

    results = db_read("""
        SELECT s.roll_no, s.first_name, s.last_name,
               sub.subject_name, r.internal_marks, r.external_marks,
               r.total_marks, r.grade, r.semester
        FROM results r
        JOIN students s ON s.student_id = r.student_id
        JOIN subjects sub ON sub.subject_id = r.subject_id
        ORDER BY s.roll_no, r.semester""")

    courses = db_read("SELECT course_name, course_code FROM courses")
    depts   = db_read("SELECT dept_name FROM departments")

    system_prompt = STRICT_RULES.format(today=date.today()) + f"""

=== ADMIN CONTEXT ===
You are talking to the ADMIN. Admin can view ALL college data.

IMPORTANT COUNT VERIFICATION:
- Exact number of students in data below: {len(students)}
- Exact number of teachers in data below: {len(teachers)}
- Exact number of fee records: {len(all_fees)}
- Students with attendance below 75%: {len(low_attendance)}

STUDENTS LIST (Total = {len(students)}):
{json.dumps(students, indent=2)}

TEACHERS LIST (Total = {len(teachers)}):
{json.dumps(teachers, indent=2)}

COURSES OFFERED:
{json.dumps(courses, indent=2)}

DEPARTMENTS:
{json.dumps(depts, indent=2)}

FEE SUMMARY (pre-calculated):
{json.dumps(fee_summary, indent=2)}

DETAILED FEE RECORDS:
{json.dumps(all_fees, indent=2)}

ALL STUDENTS ATTENDANCE:
{json.dumps(attendance_all, indent=2)}

STUDENTS WITH LOW ATTENDANCE (below 75% — {len(low_attendance)} students):
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
        return "You are a College ERP assistant. Only answer questions about college data using the data given."

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

=== TEACHER CONTEXT ===
You are talking to TEACHER: {t['first_name']} {t['last_name']}
Employee Code: {t['emp_code']}
Department: {t['dept_name']}
You can ONLY see data for your department. Do NOT reveal data from other departments.

IMPORTANT COUNT VERIFICATION:
- Students in your department: {len(students)}
- Subjects in your department: {len(subjects)}
- Students with low attendance (<75%): {len(low_att)}

STUDENTS IN YOUR DEPARTMENT (Total = {len(students)}):
{json.dumps(students, indent=2)}

SUBJECTS IN YOUR DEPARTMENT:
{json.dumps(subjects, indent=2)}

SUBJECT-WISE ATTENDANCE RECORDS:
{json.dumps(attendance, indent=2)}

STUDENTS WITH LOW ATTENDANCE (below 75% — {len(low_att)} students):
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
        return "You are a College ERP assistant. Answer questions about college data only."

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

    ovr          = overall_att[0]['overall_pct'] if overall_att else 'N/A'
    is_low_att   = ovr not in ('N/A', None, '') and safe_float(ovr) < 75
    att_status   = "ALERT: Attendance below 75% - You are at risk of detention!" if is_low_att else "Attendance is satisfactory (above 75%)."
    pending_fees = sum(float(f['balance']) for f in fees if f['balance'] not in ('N/A', None))

    system_prompt = STRICT_RULES.format(today=date.today()) + f"""

=== STUDENT CONTEXT ===
You are talking to STUDENT: {s['first_name']} {s['last_name']}
Roll No: {s['roll_no']}
You can ONLY answer questions about THIS student's own data.
NEVER reveal any other student's data.

STUDENT PROFILE:
{json.dumps(s, indent=2)}

ATTENDANCE SUMMARY:
- Overall Attendance: {ovr}%
- Status: {att_status}

SUBJECT-WISE ATTENDANCE:
{json.dumps(attendance, indent=2)}

FEE SUMMARY:
- Total Pending Amount: Rs.{pending_fees:.0f}

FEE DETAILS:
{json.dumps(fees, indent=2)}

ACADEMIC RESULTS (Latest semester first):
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

        # Build role-based context (system prompt)
        if role == "admin":
            system_context = ctx_admin(message)
        elif role == "teacher":
            system_context = ctx_teacher(user_id, message)
        else:
            system_context = ctx_student(user_id)

        # --- Conversation History ---
        session_key = f"{role}_{user_id}"
        if session_key not in conversation_store:
            conversation_store[session_key] = []

        history = conversation_store[session_key]

        # Add current user message to history
        history.append({"role": "user", "content": message})

        # Trim to last MAX_HISTORY messages to avoid token overflow
        if len(history) > MAX_HISTORY:
            history = history[-MAX_HISTORY:]
            conversation_store[session_key] = history

        # Build messages: system prompt + full conversation history
        messages_to_send = [
            {"role": "system", "content": system_context}
        ] + history

        # Call Groq API with Llama 3.3 70B
        response = client.chat.completions.create(
            model="llama-3.3-70b-versatile",
            messages=messages_to_send,
            temperature=0.1,        # Very low = maximum factual accuracy
            max_tokens=1500,
            top_p=0.9,
        )

        reply = response.choices[0].message.content.strip()

        # Save assistant reply to history
        history.append({"role": "assistant", "content": reply})

        return jsonify({"reply": reply})

    except Exception as e:
        print(f"Chat Error: {e}")
        return jsonify({"reply": f"Sorry, an error occurred. Please try again. (Error: {str(e)})"})


# ================================================================
#  HEALTH CHECK
# ================================================================
@app.route("/ping", methods=["GET"])
def ping():
    return jsonify({"status": "online", "model": "llama-3.3-70b-versatile", "provider": "Groq"})


# ================================================================
#  CLEAR HISTORY ENDPOINT  (optional — call on logout)
# ================================================================
@app.route("/clear_history", methods=["POST"])
def clear_history():
    data       = request.json
    role       = data.get("role", "student")
    user_id    = data.get("user_id", 0)
    session_key = f"{role}_{user_id}"
    conversation_store.pop(session_key, None)
    return jsonify({"status": "history cleared"})


if __name__ == "__main__":
    print("=" * 55)
    print("  College ERP AI — Groq + Llama 3.3 70B (Read-Only)")
    print("  http://localhost:5000")
    print("  Get free API key: https://console.groq.com/keys")
    print("=" * 55)
    app.run(host="0.0.0.0", port=5000, debug=False)