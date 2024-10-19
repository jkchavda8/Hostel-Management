# Hostel Management System

The **Hostel Management System** is a web application designed to efficiently manage student accommodations in a hostel. It simplifies tasks like managing student data, room allocations, leave requests, fee tracking, and provides a centralized admin interface for smooth hostel operations.

## Project Purpose

The purpose of the **Hostel Management System** is to create a digital platform where hostel administrators can easily manage key aspects of hostel operations, such as:
- **Student Enrollment**: Managing student details including room allocation.
- **Leave Requests**: Students can request leaves which admins can approve or deny.
- **Fee Tracking**: Admins can monitor and update students' fee payment statuses.
- **Room Management**: Allocate and update room assignments for students.
- **Admin Dashboard**: Provide hostel administrators with a centralized dashboard to control all system operations.

## Features

1. **Student Management**
   - Add, update, and delete student information.
   - Assign rooms to students.
  
2. **Room Allocation**
   - Admin can manage the allocation of rooms to students.
  
3. **Leave Requests**
   - Students can request leave, and admins can approve/deny these requests.
  
4. **Fee Management**
   - Track and manage students' fee payments.
  
5. **Admin Panel**
   - Admins can control all features, view student information, manage rooms, and track leave requests.

6. **Authentication**
   - Role-based authentication for admin and students.

## Technologies Used

- **Frontend**: HTML, CSS, Bootstrap, Razor Views (ASP.NET MVC)
- **Backend**: ASP.NET Core MVC (C#)
- **Database**: SQL Server (or any other supported relational database)
- **Authentication**: ASP.NET Identity for secure login

## Getting Started

### Prerequisites

Before running the project, make sure you have the following installed:

- [.NET 6.0 SDK or higher](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Any preferred IDE like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Setting Up the Project

1. **Clone the Repository**
  First, clone the project repository to your local machine using the command:
   ```bash
   git clone https://github.com/yourusername/HostelManagement.git
   
2. **Configure the Database**
  Open the project in your preferred IDE.
   In the appsettings.json file, configure the connection string for your database:
      "ConnectionStrings": {
        "DefaultConnection": "Server=your_server_name;Database=HostelManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true"
      }
   
4. **Run Database Migrations**
    After configuring the database connection string, open the terminal in your IDE and run the following commands to create the database and apply migrations:
     dotnet ef database update
   
6. **Run the Application**
  Now, you can run the application using the command:
    dotnet run
  
### Running the Application

1. **Admin Login**
  Admins can log in using predefined credentials or by registering as admins via the registration page.

3. **Student Login**
   Students need to register to request leaves and view their profiles.
   
5. **Admin Dashboard**
  - Once logged in, the admin can:
      View and manage student data.
      Approve or reject leave requests.
      View and manage room allocations.
      Track and update fee information.
      Leave Requests

4. **Students can submit leave requests that require approval from the admin.**
    Fee Management

5. **Admins can view and update the fee payment status for each student.**
    Project Structure
   
## The project follows the ASP.NET MVC pattern:

**Models** : Contains the data structure of entities like Student, LeaveRequest, Room, etc.
**Views** : Contains the Razor pages (HTML) to display the user interface.
**Controllers**: Handles the business logic and routes requests between the model and views.

## Future Enhancements
**Notifications**: Add notifications for students regarding leave request status.
**Reports**: Generate reports of student data and room assignments for hostel administrators.
**Mobile Integration**: Create a mobile-friendly version or mobile app for easier access.
