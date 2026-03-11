from flask import Flask, request, jsonify
from groq import Groq
import mysql.connector
import json

app = Flask(__name__)

GROQ_API_KEY = ""

DB_CONFIG = {
    "host": "localhost",
    "user": "root",
    "password": "S19r22y26",
    "database": "college_erp"
}

client = Groq(api_key=GROQ_API_KEY)

def get_db_data(query):
    try:
        conn = mysql.connector.connect(**DB_CONFIG)
        cursor = conn.cursor(dictionary=True)
        cursor.execute(query)
        rows = cursor.fetchall()
        conn.close()
        result = []
        for row in rows:
            clean = {}
            for k, v in row.items():
                clean[k] = str(v) if v is not None else "N/A"
            result.append(clean)
        return result
    except Exception as e:
        print(f"DB Error: {e}")
        return []

def get_extra_student_data(message):
    extra = ""
    import re
    numbers = re.findall(r'\b\d{2,4}\b', message)
    if numbers:
        for num in numbers:
            student = get_db_data(f"""
                SELECT s.student_id, s.roll_no, s.first_name, s.last_name,
                       s.email, s.phone, s.gender, s.semester, s.admission_year,
                       c.course_name, d.dept_name
                FROM students s
                LEFT JOIN courses c ON c.course_id = s.course_id
                LEFT JOIN departments d ON d.dept_id = c.dept_id
                WHERE s.roll_no = '{num}'
            """)
            if student:
                sid = student[0]['student_id']
                att = get_db_data(f"""
                    SELECT sub.subject_name,
                           COUNT(a.attendance_id) as total,
                           SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END) as present,
                           ROUND(SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END)*100.0/COUNT(a.attendance_id),1) as pct
                    FROM attendance a
                    JOIN subjects sub ON sub.subject_id = a.subject_id
                    WHERE a.student_id = {sid}
                    GROUP BY a.subject_id, sub.subject_name
                """)
                fees = get_db_data(f"SELECT fee_type, amount, paid_amount, (amount-paid_amount) as balance, status, due_date FROM fees WHERE student_id = {sid}")
                results = get_db_data(f"""
                    SELECT sub.subject_name, r.total_marks, r.grade, r.semester
                    FROM results r JOIN subjects sub ON sub.subject_id = r.subject_id
                    WHERE r.student_id = {sid} ORDER BY r.semester DESC
                """)
                extra += (
                    f"\n\nDETAILED DATA FOR Roll No {num}:\n"
                    f"Info: {json.dumps(student)}\n"
                    f"Attendance: {json.dumps(att)}\n"
                    f"Fees: {json.dumps(fees)}\n"
                    f"Results: {json.dumps(results)}\n"
                )
    return extra

