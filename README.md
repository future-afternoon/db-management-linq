# db-management-linq
This program is a simple console application that demonstrates the usage of Entity Framework Core in a .NET
Key Notes:
**Database Entities:**

Four entities are defined: Student, Faculty, Class, and Enrolled.
Each entity represents a table in the database and includes properties corresponding to columns.
Database Context:

SchoolDbContext is derived from DbContext and represents the database context.
It includes properties for each entity (e.g., Students, Faculties) as DbSet.
The OnConfiguring method sets up the database connection using Entity Framework Core.
Sample Data:

The Main method in Program.cs includes sample data for Students, Faculty, Classes, and Enrolled.
The SaveChanges method is called to persist the sample data to the database.
LINQ Queries:

LINQ queries are used to retrieve information from the database based on specified challenges.
Examples include finding classes with more than 100 students, students with no classes in a specific department, and more.
Primary Key Issue:

The error related to the primary key for the Class entity is addressed by adding the [Key] attribute to the primary key property (Cid).
Database Connection:

The connection string in the OnConfiguring method of SchoolDbContext specifies the database connection details.
Replace "YourSqlServerConnectionString" with the actual connection string.
