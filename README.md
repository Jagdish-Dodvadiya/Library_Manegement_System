## 📚 Library Management System

The Library Management System is a **web-based application** built using **ASP.NET Core MVC** to manage book records efficiently.
It implements the **MVC (Model-View-Controller)** architecture along with **Entity Framework Core** for database operations, ensuring clean separation between UI, business logic, and data access.

## 🚀 Features
 - Add New Book
 - View All Books
 - Update Book Details
 - View Book Details
 - Delete Book
 - Form Validation using ModelState
   
## 🛠️ Tech Stack

 - **Framework:** ASP.NET Core MVC
 - **Language:** C#
 - **Database:** SQL Server
 - **ORM:** Entity Framework Core (Code First)
 - **Architecture:** MVC Pattern
 - **IDE:** Visual Studio 2022
   
## 📂 Project Structure

```text
    LibraryManagementSystem
    │-- Controllers
    │   └── BookController.cs
    │
    │-- Models
    │   └── Book.cs
    │
    │-- Data
    │   └── ApplicationDbContext.cs
    │
    │-- Views
    │   └── Book
    │       │-- Index.cshtml
    │       │-- Create.cshtml
    │       │-- Edit.cshtml
    │       │-- Details.cshtml
    │       └── Delete.cshtml
    │
    │-- wwwroot
    │-- appsettings.json
    └── Program.cs
```

## 🧰 Setup Instructions

 - Clone the repository:
  ```git clone https://github.com/your-username/library-management-system.git```
 - cd library-management-system
  ```text
     Configure database in appsettings.json:
    "ConnectionStrings": {
      "DefaultConnection": "Server=.;Database=LibraryDB;Trusted_Connection=True;"
    }
```
 - Apply migrations:
 - Update-Database
 - Run the project:
 - dotnet run
 - Open browser:
```text
https://localhost:xxxx
```

## 📋 Functional Flow
1. Add Book
2. Display Book List
3. Edit Book
4. View Details
5. Delete Book

## 📌 Key Highlights
 - Clean MVC architecture implementation
 - Uses Entity Framework Core (Code First)
 - Implements full CRUD operations
 - Beginner-friendly and portfolio-ready project
 - Follows industry-standard structure
   
## 🎯 Future Enhancements
 - 🔐 Authentication & Authorization (Login/Register)
 - 📊 Dashboard with analytics
 - 📅 Book issue/return system
 - 🔍 Search & filtering functionality
 - 🌐 REST API integration

## 👤 Author

 - **LinkedIn:** https://linkedin.com/in/jagdish-dodvadiya
 - **GitHub:** https://github.com/Jagdish-Dodvadiya
 - **Email:** jagdishdodvadiya545@gmail.com

## 📃 License

This project is open-source and available under the MIT License.
See the LICENSE file for details.

## ⚡ Built For

Learning, practicing, and building real-world ASP.NET Core MVC CRUD applications using Entity Framework Core and SQL Server.