def build_context(role, user_id, message=""):

    if role == "admin":
        total_students = get_db_data("SELECT COUNT(*) as total FROM students")
        total_teachers = get_db_data("SELECT COUNT(*) as total FROM teachers")
        total_courses  = get_db_data("SELECT COUNT(*) as total FROM courses")
        all_students = get_db_data("""
            SELECT s.student_id, s.roll_no, s.first_name, s.last_name,
                   s.email, s.phone, s.gender, s.semester, c.course_name, d.dept_name
            FROM students s
            LEFT JOIN courses c ON c.course_id = s.course_id
            LEFT JOIN departments d ON d.dept_id = c.dept_id ORDER BY s.roll_no
        """)
        all_teachers = get_db_data("""
            SELECT t.teacher_id, t.emp_code, t.first_name, t.last_name,
                   t.email, t.phone, t.joining_date, d.dept_name
            FROM teachers t LEFT JOIN departments d ON d.dept_id = t.dept_id
        """)
        fee_summary = get_db_data("""
            SELECT COUNT(*) as total_records, SUM(amount) as total_amount,
                   SUM(paid_amount) as total_paid, SUM(amount-paid_amount) as total_pending,
                   SUM(CASE WHEN status='Pending' THEN 1 ELSE 0 END) as pending_count,
                   SUM(CASE WHEN status='Paid' THEN 1 ELSE 0 END) as paid_count FROM fees
        """)
        all_fees = get_db_data("""
            SELECT s.roll_no, s.first_name, s.last_name, f.fee_type, f.amount,
                   f.paid_amount, (f.amount-f.paid_amount) as balance, f.status, f.due_date
            FROM fees f JOIN students s ON s.student_id = f.student_id ORDER BY f.status DESC
        """)
        low_att = get_db_data("""
            SELECT s.roll_no, s.first_name, s.last_name,
                   ROUND(SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END)*100.0/COUNT(a.attendance_id),1) as att_pct
            FROM attendance a JOIN students s ON s.student_id = a.student_id
            GROUP BY a.student_id, s.roll_no, s.first_name, s.last_name
            HAVING att_pct < 75 ORDER BY att_pct ASC
        """)
        extra_data = get_extra_student_data(message)
        context = (
            "You are a College ERP Assistant for ADMIN with FULL access.\n\n"
            f"Students={total_students[0]['total'] if total_students else 'N/A'}, "
            f"Teachers={total_teachers[0]['total'] if total_teachers else 'N/A'}, "
            f"Courses={total_courses[0]['total'] if total_courses else 'N/A'}\n\n"
            f"ALL STUDENTS:\n{json.dumps(all_students)}\n\n"
            f"ALL TEACHERS:\n{json.dumps(all_teachers)}\n\n"
            f"FEE SUMMARY:\n{json.dumps(fee_summary)}\n\n"
            f"ALL FEES:\n{json.dumps(all_fees)}\n\n"
            f"LOW ATTENDANCE:\n{json.dumps(low_att)}\n"
            f"{extra_data}\nBe concise. Plain text only."
        )

    elif role == "teacher":
        teacher = get_db_data(f"""
            SELECT t.teacher_id, t.emp_code, t.first_name, t.last_name,
                   t.email, t.phone, t.joining_date, t.dept_id, d.dept_name
            FROM teachers t LEFT JOIN departments d ON d.dept_id = t.dept_id
            WHERE t.teacher_id = {user_id}
        """)
        dept_id = teacher[0]['dept_id'] if teacher else '0'
        name = f"{teacher[0]['first_name']} {teacher[0]['last_name']}" if teacher else "Teacher"

        all_students = get_db_data(f"""
            SELECT s.student_id, s.roll_no, s.first_name, s.last_name, s.semester, c.course_name
            FROM students s JOIN courses c ON c.course_id = s.course_id
            WHERE c.dept_id = {dept_id} ORDER BY s.roll_no
        """)

        # ✅ FIX: No teacher_id filter — get ALL attendance in dept
        all_attendance = get_db_data(f"""
            SELECT s.roll_no, s.first_name, s.last_name, sub.subject_name,
                   COUNT(a.attendance_id) as total_classes,
                   SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END) as present,
                   SUM(CASE WHEN a.status='Absent' THEN 1 ELSE 0 END) as absent,
                   ROUND(SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END)*100.0/COUNT(a.attendance_id),1) as att_pct
            FROM attendance a
            JOIN students s ON s.student_id = a.student_id
            JOIN subjects sub ON sub.subject_id = a.subject_id
            JOIN courses c ON c.course_id = s.course_id
            WHERE c.dept_id = {dept_id}
            GROUP BY a.student_id, a.subject_id, s.roll_no, s.first_name, s.last_name, sub.subject_name
            ORDER BY s.roll_no
        """)

        low_att = get_db_data(f"""
            SELECT s.roll_no, s.first_name, s.last_name,
                   ROUND(SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END)*100.0/COUNT(a.attendance_id),1) as overall_pct
            FROM attendance a
            JOIN students s ON s.student_id = a.student_id
            JOIN courses c ON c.course_id = s.course_id
            WHERE c.dept_id = {dept_id}
            GROUP BY a.student_id, s.roll_no, s.first_name, s.last_name
            HAVING overall_pct < 75 ORDER BY overall_pct ASC
        """)

        all_results = get_db_data(f"""
            SELECT s.roll_no, s.first_name, s.last_name,
                   sub.subject_name, r.total_marks, r.grade, r.semester
            FROM results r
            JOIN students s ON s.student_id = r.student_id
            JOIN subjects sub ON sub.subject_id = r.subject_id
            JOIN courses c ON c.course_id = s.course_id
            WHERE c.dept_id = {dept_id}
            ORDER BY s.roll_no, r.semester
        """)

        extra_data = get_extra_student_data(message)
        context = (
            f"You are a College ERP Assistant for TEACHER: {name} | Dept: {teacher[0]['dept_name'] if teacher else 'N/A'}\n\n"
            f"ALL STUDENTS IN DEPT:\n{json.dumps(all_students)}\n\n"
            f"FULL ATTENDANCE (all subjects, all students):\n{json.dumps(all_attendance)}\n\n"
            f"LOW ATTENDANCE STUDENTS (<75%):\n{json.dumps(low_att)}\n\n"
            f"ALL RESULTS:\n{json.dumps(all_results)}\n"
            f"{extra_data}\n"
            "Answer queries about students, attendance, results in your department.\n"
            "Be concise. Plain text only."
        )

    elif role == "student":
        student = get_db_data(f"""
            SELECT s.student_id, s.roll_no, s.first_name, s.last_name,
                   s.email, s.phone, s.gender, s.semester, s.admission_year,
                   c.course_name, c.course_code, d.dept_name
            FROM students s
            LEFT JOIN courses c ON c.course_id = s.course_id
            LEFT JOIN departments d ON d.dept_id = c.dept_id
            WHERE s.student_id = {user_id}
        """)
        if not student:
            return "You are a College ERP assistant. Plain text only."
        s = student[0]
        attendance = get_db_data(f"""
            SELECT sub.subject_name, COUNT(a.attendance_id) as total_classes,
                   SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END) as present,
                   ROUND(SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END)*100.0/COUNT(a.attendance_id),1) as percentage
            FROM attendance a JOIN subjects sub ON sub.subject_id = a.subject_id
            WHERE a.student_id = {user_id} GROUP BY a.subject_id, sub.subject_name
        """)
        overall_att = get_db_data(f"""
            SELECT ROUND(SUM(CASE WHEN status='Present' THEN 1 ELSE 0 END)*100.0/COUNT(*),1) as overall_pct
            FROM attendance WHERE student_id = {user_id}
        """)
        fees = get_db_data(f"""
            SELECT fee_type, amount, paid_amount, (amount-paid_amount) as balance,
                   status, due_date, remarks FROM fees WHERE student_id = {user_id} ORDER BY status DESC
        """)
        results = get_db_data(f"""
            SELECT sub.subject_name, r.semester, r.internal_marks, r.external_marks,
                   r.total_marks, r.grade, r.academic_year
            FROM results r JOIN subjects sub ON sub.subject_id = r.subject_id
            WHERE r.student_id = {user_id} ORDER BY r.semester DESC
        """)
        overall_pct = overall_att[0]['overall_pct'] if overall_att else "N/A"
        context = (
            f"You are a College ERP Assistant for STUDENT: {s['first_name']} {s['last_name']}.\n"
            f"Roll: {s['roll_no']} | Course: {s['course_name']} | Sem: {s['semester']}\n\n"
            f"OVERALL ATTENDANCE: {overall_pct}%\n"
            f"SUBJECT-WISE ATTENDANCE: {json.dumps(attendance)}\n\n"
            f"FEES: {json.dumps(fees)}\n\n"
            f"RESULTS: {json.dumps(results)}\n\n"
            "Answer only about this student. Be friendly. If attendance < 75%, warn politely. Plain text only."
        )
    else:
        context = "You are a College ERP assistant. Plain text only."

    return context

@app.route("/chat", methods=["POST"])
def chat():
    try:
        data = request.json
        user_message = data.get("message", "")
        role = data.get("role", "student")
        user_id = data.get("user_id", 0)
        if not user_message.strip():
            return jsonify({"reply": "Please type a message."})
        context = build_context(role, user_id, user_message)
        completion = client.chat.completions.create(
            model="llama-3.1-8b-instant",
            messages=[
                {"role": "system", "content": context},
                {"role": "user",   "content": user_message}
            ],
            max_tokens=600,
            temperature=0.7
        )
        return jsonify({"reply": completion.choices[0].message.content})
    except Exception as e:
        return jsonify({"reply": f"Error: {str(e)}"})

@app.route("/ping", methods=["GET"])
def ping():
    return jsonify({"status": "online", "message": "Chatbot server is running!"})

if __name__ == "__main__":
    print("=" * 40)
    print("  College ERP Chatbot — Groq Llama 3.1")
    print("  http://localhost:5000")
    print("=" * 40)
    app.run(host="0.0.0.0", port=5000, debug=False)
