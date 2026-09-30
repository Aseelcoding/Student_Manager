# Student Manager

A Windows Forms desktop application for managing students, study programs, staff accounts, and related student information.

This project was built as a learning project to practice **C#**, **Object-Oriented Programming**, **Windows Forms**, **SQL Server**, **ADO.NET**, database relationships, and a **three-layer architecture**.

> **Important:** This project is not presented as production-ready software. It is a snapshot of my learning process and the problems I discovered while building a real CRUD-based desktop application.

---

## Project Overview

Student Manager provides a basic system for:

- Staff login
- Student management
- Study program management
- Staff management
- Student contact information
- Student profile images
- Searching and filtering
- Staff operation logging (currently being developed)

The application communicates with SQL Server through a Data Access Layer and uses a Business Logic Layer between the database and the Windows Forms UI.

---

## Main Features

### Authentication

- Staff login
- Current staff information is stored during the application session

### Student Management

- Add students
- View students
- Update students
- Delete students
- Search and filter students
- Store student profile images

### Program Management

- Add programs
- Update programs
- Delete programs
- Filter programs by study level
- Display the number of students in programs

### Staff Management

- View staff
- Add staff
- Delete staff
- Prevent deleting the currently logged-in staff member
- Prevent deleting the last remaining staff account

### Staff Logs

The project contains the database structure and application components for staff operation logs.

The logging workflow is still being completed and improved.

**Staff Log is not included as a negative point in the project evaluation because it is currently under development.**

---

## Architecture

The project follows a basic three-layer architecture:

```text
Windows Forms / Presentation
          |
          v
Business Logic Layer
          |
          v
Data Access Layer
          |
          v
SQL Server
```

### Presentation Layer

Contains the Windows Forms used by the application.

Examples:

- Login
- Main Screen
- Student forms
- Program forms
- Staff forms
- Staff Log form

### Business Logic Layer

Responsible for:

- Input validation
- Student operations
- Staff operations
- Program operations
- Calling the Data Access Layer
- Basic application rules
- Creating staff operation logs

### Data Access Layer

Uses ADO.NET / SqlClient for:

- SQL queries
- CRUD operations
- JOIN queries
- Parameterized SQL
- Foreign key relationships
- Identity retrieval using `SCOPE_IDENTITY()`

---

## Database

The main entities include:

- Staff
- Student
- Program
- Contact
- Staff_Log

Basic relationship:

```text
Program
   |
   +----< Student >---- Contact

Staff
   |
   +----< Staff_Log
```

The database is designed to practice relational database concepts and foreign-key relationships.

---

## Image Management

Student images are copied to a dedicated folder under the user's Documents directory.

A GUID is used to generate a unique filename before the path is stored in the database.

This avoids relying on the original filename and reduces filename collisions.

---

# Honest Project Evaluation

## Current Score: 8.3 / 10

This score is intentionally honest and is based on the **current implementation**, not on what the project could become after future improvements.

The score is also being established as a **baseline for future projects**.

Future projects will be evaluated using the same general standards rather than receiving an easier score simply because they are newer.

### Evaluation Baseline

| Area | What is evaluated |
|---|---|
| Functionality | Does the application actually work and cover its intended requirements? |
| C# / OOP | Classes, methods, encapsulation, reuse, and understanding of C# fundamentals |
| Architecture | Separation of responsibilities and maintainability |
| Database / SQL | Schema design, relationships, queries, constraints, and SQL understanding |
| Data Access | ADO.NET usage, parameterized queries, resource handling, and database interaction |
| Business Logic | Validation, application rules, and separation from UI/database code |
| UI / UX | Usability, consistency, navigation, and practical Windows Forms implementation |
| Validation | Handling invalid, missing, unexpected, and boundary input |
| Error Handling | Exception strategy, useful error messages, and avoiding unnecessary exception handling |
| Security | Password protection, authorization, configuration safety, and sensitive data handling |
| Code Quality | Naming, duplication, structure, readability, and maintainability |
| Testing | Automated tests and confidence in application behavior |
| Documentation | README quality, database documentation, setup instructions, and explanation of design |
| Production Readiness | Reliability, security, configuration, scalability, and maintainability |

**Baseline score: 8.3 / 10**

The score is a snapshot of the project at its current learning stage. It is not a claim that the application is production-ready.

---

# Problems I Discovered

This project taught me that making an application work is only one part of software development.

The following are real weaknesses I identified in the current implementation.

### 1. Password Security

Passwords are currently stored and handled as plain text.

This is one of the biggest security problems in the project.

The next projects should use proper password hashing instead of storing or displaying raw passwords.

### 2. Hardcoded Database Configuration

The connection string currently contains a machine-specific SQL Server name.

This makes the project less portable and is not a good configuration strategy for a real application.

A future project should use safer and environment-independent configuration.

### 3. Weak Authorization Model

The current authentication system mainly checks whether the username and password match.

There is no proper role-based authorization system controlling what different staff members are allowed to do.

### 4. Validation Is Too Rigid

Some validation rules are hardcoded directly into the business logic.

For example, the current date-of-birth validation uses fixed year boundaries.

This works for the current learning scenario but is not a flexible design for a real application.

### 5. Exception Handling Needs Improvement

The project uses exception handling in several places, but the strategy is not yet consistent.

Some exceptions are caught only to display a message, while some methods use unnecessary patterns such as catching an exception and immediately using `throw;`.

The next project should have a clearer exception-handling strategy.

### 6. Multi-Step Database Operations Need Transactions

Some operations involve more than one database action.

