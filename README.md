# Service Request Management System

A full-stack web application built with **ASP.NET Core, Angular, and SQL Server**, demonstrating real-world enterprise development and frontend-backend integration.

---

## 🔧 Tech Stack
- **Backend:** ASP.NET Core (.NET 8), C#, Entity Framework Core, SQL Server
- **Frontend:** Angular (Standalone Components), TypeScript, HTML/CSS
- **DevOps:** Azure DevOps YAML (CI-ready)

---

## 🚀 Features
- RESTful API with pagination
- DTO-based request and response models
- Angular frontend consuming backend APIs
- Client- and server-side validation
- CORS configuration for browser clients
- Relational database with enforced foreign keys
- Swagger for API testing and verification

---

## 🏗 Architecture Highlights
- Clean separation between API contracts (DTOs) and EF Core entities
- Proper handling of JSON serialization cycles
- End-to-end data flow:
  **Angular → API → Database → API → Angular**

---

## ▶ Run Locally

**Backend**
dotnet restore
dotnet ef database update
dotnet run

**Frontend**
npm install
ng serve

---
## What This Project Demonstrates

- Full-stack development with .NET and Angular
- Real-world debugging (CORS, validation, serialization, FK constraints)
- Enterprise-style API design
- SQL relational data modeling
- CI-ready project structure