# ASP.NET MVC Case Study Project

This is a sample **ASP.NET MVC Web Application** that demonstrates key concepts like authentication, role-based access (Admin/User), and structured page navigation using Razor Views (`.cshtml`). This project was built as part of a .NET case study.

## Features

- ✅ User Login and Signup
- ✅ Admin Login with separate dashboard
- ✅ Static informational pages (About, Contact)
- ✅ Landing page (Index)
- ✅ Welcome page after login
- 🔐 Role-based redirection (Admin vs User)

## Project Structure
ASP_Dot_Net_Project/ │ ├── Controllers/ │ └── HomeController.cs │ ├── Views/ │ └── Home/ │ ├── Index.cshtml │ ├── Login.cshtml │ ├── Signup.cshtml │ ├── Adminlogin.cshtml │ ├── Adminpage.cshtml │ ├── About.cshtml │ ├── Contact.cshtml │ └── Welcomepage.cshtml │ └── Models/ └── User.cs 


## Tech Stack

- ASP.NET MVC (Razor Views)
- ADO.NET / Entity Framework (as applicable)
- SQL Server (for user authentication and storage)
- HTML, CSS, Bootstrap

## How to Run This Project (Locally)

> You **do not need Visual Studio** to run this if you're using .NET Core.

### 1. Prerequisites:
- [.NET SDK](https://dotnet.microsoft.com/download) installed (check with `dotnet --version`)
- Git installed

### 2. Clone the Repository
```bash
git clone https://github.com/HarithaNair8/ASP_Dot_Net_Project.git
cd ASP_Dot_Net_Project/Casestudyb

3. Run the Project
dotnet restore
dotnet run
Open a browser and go to:
http://localhost:5000/Home/Login
or
http://localhost:5000/Home/Index

Deployment
You can deploy this app using:
•	Azure App Service
•	Render.com
•	IIS or Windows Server (for ASP.NET Framework apps)

Author
 Haritha Nair
This project was created as part of my learning and experience in ASP.NET MVC and Web Development.
![image](https://github.com/user-attachments/assets/9dc2cc14-bf3a-49dc-9da2-4ffe872bd2c8)
