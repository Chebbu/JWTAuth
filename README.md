# JWT Authentication & Authorization in .NET 10

This repository contains a **complete implementation of JWT Authentication and Authorization in ASP.NET Core (.NET 10)**.

The project is built step by step as part of a YouTube tutorial series and covers **real‑world authentication scenarios**, including **roles and protected endpoints**.

---

## Features

* User Registration & Login
* Secure Password Hashing
* JWT Access Token Generation
* JWT Bearer Authentication
* Role-Based Authorization (Admin / User)
* Protected API Endpoints
* Entity Framework Core with SQL Server
* Clean Architecture (Controllers, Services, DTOs, Entities)

---

## Tech Stack

* .NET 10
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* JWT (JSON Web Tokens)
* PasswordHasher
* OpenAPI / Scalar

---

##  Project Structure

```
├── Controllers
│   └── AuthController.cs
├── Data
│   └── UserDbContext.cs
├── DTO
│   └── UserDto.cs
├── Entities
│   └── User.cs
├── Services
│   ├── IAuthService.cs
│   └── AuthService.cs
├── Program.cs
├── appsettings.json
```

---

## ⚙️ Configuration

###  appsettings.json

Configure your **JWT settings** and **database connection string**:

```json
"Token": {
  "Key": "your-super-secret-key",
  "Issuer": "your-issuer",
  "Audience": "your-audience"
},
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=JwtAuthDb;Trusted_Connection=True;"
}
```

---

##  Database Setup

1. Install required packages:

   * EntityFrameworkCore
   * EntityFrameworkCore.Tools
   * EntityFrameworkCore.SqlServer

2. Run migrations:

```powershell
Add-Migration Initial
Update-Database
```

---

##  Authentication Flow

1. **Register User** → `/api/auth/register`
2. **Login User** → `/api/auth/login`
3. **Receive JWT Token**
4. **Use Token** in Authorization Header:

```
Authorization: Bearer <your-token>
```

---

##  Role-Based Authorization

* Users have a `Role` stored in the database
* Role is added as a **JWT claim**
* Endpoints can be protected like this:

```csharp
[Authorize(Roles = "Admin")]
```

---

##  Testing

You can test all endpoints using:

* **Scalar UI**
* **Swagger / OpenAPI**
* **Postman**

---

## YouTube Tutorial Series

This project is part of a full tutorial series:

* **Part 1:** JWT Authentication in .NET 10
* **Part 2:** Role-Based Authorization

📺 YouTube Channel: **Tawfik Chebbi**

---

##  Notes

* This project focuses on **learning and clarity**
* Refresh Tokens and advanced security can be added in later parts

---

## ⭐ Support

If this project helped you:

* ⭐ Star the repository
* 👍 Like the YouTube video
* 🔔 Subscribe for more .NET backend tutorials

---

