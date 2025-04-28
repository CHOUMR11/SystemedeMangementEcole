School Management System 🎓
About the Project
The School Management System is a web application developed using ASP.NET Core MVC. It provides an efficient and secure platform for managing students, teachers, courses, grades, and attendance within a school environment.

Features 🚀
🔐 Authentication System: Login, logout, registration, and password recovery via email.
✉️ Temporary Password: Upon registration, a temporary password with random characters is sent to the user's email.
👥 Role Management: Four user roles—Admin, Staff, Student, and Anonymous.
🏫 Course and Subject Management: Full CRUD operations for courses and subjects.
👨‍🏫 Teacher Management: Complete CRUD operations for managing teachers.
📝 Student and Grades Management: Manage students, classes, grades, and attendance.
📊 Admin Dashboard: Alerts and system notifications from staff members.
🖼️ Profile Pictures: Required for students and optional for other users.
🌐 Public API: Provides data of all students in a specific class.
❌ Custom Error Handling: Friendly error pages and complete CRUD error management.
🎨 Responsive UI: Custom and original front-end design.
User Roles and Permissions 🔑
Feature	Admin	Staff	Teacher	Student	Anonymous
Login/Logout	✅	✅	✅	✅	❌
Create Accounts	✅	❌	❌	❌	❌
CRUD Courses	✅	✅	❌	❌	❌
CRUD Subjects	✅	✅	❌	❌	❌
CRUD Teachers	✅	✅	❌	❌	❌
CRUD Students and Grades	✅	✅	❌	❌	❌
View Courses and Subjects	✅	✅	✅	✅	✅
View Grades and Status	❌	❌	❌	✅	❌
Modify Profile	✅	✅	✅	✅	❌
Attendance Tracking and Management	✅	✅	✅	✅	❌
Technologies Used 🛠️
Framework: ASP.NET Core MVC
Database: SQL Server with Entity Framework Core
Architecture: Repository Pattern
Authentication: Identity Framework with Role Management
Frontend: Bootstrap, Syncfusion Controls
API: RESTful Web API
Visual Demonstration 🌟
🏠 Home Page
