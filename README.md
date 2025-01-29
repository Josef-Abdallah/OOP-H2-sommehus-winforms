# OOP H2 Sommerhus WinForms

This project is a WinForms application for managing summer houses, owners, and reservations. It includes functionalities to create, read, update, and delete records in a SQL Server database.

## Project Structure

- **Sommerhus.cs**: Main form for managing summer houses.
- **sommerhusejere.cs**: Form for managing summer house owners.
- **startside.cs**: Main menu form to navigate between different functionalities.
- **databaseSetup.cs**: Class responsible for setting up the database and loading data into DataGridViews.

## Database

The application connects to a SQL Server database named `Sommerhus-DB`. It ensures the database and required tables are created if they do not exist.

### Tables

- **sommerhus**: Stores information about summer houses.
- **sommerhusejere**: Stores information about summer house owners.
- **resevartion**: Stores reservation details.

## Configuration

The connection strings for the database are defined in the `databaseSetup` class and the `Sommerhus` and `sommerhusejere` forms.

## How to Run

1. Open the solution in Visual Studio.
2. Build the solution to restore NuGet packages and compile the project.
3. Run the application.

## Features

- **Create, Read, Update, Delete (CRUD) Operations**: Manage summer houses, owners, and reservations.
- **Data Validation**: Ensures data integrity before performing database operations.
- **User Interface**: Intuitive WinForms interface for easy navigation and data management.

## Dependencies

- .NET Framework 4.8
- SQL Server (LocalDB or full SQL Server instance)

