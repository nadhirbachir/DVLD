# DVLD - Driver and Vehicle Licensing Department Management System

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2016+-red.svg)](https://www.microsoft.com/en-us/sql-server)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop%20App-brightgreen.svg)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

> A comprehensive Driver and Vehicle Licensing Department management system built with C# Windows Forms and SQL Server. Manages license applications, driver records, testing procedures, and administrative operations using 3-tier architecture.

## 📸 Screenshots

![Login page screenshot](resources/login_page.png)
*Login page*

![Main application dashboard](resources/main_dashboard_screenshot.png)
*Main application dashboard*

![management pages style look](resources/management_pages_style.png)
*License management interfaces*

## ✨ Features

- 👥 **People Management** - Complete person registration and information management
- 🚗 **Driver Management** - Driver profiles, history, and status tracking
- 📋 **Application Processing** - Handle various license application types
- 🧪 **Testing System** - Vision, written, and practical test management
- 📜 **License Management** - Issue, renew, replace, and manage licenses
- 🔒 **License Control** - Detain and release license functionality
- 🌍 **International Licenses** - International driving permit management
- 👤 **User Management** - Role-based access control and authentication

## 🏗️ Architecture

**3-Tier Architecture:**
- **Presentation Layer** - Windows Forms UI
- **Business Logic Layer** - Business rules and validation
- **Data Access Layer** - Database operations with ADO.NET

## 🛠️ Technology Stack

- **Framework:** .NET Framework 4.7.2+
- **Language:** C#
- **Database:** SQL Server 2016+
- **Data Access:** ADO.NET
- **UI:** Windows Forms
- **Architecture:** 3-Tier Pattern

## 🚀 Quick Start

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- SQL Server 2016 or later (Express edition supported)
- Windows 10 or later

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/nadhirbachir/DVLD.git
   cd DVLD
   ```

2. **Set up the database**
   - Create a new SQL Server database named `DVLD_DB`
   - Restore the database from `database backup` folder `DVLD.bak` file
   - Update the connection string in `DVLD_DataAccess/clsDataAccessSettings.cs`

3. **Build and run**
   - Open `DVLD.sln` in Visual Studio
   - Build the solution (Ctrl+Shift+B)
   - Set `DVLD` as startup project
   - Run the application (F5)

### Default Login
- **Username:** user5
- **Password:** 1234

## 📁 Project Structure

```
DVLD/
├── DVLD/                           # Presentation Layer (Windows Forms)
│   ├── Ctrl/                      # Custom User Controls
│   ├── ManageApplications/        # Application Management
│   ├── ManageDrivers/             # Driver Management
│   ├── ManageLicenses/            # License Management
│   ├── ManageTests/               # Testing System
│   └── PeopleManagement/          # People Management
├── DVLD_Business/                 # Business Logic Layer
└── DVLD_DataAccess/              # Data Access Layer
```

## 🗄️ Database Schema

### Main Tables
- **People** - Personal information
- **Drivers** - Driver records
- **Applications** - License applications
- **Tests** - Test records and results
- **Licenses** - Issued licenses
- **Users** - System users

## 📊 System Workflows

### License Application Process
```
Person Registration → Application Submission → Tests (Vision/Written/Practical) → License Issuance
```

### License Management
```
License Issued → Renewal/Replacement → Status Management → History Tracking
```

## 📖 Documentation

- [Complete Documentation](DVLD_project_documentation.md)

- 
## 🧪 Testing

The project includes comprehensive testing for:
- Business logic validation
- Data access operations
- User interface functionality
- Integration testing

## 📝 License
This project is licensed under the MIT License


⭐ **Star this repository if you find it helpful!**

📧 **Contact:** nadirforme@gmail.com
