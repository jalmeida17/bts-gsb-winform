# BTS GSB - Medical Prescription Management System

A Windows Forms desktop application for managing medical prescriptions, patient records, and pharmaceutical databases. Built as part of a BTS (Brevets de Technicien Supérieur) educational project demonstrating database design, CRUD operations, and enterprise application architecture.

## Overview

BTS GSB Winform is a comprehensive healthcare management system that enables medical professionals to manage patient records, maintain a medicine database, create prescriptions, and generate professional PDF documents. The application features role-based access control with separate interfaces for administrators and doctors.

## Features

### Authentication & Security
- Email-based login system with SHA2-256 password hashing
- Role-based access control (Administrator/Doctor)
- Password reset functionality
- Secure parameterized database queries to prevent SQL injection

### Administrator Functions
- User account management (Create, Read, Update, Delete)
- Role assignment and permission management
- Password administration
- System user oversight

### Doctor Functions
- **Patient Management**: Create and manage patient profiles with demographic information
- **Medicine Database**: Maintain a comprehensive pharmaceutical catalog with molecules, dosages, and descriptions
- **Prescription Creation**: Generate prescriptions by selecting medicines and specifying quantities
- **PDF Export**: Generate professional prescription documents with complete patient and medication details
- **Data Viewing**: Browse and edit records through intuitive DataGridView interfaces

## Technology Stack

### Framework & Runtime
- .NET 8.0 Windows
- C# with nullable reference types
- Windows Forms

### Database
- MySQL 8.1
- Docker containerization with PHPMyAdmin

### Key Dependencies
- **itext7 v9.4.0** - PDF generation and document creation
- **itext7.bouncy-castle-adapter v9.4.0** - Cryptographic support
- **MySql.Data v9.5.0** - MySQL database connectivity

## Prerequisites

- Windows operating system
- .NET 8.0 SDK or later
- Docker Desktop (for database deployment)
- Visual Studio 2022 or Visual Studio Code (recommended)

## Installation

### 1. Clone the Repository
```bash
git clone <repository-url>
cd bts-gsb-winform
```

### 2. Start Database Services
The project uses Docker Compose to run MySQL and PHPMyAdmin:

```bash
docker-compose up -d
```

This will start:
- MySQL 8.1 on `localhost:3307`
- PHPMyAdmin on `http://localhost:8080`

Database credentials:
- Host: `localhost`
- Port: `3307`
- Username: `root`
- Password: `rootpassword`
- Database: `bts-gsb`

### 3. Initialize Database Schema
Refer to `DATABASE.md` for the complete database schema. The database includes:
- User table (authentication and roles)
- Patient table (patient demographics)
- Medicine table (pharmaceutical catalog)
- Prescription table (prescription records)
- Appartient table (prescription-medicine relationships)

### 4. Restore NuGet Packages
```bash
dotnet restore
```

### 5. Build the Application
```bash
dotnet build
```

### 6. Run the Application
```bash
dotnet run
```

Or open `bts-gsb.sln` in Visual Studio and press F5.

## Database Schema

### Core Tables

**User**
- Stores system users (doctors and administrators)
- Password hashing with SHA2-256
- Role-based permissions

**Patient**
- Patient demographic information
- Linked to creating doctor via foreign key
- Supports age and gender fields

**Medicine**
- Comprehensive pharmaceutical database
- Includes name, molecule, dosage, and description
- Creator tracking

**Prescription**
- Links patients with medicines
- Validity date management
- Doctor assignment

**Appartient**
- Junction table for many-to-many relationship
- Stores quantity for each medicine in prescription

## Architecture

The application follows a layered architecture pattern:

```
+-----------------------------------+
|      Presentation Layer           |
|    (Windows Forms / UI)           |
+-----------------------------------+
|      Business Logic Layer         |
|        (Forms Logic)              |
+-----------------------------------+
|    Data Access Layer (DAO)        |
|  (UserDAO, PatientDAO, etc.)      |
+-----------------------------------+
|        Database Layer             |
|     (MySQL Database)              |
+-----------------------------------+
```

### Project Structure

```
bts-gsb-winform/
|
+-- Forms/                        # UI Layer
|   +-- MainForm.cs             # Login interface
|   +-- AdminForm.cs            # Administrator dashboard
|   +-- DoctorForm.cs           # Doctor workspace
|   +-- MedecineCreatorForm.cs  # Medicine creation dialog
|   +-- PatientCreatorForm.cs   # Patient registration dialog
|   +-- PrescriptionForm.cs     # Prescription creation dialog
|   +-- UserCreatorForm.cs      # User account creation
|   \-- PasswordForm.cs         # Password reset interface
|
+-- Models/                       # Data Entities
|   +-- User.cs
|   +-- Patient.cs
|   +-- Medicine.cs
|   +-- Prescription.cs
|   \-- Appartient.cs
|
+-- DAO/                          # Data Access Layer
|   +-- Database.cs             # Connection factory
|   +-- UserDAO.cs              # User operations
|   +-- PatientDAO.cs           # Patient operations
|   +-- MedicineDAO.cs          # Medicine operations
|   +-- PrescriptionDAO.cs      # Prescription operations
|   \-- AppartientDAO.cs        # Relationship operations
|
+-- assets/                       # Resources
|   \-- images/
|       +-- gsb_light.ico
|       \-- gsb_light.png
|
+-- Properties/
|   \-- Resources.resx
|
+-- bts-gsb.csproj              # Project configuration
+-- compose.yml                 # Docker configuration
+-- DATABASE.md                 # Database documentation
\-- Program.cs                  # Application entry point
```

## Usage

### First Login
1. Launch the application
2. Use default credentials to log in (configure in database)
3. Administrator users access the AdminForm
4. Doctor users access the DoctorForm

### Creating a Prescription
1. Log in as a doctor
2. Navigate to the Prescription Management section
3. Select a patient on the Patient section
4. Click "Create Prescription"
5. Add medicines with quantities
6. Save the prescription
7. Export as PDF if needed

### Managing Users (Admin Only)
1. Log in as an administrator
2. View all users in the DataGridView
3. Add new users via the "Add User" button
4. Edit user details inline in the grid
5. Delete users with confirmation
6. Change passwords as needed

### Exporting Prescriptions to PDF
1. Select a prescription from the list
2. Click "Export PDF"
3. Choose save location
4. Professional PDF document is generated with:
   - Patient information
   - Doctor information
   - List of medicines with dosages
   - Validity date
   - Signature area

## Configuration

### Database Connection
The database connection string is defined in `DAO/Database.cs`:

```csharp
Server=localhost;
Port=3307;
Uid=root;
Pwd=rootpassword;
Database=bts-gsb;
```

## Database Management

Access PHPMyAdmin at `http://localhost:8080` to:
- View and edit database tables
- Run SQL queries
- Import/export data
- Monitor database performance

## License

This project is developed for educational purposes as part of the BTS program.

## Credits

Pdf Export feature -> **[RyukSylux](https://github.com/RyukSylux)**

## Acknowledgments

Developed as part of the BTS (Brevets de Technicien Supérieur) curriculum, demonstrating practical application of database design, software architecture, and Windows Forms development.
