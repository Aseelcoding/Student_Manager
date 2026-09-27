# Student Manager

A Windows desktop application for managing student records, study programs, staff access, and related contact information.

The project is built with C#, Windows Forms, .NET Framework 4.7.2, and Microsoft SQL Server. It follows a layered structure that separates the user interface, business logic, and database access responsibilities.

> Project status: The core application is substantially implemented and represents an approximately 70% complete development project. The repository is presented as a complete working project while some features and refinements can still be extended in future iterations.

## Overview

Student Manager provides a desktop environment for managing university student information.

### Current Features
- Staff login and access control
- Student listing and management
- Add student functionality
- Update student functionality
- Student search and filtering
- Study program management and filtering
- Student contact information
- Student profile images
- SQL Server database integration
- Layered application architecture
- Current staff and student data models
- Program-level student statistics

## Main Features

### Staff Login

The application starts with a login screen where staff members provide a username and password. The credentials are checked against the Staff table. When authentication succeeds, the current staff information is stored in the application session model and the main screen is displayed.

### Student Management

The main screen provides access to student records and supports viewing, adding, updating, searching, filtering, and displaying profile images.

Search and filtering can be performed using Student ID, student name, study level, program, Contact ID, and date of birth.

### Add Student

The Add Student form collects name, email, phone, study level, study program, date of birth, address, and personal photo. The selected image is copied to a persistent folder under the user's Documents directory and its path is stored in the database.

### Update Student

Existing student records can be loaded by Student ID and updated. The workflow supports editing personal information, contact information, study level, study program, address, and profile image.

### Study Programs

The Programs section displays Program ID, program name, study level, and number of students. Programs can be filtered by their available fields.

## Architecture

~~~text
Presentation Layer (Windows Forms)
              |
              v
Business Logic Layer
              |
              v
Data Access Layer (ADO.NET / SQL)
              |
              v
Microsoft SQL Server
~~~

### Presentation Layer

The Windows Forms application contains the user-facing forms:
- Login
- Main Screen
- Add Student
- Update Student
- Programs

These forms handle user interaction and communicate with the Business Logic Layer rather than executing database queries directly.

### Business Logic Layer

Implemented mainly in the Student_Manager_ Business Logic Layer project. It provides application-level operations such as staff authentication, creating students, updating students, retrieving students, retrieving a student by ID, retrieving programs, and retrieving program statistics.

### Data Access Layer

Implemented in the Student_Manager_DataAsccess project. It uses ADO.NET and SqlClient to communicate with SQL Server and handles SELECT, INSERT, UPDATE, JOIN, parameterized SQL commands, and generated IDs through SCOPE_IDENTITY().

## Database Design

### Staff
- StaffID — staff identifier
- Name — staff name
- UserName — login username
- Password — login password

### Student
- StudentID — student identifier
- Name — student name
- ProgramID — related study program
- DateOfBirth — date of birth
- ContactID — related contact record
- Address — student address
- ImagePath — stored profile image path

### Program
- ProgramID — program identifier
- Name — program name
- Level — Bachelor, Master, or Doctoral

### Contact
- ContactID — contact identifier
- Phone — phone number
- Email — email address

### Staff_Log

The database design also defines a logging table for tracking staff operations such as Add, Delete, and Update, together with the related staff member, student, and operation time.

## Data Relationships

~~~text
Program
   |
   +----< Student >---- Contact

Staff
   |
   +----< Staff_Log >---- Student
~~~

Each student is associated with a study program and a contact record. Foreign keys are used to maintain these relationships.

## Authentication Flow

~~~text
User enters username + password
              |
              v
        Login Form
              |
              v
 BusinessLogic.IsStaffExist()
              |
              v
 DataAccess.IsStaffExist()
              |
              v
        SQL Server Staff
              |
        +-----+-----+
        |           |
      Found      Not Found
        |           |
        v           v
 Store current    Reject
 staff data       login
        |
        v
    Main Screen
~~~

SQL parameters are used when checking the supplied username and password.

## Student Creation Flow

