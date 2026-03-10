<h1 align="center">🎓 College ERP System</h1>

<p align="center">
  A complete <strong>Enterprise Resource Planning (ERP)</strong> system for colleges, built with <strong>VB.NET WinForms</strong> and <strong>MySQL</strong>.
  <br/>
  Manage students, teachers, attendance, results, and fees — all in one place.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-blue?style=flat-square&logo=windows" />
  <img src="https://img.shields.io/badge/Language-VB.NET-purple?style=flat-square&logo=dotnet" />
  <img src="https://img.shields.io/badge/Database-MySQL-orange?style=flat-square&logo=mysql" />
  <img src="https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=flat-square&logo=visualstudio" />
  <img src="https://img.shields.io/badge/Status-Active-brightgreen?style=flat-square" />
</p>

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Modules](#modules)
- [Tech Stack](#tech-stack)
- [Database Schema](#database-schema)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Screenshots](#screenshots)
- [Author](#author)

---

## 📌 About the Project

**College ERP System** is a desktop-based management system developed as a college project using **Visual Basic .NET** and **MySQL**. It provides a role-based interface for **Admins**, **Teachers**, and **Students** to manage all core college operations efficiently.

The system features a modern, professional UI with a consistent dark-navy design theme across all modules.

---

## ✨ Features

- 🔐 **Role-based Login** — Admin, Teacher, and Student portals
- 👥 **Student Management** — Add, update, delete student records with course enrollment
- 👨‍🏫 **Teacher Management** — Manage faculty with department mapping
- 📅 **Attendance System** — Mark bulk attendance with Present / Absent / Leave status
- 📊 **Results Management** — Enter marks, auto-calculate grades and totals
- 💰 **Fee Management** — Track fee payments with Paid / Pending / Partial status
- 🎨 **Professional UI** — Consistent dark-navy theme with color-coded status rows
- 📈 **Admin Dashboard** — Live stats for students, teachers, attendance, and fees
- 🛡️ **Input Validation** — Form-level validation on all modules
- 🔄 **Live Status Bar** — Real-time feedback on every user action

---

## 🧩 Modules

| Module | Description |
|--------|-------------|
| 🔐 **Login** | Secure login with role-based redirection (Admin / Teacher / Student) |
| 🏠 **Admin Dashboard** | Overview stats — total students, teachers, pending fees, attendance % |
| 👥 **Student Management** | Full CRUD for student records with course and semester details |
| 👨‍🏫 **Teacher Management** | Add/edit faculty records with department and joining date |
| 📅 **Attendance** | Bulk attendance marking per subject per day, with report view |
| 📊 **Results** | Enter internal + external marks, auto grade (A+ to F), view report |
| 💰 **Fee Management** | Record fees, track paid/pending amounts, view student fee summary |
| 🎓 **Student Dashboard** | Students can view their own attendance, results, and fee status |
| 👩‍🏫 **Teacher Dashboard** | Teachers can view their assigned subjects and student data |

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

---

## 🗄️ Database Schema

**Database Name:** `college_erp`

Key tables used in the project:

```
users           — Login credentials and roles
courses         — Course/program list
students        — Student records (linked to courses and users)
teachers        — Teacher/faculty records (linked to departments)
subjects        — Subjects per course
attendance      — Daily attendance records per student per subject
results         — Marks and grades per student per subject
fees            — Fee records per student with payment status
departments     — Department list
```

**Connection string** (update in `DatabaseHelper.vb`):
```
Server=localhost;Port=3306;Database=college_erp;Uid=root;Pwd=YOUR_PASSWORD;
```

---

## 🚀 Getting Started

### Prerequisites

- Windows OS
- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/) with VB.NET support
- [MySQL Server 8.x](https://dev.mysql.com/downloads/mysql/)
- MySQL Connector/NET (NuGet: `MySql.Data`)

### Installation Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/parnika-sa/College.git
   cd College
   ```

2. **Set up the database**
   - Open MySQL Workbench or phpMyAdmin
   - Create a new database: `college_erp`
   - Import the provided SQL file (if available) or create tables based on the schema above

3. **Configure the connection**
   - Open `DatabaseHelper.vb`
   - Update the connection string with your MySQL credentials:
   ```vb
   Private Shared connectionString As String =
       "Server=localhost;Port=3306;Database=college_erp;Uid=root;Pwd=YOUR_PASSWORD;"
   ```

4. **Open in Visual Studio**
   - Open `College.slnx`
   - Restore NuGet packages (right-click solution → Restore NuGet Packages)
   - Build and Run (`F5`)

---

## 📁 Project Structure

```
College/
│
├── College.slnx                  # Solution file
│
└── College/
    ├── DatabaseHelper.vb         # MySQL connection & query helper
    │
    ├── Form1.vb / .Designer.vb   # Login form
    │
    ├── frmAdminDashboard.vb      # Admin dashboard with stats
    ├── frmStudentDashboard.vb    # Student portal
    ├── frmTeacherDashboard.vb    # Teacher portal
    │
    ├── frmStudents.vb            # Student management (CRUD)
    ├── frmTeachers.vb            # Teacher management (CRUD)
    ├── frmAttendance.vb          # Attendance marking & reports
    ├── frmResults.vb             # Results entry & grade calculation
    ├── frmFees.vb                # Fee tracking & payment status
    │
    └── College.vbproj            # Project file
```

---

## 🎨 UI Design

The application uses a consistent design system across all forms:

- **Header color:** `RGB(22, 50, 92)` — Dark Navy
- **Font:** Segoe UI throughout
- **Button colors:** Green (Save) · Blue (Update) · Red (Delete) · Gray (Clear)
- **Status bar:** Live feedback at bottom of every form
- **Grid rows:** Color-coded by status (Paid = Green · Pending = Red · Partial = Yellow)

---

## 👨‍💻 Author

**Ankit Maurya** ([@parnika-sa](https://github.com/parnika-sa))

> Developed as a College Project — VB.NET Desktop Application

---

## 📄 License

This project is for **educational purposes** only.

---

<p align="center">
  Made with ❤️ using VB.NET · Visual Studio · MySQL
</p>