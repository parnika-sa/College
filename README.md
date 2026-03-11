<h1 align="center">🎓 College ERP System</h1>

<p align="center">
  A complete <strong>Enterprise Resource Planning (ERP)</strong> system for colleges,<br/>
  built with <strong>VB.NET WinForms</strong>, <strong>MySQL</strong>, and an integrated <strong>AI Assistant</strong> powered by Groq LLaMA.
  <br/><br/>
  Manage students, teachers, attendance, results, and fees — all in one place.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-blue?style=flat-square&logo=windows" />
  <img src="https://img.shields.io/badge/Language-VB.NET-purple?style=flat-square&logo=dotnet" />
  <img src="https://img.shields.io/badge/Database-MySQL-orange?style=flat-square&logo=mysql" />
  <img src="https://img.shields.io/badge/AI-Groq%20LLaMA%203.1-green?style=flat-square&logo=meta" />
  <img src="https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91?style=flat-square&logo=visualstudio" />
  <img src="https://img.shields.io/badge/Status-Active-brightgreen?style=flat-square" />
</p>

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [AI Assistant](#ai-assistant)
- [Modules](#modules)
- [Tech Stack](#tech-stack)
- [Database Schema](#database-schema)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [UI Design](#ui-design)
- [Author](#author)

---

## 📌 About the Project

**College ERP System** is a desktop-based management system developed as a college project using **Visual Basic .NET** and **MySQL**. It provides a role-based interface for **Admins**, **Teachers**, and **Students** to manage all core college operations efficiently.

What makes this project stand out is the built-in **AI-powered ERP Assistant** — a chatbot that can answer questions about students, attendance, fees, and results in natural language, powered by **Groq's LLaMA 3.1** model via a Python Flask backend.

---

## ✨ Features

- 🔐 **Role-based Login** — Admin, Teacher, and Student portals with secure redirection
- 👥 **Student Management** — Full CRUD with course enrollment and semester tracking
- 👨‍🏫 **Teacher Management** — Manage faculty with department mapping
- 📅 **Attendance System** — Mark bulk attendance with Present / Absent / Leave status
- 📊 **Results Management** — Enter internal + external marks, auto-calculate grades
- 💰 **Fee Management** — Track fee payments with Paid / Pending / Partial status
- 🤖 **AI ERP Assistant** — Natural language chatbot with role-based data access
- 🎨 **Professional UI** — Consistent dark-navy theme with color-coded data rows
- 📈 **Live Dashboard Stats** — Real-time cards for students, teachers, fees, attendance
- 🛡️ **Input Validation** — Form-level validation on all modules
- 🔄 **Live Status Bar** — Real-time feedback on every user action

---

## 🤖 AI Assistant

The system includes a fully integrated **AI ERP Assistant** available in all three dashboards (Admin, Teacher, Student).

### How It Works

```
VB.NET App  ──► HTTP POST ──►  Python Flask Server  ──►  Groq API (LLaMA 3.1)
                                      │
                               MySQL Database
                          (fetches live context data)
```

### Role-Based Intelligence

| Role | What the AI Can Answer |
|------|------------------------|
| 🔴 **Admin** | All student/teacher info, full fee summary, low attendance reports, any student lookup by roll no |
| 🟡 **Teacher** | All students in their department, full attendance data, results, low attendance alerts |
| 🟢 **Student** | Their own attendance %, fee status, exam results, pending balance |

### Example Queries

```
Admin:   "How many students have pending fees?"
         "Show me students with low attendance"
         "Tell me about roll no 202"

Teacher: "Which students have attendance below 75%?"
         "Show me attendance of roll no 201"
         "How is Ankit performing?"

Student: "What is my attendance percentage?"
         "Do I have any pending fees?"
         "Show me my results"
```

### Setup (Required)

```bash
# Install Python dependencies
pip install flask groq mysql-connector-python

# Add your Groq API key in chatbot/app.py
GROQ_API_KEY = "gsk_your_key_here"  # Free key: https://console.groq.com/keys

# Start the chatbot server
python chatbot/app.py
# Server runs at: http://localhost:5000
```

> **Note:** The AI chatbot server must be running before using the AI Assistant button in the application.

---

## 🧩 Modules

| Module | Role Access | Description |
|--------|-------------|-------------|
| 🔐 **Login** | All | Secure login with role-based redirection |
| 🏠 **Admin Dashboard** | Admin | Live stats — students, teachers, fees, attendance |
| 👥 **Student Management** | Admin | Full CRUD for student records |
| 👨‍🏫 **Teacher Management** | Admin | Add/edit faculty with department mapping |
| 📅 **Attendance** | Admin, Teacher | Bulk attendance marking per subject per day |
| 📊 **Results** | Admin, Teacher | Enter marks, auto-grade (A+ to F), view reports |
| 💰 **Fee Management** | Admin | Record fees, track paid/pending amounts |
| 🎓 **Student Dashboard** | Student | View own attendance, results, fee status |
| 👩‍🏫 **Teacher Dashboard** | Teacher | View dept students, attendance summary, results |
| 🤖 **AI Assistant** | All | Natural language chatbot with live DB context |

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|------------|
| Language | Visual Basic .NET (VB.NET) |
| Framework | .NET Framework 4.x |
| UI | Windows Forms (WinForms) |
| Database | MySQL 8.x |
| DB Connector | MySql.Data (MySql.Data.MySqlClient) |
| IDE | Visual Studio 2022 |
| AI Model | Groq LLaMA 3.1 8B Instant |
| AI Backend | Python 3.x + Flask |
| HTTP Client | System.Net.Http (VB.NET built-in) |

---

## 🗄️ Database Schema

**Database Name:** `college_erp`

```
users           — Login credentials and roles (admin / teacher / student)
departments     — Department list (CS, Commerce, Science, etc.)
courses         — Course/program list linked to departments
subjects        — Subjects per course and semester
students        — Student records (linked to courses, users)
teachers        — Teacher/faculty records (linked to departments, users)
attendance      — Daily attendance per student per subject (Present/Absent/Leave)
results         — Internal + external marks, total, grade per student per subject
fees            — Fee records per student with Paid/Pending/Partial status
```

**Connection string** (update in `DatabaseHelper.vb`):
```vb
"Server=localhost;Port=3306;Database=college_erp;Uid=root;Pwd=YOUR_PASSWORD;"
```

---

## 🚀 Getting Started

### Prerequisites

- Windows OS
- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/) with VB.NET support
- [MySQL Server 8.x](https://dev.mysql.com/downloads/mysql/) + MySQL Workbench
- MySQL Connector/NET — NuGet: `MySql.Data`
- Python 3.8+ (for AI chatbot server)

### Installation Steps

**1. Clone the repository**
```bash
git clone https://github.com/parnika-sa/College.git
cd College
```

**2. Set up the database**
```sql
-- In MySQL Workbench, run:
CREATE DATABASE college_erp;
USE college_erp;
-- Then run the schema SQL + dummy_data.sql
```

**3. Configure the DB connection**

Open `College/DatabaseHelper.vb` and update:
```vb
Private Shared connectionString As String =
    "Server=localhost;Port=3306;Database=college_erp;Uid=root;Pwd=YOUR_PASSWORD;"
```

**4. Set up AI Chatbot**
```bash
cd chatbot
pip install -r requirements.txt
# Edit app.py — add your Groq API key
python app.py
```
Get your free Groq API key at: https://console.groq.com/keys

**5. Open in Visual Studio**
```
- Open College.slnx
- Right-click Solution → Restore NuGet Packages
- Press F5 to Build and Run
```

### Default Login Credentials

| Role | Username | Password |
|------|----------|----------|
| Admin | `admin` | `admin123` |
| Teacher | `jagpreet` | `teacher123` |
| Student | `ankit201` | `student123` |

---

## 📁 Project Structure

```
College/
│
├── College.slnx                        # Solution file
├── README.md                           # This file
│
├── sql/
│   ├── schema.sql                      # CREATE TABLE statements
│   └── dummy_data.sql                  # Sample data for all tables
│
├── chatbot/                            # AI Assistant backend
│   ├── app.py                          # Flask server (Groq + MySQL)
│   └── requirements.txt                # Python dependencies
│
└── College/                            # Main VB.NET project
    │
    ├── College.vbproj                  # Project file
    ├── DatabaseHelper.vb               # MySQL connection & query helper
    │
    ├── Form1.vb                        # Login form
    ├── Form1.Designer.vb
    │
    ├── frmAdminDashboard.vb            # Admin dashboard (stats + navigation)
    ├── frmAdminDashboard.Designer.vb
    │
    ├── frmStudentDashboard.vb          # Student portal
    ├── frmStudentDashboard.Designer.vb
    │
    ├── frmTeacherDashboard.vb          # Teacher portal
    ├── frmTeacherDashboard.Designer.vb
    │
    ├── frmStudents.vb                  # Student management (CRUD)
    ├── frmStudents.Designer.vb
    │
    ├── frmTeachers.vb                  # Teacher management (CRUD)
    ├── frmTeachers.Designer.vb
    │
    ├── frmAttendance.vb                # Attendance marking & reports
    ├── frmAttendance.Designer.vb
    │
    ├── frmResults.vb                   # Results entry & grade calculation
    ├── frmResults.Designer.vb
    │
    ├── frmFees.vb                      # Fee tracking & payment status
    ├── frmFees.Designer.vb
    │
    ├── frmChatbot.vb                   # AI Assistant chat UI
    └── frmChatbot.Designer.vb
```

---

## 🎨 UI Design

The application uses a consistent design system across all forms:

| Element | Color / Style |
|---------|--------------|
| Header background | `RGB(31, 73, 125)` — Dark Navy Blue |
| Sidebar background | `RGB(26, 32, 44)` — Near Black |
| Active nav button | `RGB(31, 73, 125)` — Navy highlight |
| Font | Segoe UI throughout |
| Save button | Green |
| Update button | Blue |
| Delete button | Red |
| AI Assistant button | Dark Green |
| Logout button | Red |
| Paid rows | Green background |
| Pending rows | Red background |
| Partial rows | Yellow background |
| Present rows | Green background |
| Absent rows | Red background |

---

## 👨‍💻 Author

**Ankit Maurya** ([@parnika-sa](https://github.com/parnika-sa))

> Developed as a College Final Project — VB.NET Desktop Application with AI Integration

---

## 📄 License

This project is for **educational purposes** only.

---

<p align="center">
  Made with ❤️ using VB.NET · Visual Studio · MySQL · Python · Groq AI
</p>