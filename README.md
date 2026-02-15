# Service Request Management API

An enterprise-style backend API built with ASP.NET Core and Entity Framework Core to manage service requests with role-based authentication and relational data modeling.

---

## Overview

This project simulates a government-style service request portal where users can:

- Register and authenticate using JWT
- Submit service requests
- Track request status
- View paginated results
- Enforce role-based authorization (Admin/User)
- Maintain status history tracking

The application follows clean layered architecture principles and demonstrates enterprise backend development practices.

---

## Tech Stack

- ASP.NET Core (.NET 8)
- C#
- Entity Framework Core
- SQL Server
- RESTful API Design
- JWT Authentication
- Repository Pattern
- Dependency Injection
- Global Exception Middleware
- Swagger / OpenAPI

---

## Architecture

The project follows a layered architecture:

Controllers → Services → Repositories → DbContext → Database

### Key Design Decisions

- Separation of concerns via repository pattern
- Async database operations
- Pagination support
- Data validation using Data Annotations
- Foreign key relationships with navigation properties
- Role-based access control using JWT claims
- Centralized exception handling middleware

---

## Database Design

### Tables

- Users
- ServiceRequests
- StatusHistories

### Relationships

- One User → Many ServiceRequests
- One ServiceRequest → Many StatusHistories

Migrations are used for schema management.

---

## Authentication

- JWT-based authentication
- Role claims embedded in token
- Protected endpoints using `[Authorize]`
- Role-based access using `[Authorize(Roles = "Admin")]`

---

## API Endpoints

### Authentication
- POST /api/auth/register
- POST /api/auth/login

### Service Requests
- GET /api/servicerequests
- GET /api/servicerequests/{id}
- POST /api/servicerequests
- PUT /api/servicerequests/{id}
- DELETE /api/servicerequests/{id}

---

## ▶ Running the Project

1. Clone the repository
2. Update connection string in `appsettings.json`
3. Run migrations: dotnet ef database update
4. Start the server: dotnet run
5. Navigate to: http://localhost:xxxx/swagger

---

## Learning Objectives

This project was built to strengthen backend development skills in:

- C# and ASP.NET Core
- Relational database modeling
- Entity Framework Core
- Authentication & Authorization
- Enterprise API design patterns