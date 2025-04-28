# School Management System 🎓

## About the Project

The **School Management System** is a web application designed using **ASP.NET Core MVC**. It provides a robust and secure platform for managing **students**, **teachers**, **courses**, **grades**, and **attendance** within a school environment.

This project is designed to streamline the school administration process, making it easier to manage student data, teacher data, courses, attendance, and grades. It also features role-based access control to ensure security and user-specific permissions.

## Features 🚀

- **🔐 Authentication System**:  
  Provides a secure login, registration, and password recovery via email for users.
  
- **✉️ Temporary Password**:  
  Upon registration, users receive a temporary password with random characters sent to their email.

- **👥 Role Management**:  
  Four user roles: **Admin**, **Staff**, **Teacher**, **Student**, and **Anonymous**. Each role has different access permissions.

- **🏫 Course and Subject Management**:  
  Admins and staff can perform **CRUD** operations for courses and subjects.

- **👨‍🏫 Teacher Management**:  
  Full **CRUD** operations for managing teachers, including the ability to assign teachers to specific subjects.

- **📝 Student and Grades Management**:  
  Admin and staff can manage students, grades, and attendance.

- **📊 Admin Dashboard**:  
  The dashboard provides alerts and system notifications to keep the admin updated with important messages from staff.

- **🖼️ Profile Pictures**:  
  Students are required to upload profile pictures, while other users have this option.

- **🌐 Public API**:  
  Provides an API endpoint to retrieve data of all students in a specific class.

- **❌ Custom Error Handling**:  
  Friendly error pages and comprehensive error management for CRUD operations.

- **🎨 Responsive UI**:  
  A custom, original front-end design that adapts to different screen sizes.

## User Roles and Permissions 🔑

| Feature                              | Admin | Staff | Teacher | Student | Anonymous |
|--------------------------------------|:-----:|:-----:|:-------:|:-------:|:---------:|
| Login/Logout                         | ✅    | ✅    | ✅      | ✅      | ❌        |
| Create Accounts                      | ✅    | ❌    | ❌      | ❌      | ❌        |
| CRUD Courses                         | ✅    | ✅    | ❌      | ❌      | ❌        |
| CRUD Subjects                        | ✅    | ✅    | ❌      | ❌      | ❌        |
| CRUD Teachers                        | ✅    | ✅    | ❌      | ❌      | ❌        |
| CRUD Students and Grades             | ✅    | ✅    | ❌      | ❌      | ❌        |
| View Courses and Subjects            | ✅    | ✅    | ✅      | ✅      | ✅        |
| View Grades and Status               | ❌    | ❌    | ❌      | ✅      | ❌        |
| Modify Profile                       | ✅    | ✅    | ✅      | ✅      | ❌        |
| Attendance Tracking and Management   | ✅    | ✅    | ✅      | ✅      | ❌        |

## Technologies Used 🛠️

- **Framework**: ASP.NET Core MVC
- **Database**: SQL Server with **Entity Framework Core**
- **Architecture**: **Repository Pattern**
- **Authentication**: Identity Framework with Role Management
- **Frontend**: Bootstrap, Syncfusion Controls
- **API**: RESTful Web API

## Visual Demonstration 🌟

### Home Page
The home page provides an overview of the school’s information and a simple navigation interface for users to access the system. It includes login links for students, teachers, staff, and admin users.

## Getting Started 🚀

To set up the project locally, follow these steps:

### Prerequisites

Ensure you have the following installed:
- [Visual Studio](https://visualstudio.microsoft.com/) (Community or higher)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [ASP.NET Core SDK](https://dotnet.microsoft.com/download)

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/school-management-system.git
