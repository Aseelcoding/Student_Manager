# Student Manager

A Windows desktop application for managing student records, study programs, staff accounts, and student contact information.

Built with **C#**, **Windows Forms**, **.NET Framework 4.7.2**, **ADO.NET**, and **Microsoft SQL Server**. The project follows a three-layer architecture separating the Presentation, Business Logic, and Data Access layers.

## Features

### Authentication
- Staff login using username and password
- Current staff information is available after successful authentication

### Student Management
- View student records
- Add students
- Update students
- Delete students
- Search and filter students
- View student profile images

### Student Information
Each student record contains:
- Student ID
- Name
- Date of birth
- Study program
- Phone
- Email
- Address
- Profile image

### Study Programs
- View programs
- View program level
- Filter programs
- Display the number of students per program

### Staff Management
- View staff records
- Add staff accounts
- Delete staff accounts

### Image Management
Student images are stored in the file system. The application creates an image directory under the user's Documents folder, generates a unique filename using a GUID, copies the image, and stores its path in SQL Server.

## Architecture

```text
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
```

### Presentation Layer
Contains the Windows Forms screens:
- Login
- Main Screen
- Add Student
- Update Student
- Programs
- Staff management

The forms communicate with the Business Logic Layer rather than executing database queries directly.

### Business Logic Layer
Handles application operations such as:
- Staff authentication
- Student creation, retrieval, update, and deletion
- Program retrieval and statistics
- Staff operations

### Data Access Layer
Uses ADO.NET / SqlClient for:
- SELECT, INSERT, UPDATE, and DELETE operations
- JOIN queries
- Parameterized SQL
- Generated IDs using `SCOPE_IDENTITY()`
- SQL Server communication

## Database Design

### Staff
`StaffID`, `Name`, `UserName`, `Password`

### Student
`StudentID`, `Name`, `ProgramID`, `DateOfBirth`, `ContactID`, `Address`, `ImagePath`

### Program
`ProgramID`, `Name`, `Level`

Supported levels:
- Bachelor
- Master
- Doctoral

### Contact
`ContactID`, `Phone`, `Email`

### Staff_Log
The schema contains a logging table for staff operations such as Add, Delete, and Update. The logging workflow is not yet fully implemented in the application.

## Relationships

```text
Program
   |
   +----< Student >---- Contact

Staff
   |
   +----< Staff_Log >---- Student
```

Students are connected to programs and contact records through foreign keys.

## Student Creation Flow

```text
Add Student Form
       |
       v
Business Logic Layer
       |
       v
Data Access Layer
       |
       +-- Create Contact
       +-- Get Program ID
       +-- Insert Student
       |
       v
SQL Server
```

The generated Contact ID is retrieved using `SCOPE_IDENTITY()` and associated with the new student.

## Search and Filtering

The main student screen supports filtering by:
- Student ID
- Student name
- Study level
- Program name
- Contact ID
- Date of birth

Student data is loaded into a `DataTable`, with filtering performed through `DataView`.

## Technologies

| Technology | Usage |
|---|---|
| C# | Application development |
| Windows Forms | Desktop UI |
| .NET Framework 4.7.2 | Application framework |
| ADO.NET | Database access |
| Microsoft SQL Server | Data storage |
| SQL | Queries and relationships |
| Visual Studio | Development |
| Git / GitHub | Version control |

## Project Structure

```text
Student_Manager/
├── Add Student/
├── Login/
├── Main Screen/
├── Programs/
├── Update Student/
├── Student Data/
├── Staff Data/
├── Student_Manager_ Business Logic Layer/
├── Student_Manager_DataAsccess/
├── Documentation/
├── Icons/
├── Program.cs
├── App.config
├── Student_Manager.csproj
└── Student_Manager.slnx
```

## Getting Started

### Requirements
- Windows
- Visual Studio
- .NET Framework 4.7.2
- Microsoft SQL Server
- SQL Server Management Studio or another SQL management tool

### 1. Clone

```bash
git clone https://github.com/Aseelcoding/Student_Manager.git
```

### 2. Create the database

Create a SQL Server database named:

```text
Student_Manager_DB
```

Use `Database tables.md.txt` in the repository for the required tables and relationships.

### 3. Configure the connection

Update:

```text
Student_Manager_DataAsccess/clsDataAccessSeetings.cs
```

with the SQL Server instance available on your machine.

Example:

```csharp
public static string connectionString =
    "Server=YOUR_SERVER;Database=Student_Manager_DB;Integrated Security=True;";
```

### 4. Run

Open `Student_Manager.slnx` in Visual Studio, build the solution, and run the application.

## Current Limitations

The project is functional but is still being refined. The main remaining areas are:

- Password hashing
- Stronger input validation
- More comprehensive exception handling
- Transaction support for multi-step database operations
- Complete operation logging
- Role-based authorization
- Safer configuration management
- Automated testing
- UI/UX refinement
- More consistent database documentation

## Security Notes

This is a learning-oriented desktop application and should not be considered production-ready authentication software.

Current limitations include:
- Passwords are compared directly with database values.
- Passwords are not currently protected with a password-hashing system.
- Database configuration is machine-specific.

Production deployment should use secure password hashing, safer configuration management, stronger validation, and appropriate authorization controls.

## Learning Objectives

This project provides practical experience with:
- C# and OOP
- Windows Forms
- Event-driven programming
- SQL Server
- Relational database design
- ADO.NET
- Parameterized SQL
- CRUD operations
- Foreign keys and relationships
- DataTable and DataView
- Three-layer architecture
- Form-to-form communication
- File and image handling
- Basic authentication
- Git and GitHub

## Future Improvements

- Secure password hashing
- Better validation and error handling
- Database transactions
- Complete staff operation logging
- Role-based authorization
- Automated testing
- Database backup and restore
- Improved UI/UX
- Additional reporting
- Cleaner project naming
- Updated database documentation

## Author

**Aseelcoding**

GitHub: https://github.com/Aseelcoding

Repository: https://github.com/Aseelcoding/Student_Manager

## License

No license has currently been specified for this repository.