~~~text
Add Student Form
       |
       v
Validate input
       |
       v
Create student object
       |
       v
Business Logic Layer
       |
       v
Data Access Layer
       |
       +-- Create Contact
       +-- Find Program ID
       +-- Insert Student
       |
       v
   SQL Server
~~~

The contact record is created first, and its generated ID is then associated with the student record.

## Image Handling

Student images are stored outside the database. The application lets the user select an image, creates an application folder inside the user's Documents directory, generates a unique file name using a GUID, copies the image into the folder, and stores the resulting path in the database.

## Technologies

| Technology | Usage |
|---|---|
| C# | Application development |
| Windows Forms | Desktop user interface |
| .NET Framework 4.7.2 | Application framework |
| ADO.NET | Database communication |
| Microsoft SQL Server | Data storage |
| SQL | Database queries and relationships |
| Visual Studio | Development environment |

## Project Structure

~~~text
Student_Manager/
|-- Add Student/
|-- Login/
|-- Main Screen/
|-- Programs/
|-- Update Student/
|-- Student Data/
|-- Staff Data/
|-- Student_Manager_ Business Logic Layer/
|-- Student_Manager_DataAsccess/
|-- Documentation/
|-- Icons/
|-- Program.cs
|-- App.config
|-- Student_Manager.csproj
+-- Student_Manager.slnx
~~~

## Getting Started

### Prerequisites
- Windows
- Visual Studio with Windows Forms development support
- .NET Framework 4.7.2
- Microsoft SQL Server
- SQL Server Management Studio or another SQL management tool

### 1. Clone the repository

~~~bash
git clone https://github.com/Aseelcoding/Student_Manager.git
~~~

### 2. Create the database

Create a SQL Server database named Student_Manager_DB. Use the SQL definitions documented in Database tables.md.txt to create the required tables and relationships.

### 3. Configure the database connection

Update the connection string in Student_Manager_DataAsccess/clsDataAccessSeetings.cs. The current project uses a local SQL Server configuration, so the server name must be changed to the SQL Server instance available on the target machine.

Example:

~~~csharp
public static string connectionString =
    "Server=YOUR_SERVER;Database=Student_Manager_DB;Integrated Security=True;";
~~~

### 4. Open the solution

Open Student_Manager.slnx in Visual Studio.

### 5. Build and run

Build the solution and run the application. The application starts at the login screen.

## Security Notes

This project is a learning-oriented desktop application and should not be treated as production-ready authentication software without further security work.

Important considerations:
- Passwords are currently compared directly against database values.
- Passwords are stored as database values rather than using a password-hashing system.
- The current database connection configuration is machine-specific.
- Production deployment should use secure password hashing, stronger validation, safer configuration management, and appropriate authorization controls.
- Sensitive configuration values should not be committed directly to source control.

## Current Scope

The current implementation focuses on the core student-management workflow: staff login, student records, student contact information, study programs, student search, student updates, profile image management, SQL Server persistence, and separation between UI, business logic, and data access.

The architecture is designed to support further expansion.

## Future Improvements

- Complete staff management
- Complete operation logging
- Student deletion workflow
- Stronger validation
- Secure password hashing
- Improved configuration management
- More comprehensive error handling
- Transaction support for multi-step database operations
- Additional reporting features
- Better role-based authorization
- Database backup and restore support
- Improved UI/UX
- Automated testing
- More complete documentation

## Learning Objectives

This project was developed as a practical exercise in desktop application and database development. It demonstrates work with:
- Object-oriented programming
- C# and Windows Forms
- Event-driven programming
- SQL Server database design
- Relational database concepts
- ADO.NET
- Parameterized SQL
- CRUD operations
- Foreign keys and relationships
- DataTable and DataView
- Layered architecture
- Form-to-form communication
- File and image handling
- Basic authentication workflows

## Author

**Aseelcoding**

GitHub: https://github.com/Aseelcoding

Repository: https://github.com/Aseelcoding/Student_Manager

## License

No license has currently been specified for this repository.