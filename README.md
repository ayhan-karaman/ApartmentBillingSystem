# 🏢 ApartmentBillingSystem

ApartmentBillingSystem is a modular and layered web application for managing apartment dues and utility bills (electricity, water, gas) in a residential site. Built using **ASP.NET Core 8 (MVC)**, it provides an interface for administrators and residents to manage billing, payments, and messaging.

---

## 🚀 Technologies Used

- **.NET 8 MVC** (Web Layer)
- **Entity Framework Core** (Data Access)
- **MS SQL Server** (Main Relational Database)
- **MongoDB** (For payment microservice)
- **ASP.NET Core Web API** (Payment service)
- **Razor Views** (Manually created)
- **Repository & Service Pattern**
- **Layered Architecture** (Domain, Application, Infrastructure, Web)

---

## 👥 User Roles

### 🔹 Administrator
- Manage apartment and user information
- Assign monthly dues and utility bills (individually or in bulk)
- View incoming payments
- View user messages
- List and manage all residents and apartment data
- Generate monthly debt-credit summary

### 🔹 Resident
- View assigned dues and bills
- Pay via credit card (external service)
- View apartment details
- Send messages to the administrator

---

## 📂 Project Structure
```bash
ApartmentBillingSystem/
└───    ApartmentBillingSystem.Domain/         # Entities and enums
    ├── ApartmentBillingSystem.Application/    # Interfaces and business logic (services)
    ├── ApartmentBillingSystem.Infrastructure/ # EF Core and data access (repositories)
    ├── ApartmentBillingSystem.Web/            # ASP.NET MVC UI (Controllers + Views)
    └── ApartmentBillingSystem.PaymentService/ # Web API using MongoDB (Credit card payments)
```
---

## 📌 Setup Instructions

### 🖥 Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server instance
- MongoDB (for payment microservice)

### ⚙️ Running the Web Project

```bash
    cd ApartmentBillingSystem.Web
    dotnet run
```
