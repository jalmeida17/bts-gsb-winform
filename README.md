# GSB Medical Prescription Management System

<div align="center">

<p align="center">
<img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/MySQL-8.1-4479A1?style=for-the-badge&logo=mysql&logoColor=white" alt="MySQL" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white" alt="Docker" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" alt="License" style="display: inline-block; margin: 0 2px;"/>
</p>

**A comprehensive medical prescription management application built for the BTS SIO SLAM final exam**

[Features](#features) • [Installation](#installation) • [User Guide](./GUIDE.md) • [Architecture](#architecture) • [Database](#database-schema)

</div>

---

## Table of Contents

- [About](#about-the-project)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Installation](#installation)
- [Complete User Guide](./GUIDE.md) [ Location: [./GUIDE.md](./GUIDE.md) ]
  - [Authentication System]()
  - [Doctor Interface]()
  - [Admin Interface]()
- [Architecture](#architecture)
- [Database Schema](#database-schema)
- [Project Structure](#project-structure)
- [Security](#security)
- [Credits](#credits)

---

## About the Project

The **GSB Medical Prescription Management System** is a Windows Forms application developed as part of the BTS SIO SLAM curriculum. This software enables healthcare facilities to manage patients, medicines, prescriptions, and users through an intuitive desktop interface.

### Key Objectives

- **Role-Based Access Control**: Separate interfaces for Doctors and Administrators
- **Complete CRUD Operations**: Full Create, Read, Update, Delete functionality for all entities
- **PDF Export**: Generate professional medical prescription documents
- **Data Integrity**: MySQL database with cascade operations and referential integrity
- **Security**: SHA-256 password hashing and SQL injection prevention

---

## Features

### For Doctors

- **Patient Management**: Create, view, and delete patient records
- **Medicine Catalog**: Maintain a comprehensive database of medicines with molecules, dosages, and descriptions
- **Prescription Creation**: Build multi-medicine prescriptions with quantities
- **PDF Export**: Generate professional prescription documents
- **Inline Editing**: Quick updates to medicine information directly in the grid
- **Self-Service Password Reset**: Change password securely

### For Administrators

- **User Management**: Create, update, and delete user accounts (doctors and admins)
- **Role Assignment**: Grant admin or doctor privileges
- **Password Management**: Reset passwords for any user
- **Inline User Editing**: Direct grid editing with real-time database updates
- **System Oversight**: Complete control over all system users

---

## Tech Stack

### Frontend
- **Windows Forms (.NET 8.0)**: Modern desktop UI framework
- **C#**: Primary programming language

### Backend
- **ADO.NET**: Direct database access with MySql.Data
- **3-Layer Architecture**: Models, DAO (Data Access Objects), Forms

### Database
- **MySQL 8.1**: Relational database with ACID compliance
- **Docker**: Containerized database deployment
- **phpMyAdmin**: Web-based database administration

### Libraries & Packages
- **iText7** (v9.4.0): Professional PDF generation
- **MySql.Data** (v9.5.0): MySQL .NET connector
- **iText7.bouncy-castle-adapter** (v9.4.0): Cryptographic support for PDFs

---

## Installation

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or Runtime (Windows)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (for MySQL database)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or later (recommended)
- Git (for cloning the repository)

### Step 1: Clone the Repository

```bash
git clone https://github.com/RyukSylux/bts-gsb-winform.git
cd bts-gsb-winform
```

### Step 2: Start the Database

```bash
docker-compose up -d
```

This will start:
- **MySQL Server** on port `3307`
- **phpMyAdmin** on port `8080` ([http://localhost:8080](http://localhost:8080))

### Step 3: Create the Database

1. Access phpMyAdmin at [http://localhost:8080](http://localhost:8080)
2. Login with:
   - **Server**: `db`
   - **Username**: `root`
   - **Password**: `rootpassword`
3. Create a new database named `bts-gsb`
4. Execute the SQL schema from [DATABASE.md](DATABASE.md)

### Step 4: Create First Admin User

Run this SQL query to create your first admin account:

```sql
INSERT INTO User (firstname, name, role, email, password)
VALUES ('Admin', 'User', 1, 'admin@gsb.fr', SHA2('admin123', 256));
```

### Step 5: Build and Run the Application

**Using Visual Studio:**
1. Open `bts-gsb.sln`
2. Press `F5` or click "Start"

**Using Command Line:**
```bash
dotnet build bts-gsb.sln
dotnet run --project bts-gsb.csproj
```

### Default Login Credentials

- **Email**: `admin@gsb.fr`
- **Password**: `admin123`

---


## Architecture

### System Architecture Diagram

```
┌───────────────────────────────────────────────────────────────┐
│                         PRESENTATION LAYER                    │
│                        (Windows Forms UI)                     │
├───────────────────────────────────────────────────────────────┤
│  ┌─────────────┐  ┌─────────────┐  ┌──────────────────────┐   │
│  │  MainForm   │  │  AdminForm  │  │    DoctorForm        │   │
│  │  (Login)    │  │  (Users)    │  │  (Patients/Meds/Rx)  │   │
│  └─────────────┘  └─────────────┘  └──────────────────────┘   │
│  ┌──────────────────┐  ┌──────────────────┐  ┌──────────────┐ │
│  │ PasswordForm     │  │ UserCreatorForm  │  │ PatientForm  │ │
│  └──────────────────┘  └──────────────────┘  └──────────────┘ │
│  ┌──────────────────┐  ┌────────────────────────────────────┐ │
│  │ MedicineForm     │  │   PrescriptionForm                 │ │
│  └──────────────────┘  └────────────────────────────────────┘ │
└────────────────────────────┬──────────────────────────────────┘
                             │ Uses
                             ▼
┌───────────────────────────────────────────────────────────────┐
│                       BUSINESS LOGIC LAYER                    │
│                      (Data Access Objects)                    │
├───────────────────────────────────────────────────────────────┤
│  ┌──────────┐  ┌───────────┐  ┌──────────────┐  ┌───────────┐ │
│  │ UserDAO  │  │PatientDAO │  │ MedicineDAO  │  │ PrescriptionDAO│
│  └──────────┘  └───────────┘  └──────────────┘  └───────────┘ │
│  ┌──────────────┐  ┌──────────────────────────────────────┐   │
│  │ AppartientDAO│  │        Database.cs                   │   │
│  └──────────────┘  └──────────────────────────────────────┘   │
└────────────────────────────┬──────────────────────────────────┘
                             │ Maps to
                             ▼
┌───────────────────────────────────────────────────────────────┐
│                         DATA MODEL LAYER                      │
│                       (Entity Classes)                        │
├───────────────────────────────────────────────────────────────┤
│  ┌────────┐  ┌─────────┐  ┌──────────┐  ┌──────────────┐      │
│  │  User  │  │ Patient │  │ Medicine │  │ Prescription │      │
│  └────────┘  └─────────┘  └──────────┘  └──────────────┘      │
│  ┌─────────────┐                                              │
│  │ Appartient  │  (Junction Model)                            │
│  └─────────────┘                                              │
└────────────────────────────┬──────────────────────────────────┘
                             │ Persisted in
                             ▼
┌─────────────────────────────────────────────────────────────────┐
│                          DATA LAYER                             │
│                      (MySQL Database)                           │
├─────────────────────────────────────────────────────────────────┤
│  Database: bts-gsb (MySQL 8.1)                                  │
│  Connection: MySql.Data via ADO.NET                             │
│  Port: 3307 (Docker container)                                  │
│  ┌──────────────────────────────────────────────────────────┐   │
│  │ Tables: User, Patient, Medicine, Prescription, Appartient│   │
│  │ Constraints: Foreign Keys, Cascade Delete, Unique Email  │   │
│  └──────────────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────────────┘
```

### Architectural Patterns

**1. Three-Layer Architecture**
- **Presentation Layer**: Windows Forms (UI logic, event handling, validation)
- **Business Logic Layer**: DAO classes (CRUD operations, SQL queries)
- **Data Layer**: MySQL database (data persistence, constraints)

**2. Data Access Object (DAO) Pattern**
- Abstracts database operations behind clean interfaces
- Each entity has dedicated DAO class
- Encapsulates SQL queries and connection management

**3. Model-View Pattern**
- Models represent database entities with navigation properties
- Forms (Views) display and manipulate models
- No explicit Controller layer (logic in Forms)

### Data Flow Example: Creating a Prescription

```
1. User Action
   └─> Doctor selects patient, clicks "+ New Prescription" button

2. Form Presentation
   └─> PrescriptionForm opens with patient context

3. Medicine Selection
   └─> Doctor selects medicines and quantities
   └─> MedicineSelection objects stored in local list

4. Form Submission
   └─> "Create Prescription" button clicked

5. Prescription Creation (DAO Layer)
   └─> PrescriptionDAO.Create(prescription, userId)
       └─> SQL: INSERT INTO Prescription (id_patient, id_user, validity) VALUES (...)
       └─> Returns: New prescription ID (LAST_INSERT_ID)

6. Medicine Association (DAO Layer)
   └─> For each selected medicine:
       └─> AppartientDAO.AddMedicineToPrescription(prescriptionId, medicineId, quantity)
           └─> SQL: INSERT INTO Appartient (id_prescription, id_medicine, quantity) VALUES (...)

7. Database Persistence
   └─> MySQL stores records with referential integrity

8. UI Update
   └─> Form closes with DialogResult.OK
   └─> DoctorForm refreshes prescription grid
   └─> New prescription visible in grid
```

### Technology Stack Layers

```
┌─────────────────────────────────────────┐
│          Application Layer              │
│  .NET 8.0 Windows Forms (C#)            │
└─────────────────────────────────────────┘
                   ↕
┌─────────────────────────────────────────┐
│         Data Access Layer               │
│  ADO.NET (MySql.Data 9.5.0)             │
│  Parameterized Queries                  │
└─────────────────────────────────────────┘
                   ↕
┌─────────────────────────────────────────┐
│         Database Layer                  │
│  MySQL 8.1 (Docker Container)           │
│  Port: 3307                             │
└─────────────────────────────────────────┘
                   ↕
┌─────────────────────────────────────────┐
│         Infrastructure Layer            │
│  Docker Desktop                         │
│  phpMyAdmin (Port 8080)                 │
└─────────────────────────────────────────┘
```

### Additional Libraries

**PDF Generation:**
- iText7 (v9.4.0): Document creation, layout, tables
- iText7.bouncy-castle-adapter (v9.4.0): Cryptographic functions

**UI Binding:**
- BindingList<T>: Two-way data binding for DataGridView
- DataGridView: Native WinForms control for tabular data

---

## Database Schema

### Entity Relationship Diagram

**Location**: [./diagram.drawio](./diagram.drawio)

### Table Details

#### User Table
```sql
CREATE TABLE User (
    id_user INT AUTO_INCREMENT PRIMARY KEY,
    firstname VARCHAR(100) NOT NULL,
    name VARCHAR(100) NOT NULL,
    role BOOLEAN NOT NULL,              -- false = Doctor, true = Admin
    email VARCHAR(150) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL      -- SHA-256 hash (64 chars)
);
```

**Constraints:**
- `email` must be unique
- All fields except `id_user` are required

**Indexes:**
- Primary Key: `id_user`
- Unique Index: `email`

---

#### Patient Table
```sql
CREATE TABLE Patient (
    id_patient INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT NOT NULL,
    name VARCHAR(100) NOT NULL,
    firstname VARCHAR(100) NOT NULL,
    age INT,
    gender BOOLEAN,                     -- false = Female, true = Male
    FOREIGN KEY (id_user) REFERENCES User(id_user)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
```

**Constraints:**
- `id_user` foreign key to User table
- Cascade delete: Deleting user removes all their patients

**Indexes:**
- Primary Key: `id_patient`
- Foreign Key Index: `id_user`

---

#### Medicine Table
```sql
CREATE TABLE Medicine (
    id_medicine INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT NOT NULL,
    name VARCHAR(150) NOT NULL,
    molecule VARCHAR(150),
    dosage VARCHAR(100),
    description TEXT,
    FOREIGN KEY (id_user) REFERENCES User(id_user)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
```

**Constraints:**
- `id_user` foreign key to User table
- Cascade delete: Deleting user removes all their medicines

**Indexes:**
- Primary Key: `id_medicine`
- Foreign Key Index: `id_user`

---

#### Prescription Table
```sql
CREATE TABLE Prescription (
    id_prescription INT AUTO_INCREMENT PRIMARY KEY,
    id_patient INT NOT NULL,
    id_user INT NOT NULL,
    validity DATE,
    FOREIGN KEY (id_patient) REFERENCES Patient(id_patient)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (id_user) REFERENCES User(id_user)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
```

**Constraints:**
- `id_patient` foreign key to Patient table
- `id_user` foreign key to User table
- Cascade delete: Deleting patient or user removes prescriptions

**Indexes:**
- Primary Key: `id_prescription`
- Foreign Key Index: `id_patient`
- Foreign Key Index: `id_user`

---

#### Appartient Table (Junction Table)
```sql
CREATE TABLE Appartient (
    id_prescription INT NOT NULL,
    id_medicine INT NOT NULL,
    quantity INT,
    PRIMARY KEY (id_prescription, id_medicine),
    FOREIGN KEY (id_prescription) REFERENCES Prescription(id_prescription)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (id_medicine) REFERENCES Medicine(id_medicine)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
```

**Constraints:**
- Composite primary key: `(id_prescription, id_medicine)`
- No duplicate medicine in same prescription
- Cascade delete: Deleting prescription or medicine removes relationships

**Indexes:**
- Primary Key: `(id_prescription, id_medicine)`
- Foreign Key Index: `id_prescription`
- Foreign Key Index: `id_medicine`

---

### Relationships

**One-to-Many Relationships:**
1. **User → Patient**: One doctor creates many patients
2. **User → Medicine**: One doctor creates many medicines
3. **User → Prescription**: One doctor creates many prescriptions
4. **Patient → Prescription**: One patient has many prescriptions

**Many-to-Many Relationship:**
- **Prescription ↔ Medicine**: One prescription contains many medicines, one medicine appears in many prescriptions
- Junction table: `Appartient` with quantity attribute

### Cascade Behavior

**Delete User → Cascades to:**
- All Patient records where `id_user` matches
  - Which cascades to all Prescription records for those patients
    - Which cascades to all Appartient records for those prescriptions
- All Medicine records where `id_user` matches
  - Which cascades to all Appartient records for those medicines
- All Prescription records where `id_user` matches
  - Which cascades to all Appartient records

**Delete Patient → Cascades to:**
- All Prescription records where `id_patient` matches
  - Which cascades to all Appartient records

**Delete Medicine → Cascades to:**
- All Appartient records where `id_medicine` matches

**Delete Prescription → Cascades to:**
- All Appartient records where `id_prescription` matches

---

## Project Structure

```
bts-gsb-winform/
│
├── DAO/                              # Data Access Objects
│   ├── AppartientDAO.cs             # Prescription-Medicine relationships
│   ├── Database.cs                   # Database connection management
│   ├── MedicineDAO.cs               # Medicine CRUD operations
│   ├── PatientDAO.cs                # Patient CRUD operations
│   ├── PrescriptionDAO.cs           # Prescription CRUD operations
│   └── UserDAO.cs                    # User CRUD and authentication
│
├── Forms/                            # Windows Forms UI
│   ├── AdminForm.cs                  # Admin user management interface
│   ├── AdminForm.Designer.cs        # Admin form UI definition
│   ├── DoctorForm.cs                # Main doctor interface (tabs)
│   ├── DoctorForm.Designer.cs       # Doctor form UI definition
│   ├── MainForm.cs                   # Login screen
│   ├── MainForm.Designer.cs         # Login form UI definition
│   ├── MedecineCreatorForm.cs       # Medicine creation dialog
│   ├── MedecineCreatorForm.Designer.cs
│   ├── PasswordForm.cs              # Password reset interface
│   ├── PasswordForm.Designer.cs
│   ├── PatientCreatorForm.cs        # Patient creation dialog
│   ├── PatientCreatorForm.Designer.cs
│   ├── PrescriptionForm.cs          # Prescription creation interface
│   ├── PrescriptionForm.Designer.cs
│   ├── UserCreatorForm.cs           # User creation dialog
│   └── UserCreatorForm.Designer.cs
│
├── Models/                           # Entity models
│   ├── Appartient.cs                # Prescription-Medicine junction
│   ├── Medicine.cs                   # Medicine entity
│   ├── Patient.cs                    # Patient entity
│   ├── Prescription.cs              # Prescription entity
│   └── User.cs                       # User entity
│
├── Properties/                       # Application resources
│   └── ...                          # Assembly info, resources
│
├── assets/                           # Documentation assets
│   └── images/                      # Screenshots for README
│       ├── adminpage.png
│       ├── createprescription.png
│       ├── filledcreateprescription.png
│       ├── medicinecreator.png
│       ├── medicineprescription.png
│       ├── medicines.png
│       ├── patientcreator.png
│       ├── patients.png
│       ├── prescriptions.png
│       ├── resetpassword.png
│       ├── signin.png
│       └── usercreator.png
│
├── bin/                              # Build output (ignored in git)
│   └── Debug/net8.0-windows/        # Compiled executable
│
├── obj/                              # Intermediate build files
│
├── app.config.cs                    # Configuration file (empty)
├── bts-gsb.csproj                   # Project file
├── bts-gsb.sln                      # Solution file
├── compose.yml                      # Docker Compose for MySQL
├── DATABASE.md                      # Database schema documentation
├── diagram.drawio                   # Architecture diagram
├── Program.cs                        # Application entry point
└── README.md                        # This file
```

### File Responsibilities

**DAO Layer:**
- Handle all database connections
- Execute SQL queries with parameterized statements
- Return domain models (not raw SQL results)
- Throw exceptions with descriptive messages

**Forms Layer:**
- Handle user input and events
- Validate data before passing to DAO
- Display success/error messages to user
- Manage navigation between forms

**Models Layer:**
- Represent database entities
- Define navigation properties for relationships
- Use Data Annotations for validation attributes
- Provide clean object structure for data binding

---

## Security

### Authentication & Authorization

**Password Security:**
- Hashing: SHA-256 (256-bit cryptographic hash)
- Storage: Only hash stored in database (64-character hexadecimal string)
- Login: Password hashed at database level during comparison
- Update: New passwords immediately hashed before storage

**Role-Based Access Control:**
- Two roles: Admin (true) and Doctor (false)
- Route-based authorization: Login redirects based on role
- Interface segregation: Admins and doctors see different forms
- No row-level security: Users can access all records in their interface

### SQL Injection Prevention

**Parameterized Queries:**
All database operations use parameterized statements:
```csharp
command.CommandText = "SELECT * FROM User WHERE email = @email";
command.Parameters.AddWithValue("@email", email);
```

**Benefits:**
- User input treated as data, not executable code
- Prevents malicious SQL injection attacks
- No need for manual escaping of special characters


---

## Credits

**PdfExport by:** [RyukSylux](https://github.com/RyukSylux)

**GitHub Repository:** [bts-gsb-winform](https://github.com/RyukSylux/bts-gsb-winform)

**Academic Context:** BTS SIO SLAM Final Exam Project

**Technologies:**
- Microsoft .NET Framework Team - .NET 8.0
- Oracle Corporation - MySQL Database
- iText Software - iText7 PDF Library
- Docker Inc. - Docker containerization

---

## License

This project is licensed under the MIT License.

---

## Educational Disclaimer

This project was developed as an educational submission for the BTS SIO SLAM final exam. It is not intended for production use in a real medical environment. For production healthcare applications, additional security measures, regulatory compliance (HIPAA, GDPR), and professional medical software development practices would be required.

---

<div align="center">

**Made by [jalmeida17](https://github.com/jalmeida17) for the BTS SIO SLAM Curriculum**


</div>
