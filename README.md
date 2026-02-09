# Concurs de Dans

## Project Overview

**Concurs de Dans** is a visual application developed in C# designed to manage and track data for dance competitions. The application provides a structured way to organize participant information, manage existing data, and ensure efficient database administration.

The system allows for detailed record-keeping of dancers, including their personal details, contact information, the educational institutions they represent, and their competition achievements.

This project follows the technical requirements for the technology practice at CEITI, implementing a visual interface that interacts with a SQL Server database.

---

## Application Features

*
**Dancer Management**: Register new participants and exclude existing ones based on a unique code.


*
**Data Filtering & Search**: Display lists of participants by dance category or specific competition.


*
**Statistics**: Automatically determine the youngest and oldest participants, and calculate the average age of male dancers per category.


*
**Security**: Role-based access control with different permissions for Guests and Administrators.


*
**Reporting**: Export filtered lists of participants (e.g., female dancers under 12) to MS Excel (.csv) files.


*
**Data Privacy**: Contact information such as phone numbers and emails are partially masked in certain views to ensure data security.



---

## Project Structure

The project follows a modular architecture separating the database access layer, UI forms, and business logic.

```text
Concurs_de_dans/
│
├── Classes/
│   ├── Database Manipulation/
│   │   ├── DataAccess.cs       # Main database interaction (Dapper/SQL)
│   │   └── Helper.cs           # Connection string management
│   └── Database Tables/
│       └── Dancer.cs           # Object model for participant data
│
├── LogIn/
│   ├── LogInForm.cs            # Initial entry point for users
│   └── LogInCaAdministratorForm.cs
│
├── MenuStripForms/
│   ├── Categorii.cs            # Dance categories management
│   ├── DansatoriForm.cs        # Participant data viewer
│   └── TipuriDeDansForm.cs      # Dance styles viewer
│
├── Tasks/                      # Specialized functional modules
│   ├── InregistrareDansatorForm.cs
│   ├── ExcludereDansatorForm.cs
│   ├── OrdonareAscendentDupaVarstaForm.cs
│   ├── ExportaDansatoareAniForm.cs
│   └── VarstaMedieABarbatilorForm.cs
│
├── Program.cs                  # Application entry point
└── App.config                  # Configuration and connection strings

```



---

## Technologies Used

*
**Programming Language**: C#


*
**Framework**: .NET Framework with Windows Forms


*
**Database**: Microsoft SQL Server


*
**Data Access**: Dapper (Micro-ORM)


*
**Office Integration**: Microsoft Office Interop Excel for data exporting



---

## How to Run the Application

1.
**Database Setup**: Execute the `ConcursDeDans` SQL script to create the database schema and populate initial tables (Institutions, Categories, Styles).


2.
**Configuration**: Update the `App.config` file with your local SQL Server connection string.


3.
**Launch**: Run `Concurs de dans.exe` or start the project from Visual Studio.


4. **Login**:
* Use **Oaspete** (Guest) for read-only access.


* Use **Administrator** credentials to enable registration and deletion features.# Concurs de Dans

## Project Overview

**Concurs de Dans** is a visual application developed in C# designed to manage and track data for dance competitions. The application provides a structured way to organize participant information, manage existing data, and ensure efficient database administration.

The system allows for detailed record-keeping of dancers, including their personal details, contact information, the educational institutions they represent, and their competition achievements.

This project follows the technical requirements for the technology practice at CEITI, implementing a visual interface that interacts with a SQL Server database.

---

## Application Features

*
**Dancer Management**: Register new participants and exclude existing ones based on a unique code.


*
**Data Filtering & Search**: Display lists of participants by dance category or specific competition.


*
**Statistics**: Automatically determine the youngest and oldest participants, and calculate the average age of male dancers per category.


*
**Security**: Role-based access control with different permissions for Guests and Administrators.


*
**Reporting**: Export filtered lists of participants (e.g., female dancers under 12) to MS Excel (.csv) files.


*
**Data Privacy**: Contact information such as phone numbers and emails are partially masked in certain views to ensure data security.



---

## Project Structure

The project follows a modular architecture separating the database access layer, UI forms, and business logic.

```text
Concurs_de_dans/
│
├── Classes/
│   ├── Database Manipulation/
│   │   ├── DataAccess.cs       # Main database interaction (Dapper/SQL)
│   │   └── Helper.cs           # Connection string management
│   └── Database Tables/
│       └── Dancer.cs           # Object model for participant data
│
├── LogIn/
│   ├── LogInForm.cs            # Initial entry point for users
│   └── LogInCaAdministratorForm.cs
│
├── MenuStripForms/
│   ├── Categorii.cs            # Dance categories management
│   ├── DansatoriForm.cs        # Participant data viewer
│   └── TipuriDeDansForm.cs      # Dance styles viewer
│
├── Tasks/                      # Specialized functional modules
│   ├── InregistrareDansatorForm.cs
│   ├── ExcludereDansatorForm.cs
│   ├── OrdonareAscendentDupaVarstaForm.cs
│   ├── ExportaDansatoareAniForm.cs
│   └── VarstaMedieABarbatilorForm.cs
│
├── Program.cs                  # Application entry point
└── App.config                  # Configuration and connection strings

```



---

## Technologies Used

**Programming Language**: C#\
**Framework**: .NET Framework with Windows Forms\
**Database**: Microsoft SQL Server\
**Data Access**: Dapper (Micro-ORM)\
**Office Integration**: Microsoft Office Interop Excel for data exporting

---

## How to Run the Application

1. **Database Setup**: Execute the `ConcursDeDans` SQL script to create the database schema and populate initial tables (Institutions, Categories, Styles).

2. **Configuration**: Update the `App.config` file with your local SQL Server connection string.

3. **Launch**: Run `Concurs de dans.exe` or start the project from Visual Studio.

4. **Login**:
   * Use **Oaspete** (Guest) for read-only access.

   * Use **Administrator** credentials to enable registration and deletion features.