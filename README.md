# 🏥 HMS — Hospital Management System

A **desktop-based Hospital Management System** built with **C# .NET 4.8 WinForms** and **SQL Server LocalDB**. Designed for hospital staff to efficiently manage day-to-day operations including patients, doctors, appointments, and billing.

---

## 🛠️ Tech Stack

- **C# .NET Framework 4.8** — WinForms desktop application
- **SQL Server LocalDB 2022** — Local database
- **LINQ-to-SQL** — Data access and queries
- **PDFsharp / MigraDoc 6.2.3** — PDF bill generation

---

## ✨ Features

- 👤 **Patients** — Add, update, delete, and view patient records with file attachments (X-rays, reports)
- 🩺 **Doctors** — Full CRUD management for doctor profiles
- 👥 **Users** — Manage hospital staff accounts
- 📅 **Appointments** — Schedule and manage appointments, search by specific date or date range
- 🧾 **Billing** — Create and view bills. Bills cannot be deleted to preserve financial records
- 📄 **PDF Generation** — Generate and export professional PDF bills
- 📎 **File Attachments** — Attach and view patient documents directly within the app

---

## 🚀 Installation

### 1. Install SQL Server LocalDB 2022
Download and install from [Microsoft's official site](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) if not already installed.

### 2. Setup LocalDB
Open **Command Prompt** and run these commands one by one:

```bash
sqllocaldb stop MSSQLLocalDB
sqllocaldb delete MSSQLLocalDB
sqllocaldb create MSSQLLocalDB
sqllocaldb start MSSQLLocalDB
```

### 3. Database Setup
Place the `HMS.sql` file in the same folder as the executable:

```
bin/Debug/HMS.exe
# or
bin/Release/HMS.exe
```

### 4. Run the Application
Open `HMS.exe` and start managing the hospital.

---

## 🔐 Default Credentials

| Field | Value |
|---|---|
| Username | `test` |
| Password | `Test@123` |

---

## 📖 Usage

- Navigate through the tabs to manage **Patients, Doctors, Users, Appointments, and Bills**
- **Attach files** (X-rays, lab reports) when updating patient records
- **Generate PDF bills** directly from the bill view
- **Search appointments** by a specific date or a custom date range

---

## 👤 Author

**Muhammad Faris Khan** — [@MFaris-khan](https://github.com/MFaris-khan)