For example, creating a student can involve creating contact information and then creating the student record.

These operations should be protected with database transactions so that a partial failure does not leave inconsistent data.

### 7. Static Business Logic

A large part of the Business Logic Layer is implemented through static methods.

This works for the current project, but it makes the architecture harder to scale, test, and extend.

Future projects should use a cleaner object-oriented service structure where appropriate.

### 8. Data Access Layer Is Becoming Too Large

As more features were added, the Data Access Layer became increasingly large.

This makes responsibilities harder to isolate and maintain.

Future projects should organize database operations into clearer, focused components.

### 9. UI Still Contains Too Much Application Logic

Some forms handle validation, navigation, filtering, state management, and application behavior directly.

This makes forms harder to maintain as the application grows.

The next project should move more logic away from the UI layer.

### 10. Sensitive Information Is Displayed in the Staff Screen

The staff management screen currently displays stored passwords.

This is a direct consequence of the current plain-text password design and should not exist in a real application.

### 11. Image Lifecycle Management

The project copies images into an application folder, but image lifecycle management is not fully designed.

For example, replacing or deleting a student's image should also consider what happens to the old physical file.

### 12. No Automated Testing

There are currently no proper automated unit/integration tests.

Most verification has been performed manually while developing the application.

This is acceptable for a learning project, but it is an important area for improvement.

### 13. Naming and Project Organization

Some names are inconsistent or contain mistakes, for example:

- `DataAsccess`
- `Seetings`
- `frmAddStduent`
- `Student_Manager_ Business Logic Layer`

These do not stop the application from working, but they reduce code quality and maintainability.

### 14. Database Documentation Can Be Better

The database documentation exists, but it could be more complete and consistent with the actual implementation.

Future projects should document the schema, relationships, constraints, and important database decisions more clearly.

---

# What I Learned From These Problems

These problems are not being hidden from the project.

They are part of the reason this project exists.

While building Student Manager, I learned that:

- Working code is not automatically good architecture.
- CRUD functionality is only the beginning.
- Security must be designed from the beginning.
- Database operations need consistency and transaction thinking.
- Validation should be based on business rules rather than arbitrary hardcoded assumptions.
- Exception handling needs a clear strategy.
- UI code should not become the place where everything happens.
- Naming and structure matter as a project becomes larger.
- Testing should be considered during development, not only after the project is finished.
- A project can be functional while still having significant engineering weaknesses.

The important part is that these weaknesses are now known.

---

# Next Project: Applying What I Learned

The next major project will be built with these problems in mind.

The goal is not simply to create another application with more features.

The goal is to create a project that demonstrates improvement in the areas where Student Manager is weak.

The next project will aim to improve:

- Secure authentication
- Password hashing
- Role-based authorization
- Better configuration management
- Cleaner architecture
- Better separation of UI and business logic
- More focused data-access components
- Transaction-based database operations
- Stronger validation
- More consistent exception handling
- Automated testing
- Better naming and project organization
- Better database documentation
- Better handling of files and images
- More maintainable application structure

The next project will be evaluated against the same baseline used here.

---

# Learning Progression

Student Manager represents one stage of my development as a software developer.

The objective is not to pretend that this project has no problems.

The objective is to identify the problems, understand why they exist, and avoid repeating them.

```text
Student Manager
      |
      v
Identify weaknesses
      |
      v
Learn better engineering practices
      |
      v
Build the next project
      |
      v
Apply the lessons
      |
      v
Repeat
```

Each future project should demonstrate measurable improvement in architecture, security, testing, maintainability, and overall engineering quality.

---

## Technologies

| Technology | Purpose |
|---|---|
| C# | Application development |
| Windows Forms | Desktop UI |
| .NET Framework 4.7.2 | Application framework |
| ADO.NET | Database access |
| Microsoft SQL Server | Database |
| SQL | Queries and relationships |
| Visual Studio | Development |
| Git / GitHub | Version control |

---

## Getting Started

### Requirements

- Windows
- Visual Studio
- .NET Framework 4.7.2
- Microsoft SQL Server
- SQL Server Management Studio or another SQL management tool

### 1. Clone the Repository

```bash
git clone https://github.com/Aseelcoding/Student_Manager.git
```

### 2. Create the Database

Create a SQL Server database named:

```text
Student_Manager_DB
```

Use the database documentation included in the repository to create the required tables and relationships.

### 3. Configure the Connection

Update the database connection configuration in:

```text
Student_Manager_DataAsccess/clsDataAccessSeetings.cs
```

with the SQL Server instance available on your machine.

### 4. Run

Open:

```text
Student_Manager.slnx
```

in Visual Studio, build the solution, and run the application.

---

## Project Structure

```text
Student_Manager/
├── Login/
├── Main Screen/
├── Student/
├── Staff/
├── Programs/
├── Student_Manager_ Business Logic Layer/
├── Student_Manager_DataAsccess/
├── Documentation/
├── Icons/
├── Program.cs
├── App.config
├── Student_Manager.csproj
└── Student_Manager.slnx
```

---

## Project Status

**Learning Project — Functional, but not production-ready.**

The application has working core CRUD functionality and demonstrates practical experience with C#, WinForms, SQL Server, ADO.NET, relational database design, and layered architecture.

At the same time, the project has known security, architecture, testing, validation, configuration, and maintainability limitations.

Those limitations are documented intentionally because they represent the areas I will improve in future projects.

---

## Author

**Aseelcoding**

GitHub: https://github.com/Aseelcoding

Repository: https://github.com/Aseelcoding/Student_Manager

---

## License

No license has currently been specified for this repository.
