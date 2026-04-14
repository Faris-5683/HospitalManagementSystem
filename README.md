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

### Login Screen
<img width="450" alt="11" src="https://github.com/user-attachments/assets/4f4f6549-10ef-425a-ad40-c6606c373f32" />


### Add/View Patients
<br>
<img width="450" alt="1" src="https://github.com/user-attachments/assets/c3a9ffdf-e72e-48b0-851a-cf805688c66f" />
<img width="450" height="576" alt="2" src="https://github.com/user-attachments/assets/492ee2c3-31fc-4fc3-96a5-323e3dd9af0f" />
<h3>View attached files for patients i.e. X rays, reports, prescriptions etc by [View Files] button</h3>
<img width="450" height="521" alt="12" src="https://github.com/user-attachments/assets/7fa39892-45a4-408a-846c-22b0eb05c398" />


### Add Doctor
<br>
<img width="450" height="859" alt="3" src="https://github.com/user-attachments/assets/4e7f03a9-8fff-4ef3-ab7d-7370ef00a219" />
<img width="450" height="569" alt="4" src="https://github.com/user-attachments/assets/a988a753-9399-47cb-9c61-b1b2d089714c" />

### Add/Search Appointment
<br>
<img width="450" height="567" alt="5" src="https://github.com/user-attachments/assets/7cbbacd2-5e08-45c4-aa90-6d800234c2ca" />
<img width="450" height="539" alt="6" src="https://github.com/user-attachments/assets/766f614d-2be3-456b-b447-ab1db103ffa7" />
<h3>Filter appointments by range of date</h3>
<img width="450" height="510" alt="13" src="https://github.com/user-attachments/assets/e8f5993a-a9a7-4c68-bcd0-9cb653864154" />

### Add/View Bills (download bills in PDF, [PDF Bill] button given)
<br>
<img width="450" height="545" alt="7" src="https://github.com/user-attachments/assets/6fcaec28-4048-49e5-aa59-8f71ef860dd9" />
<img width="450" height="529" alt="8" src="https://github.com/user-attachments/assets/9c59eccd-fcb1-47b6-b91f-81cb6dcc859d" />

### Add Users + List of all users
<br>
<img width="450" height="536" alt="9" src="https://github.com/user-attachments/assets/612700c4-51df-4ac2-9e97-2d0195702130" />
<img width="450" height="538" alt="10" src="https://github.com/user-attachments/assets/3892cf5a-722d-4f4b-a94a-674059926eca" />


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

**Muhammad Faris Khan** — [@Faris-5683](https://github.com/Faris-5683)
