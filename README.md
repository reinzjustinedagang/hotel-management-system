# 🏨 Hotel Management System

A desktop-based **Hotel Management System (HMS)** developed using **C# Windows Forms** and **MySQL**. The system is designed to help hotel staff manage rooms, guests, reservations, check-ins, check-outs, payments, billing, and reports through a centralized application.

The project follows a **layered architecture** to keep the application organized, maintainable, and easier to extend.

---

## 📌 Project Overview

The Hotel Management System provides a centralized platform for managing the day-to-day operations of a hotel.

Instead of maintaining guest information, room availability, reservations, and payments separately, the system brings these processes together into one application.

### Main Objectives

* Manage hotel rooms and room types
* Register and manage guest information
* Create and manage reservations
* Support multiple guests per reservation
* Process guest check-ins and check-outs
* Calculate billing and payments
* Track room availability and status
* Generate hotel reports
* Provide an organized and maintainable application structure

---

## ✨ Features

### 🔐 Authentication

* User login
* User account management
* Role-based access support

### 🛏️ Room Management

* Add new rooms
* Edit room information
* View room details
* Manage room types
* Manage room floors
* Update room status
* Search rooms
* Pagination for room listings

**Room Statuses:**

* Available
* Reserved
* Occupied
* Maintenance

### 👤 Guest Management

* Add guests
* Edit guest information
* View guest details
* Search guests
* Pagination
* Guest validation
* Store guest contact and personal information

Guest information includes:

* First Name
* Last Name
* Email
* Phone
* Address
* Nationality

### 📅 Reservation Management

* Create reservations
* Select rooms
* Assign guests to reservations
* Support multiple guests per reservation
* Manage reservation status
* Search and view reservations

The system uses a `ReservationGuests` relationship table to allow multiple guests to be associated with a single reservation.

### 🛎️ Check-In

* Process guest check-ins
* Verify reservation information
* Assign guests to rooms
* Update room status to **Occupied**

### 🚪 Check-Out

* Process guest check-outs
* Calculate charges
* Record payments
* Update room status to **Available**

### 💳 Billing & Payments

* Calculate room charges
* Record payments
* Track payment status
* Generate billing information

### 📊 Reports

* Room reports
* Guest reports
* Reservation reports
* Payment reports
* Occupancy-related information

---

## 🏗️ Project Architecture

The project uses a **Layered Architecture** to separate responsibilities between different parts of the application.

```text
HotelManagementSystem
│
├── Forms
│   ├── LoginForm.cs
│   ├── Dashboard.cs
│   ├── AddEditRoom.cs
│   └── ...
│
├── UserControls
│   ├── Rooms.cs
│   ├── Guests.cs
│   └── ...
│
├── Models
│   ├── Guest.cs
│   ├── Room.cs
│   ├── Reservation.cs
│   ├── Payment.cs
│   └── Employee.cs
│
├── Repositories
│   ├── RoomRepository.cs
│   ├── GuestRepository.cs
│   ├── ReservationRepository.cs
│   └── ...
│
├── Services
│   ├── RoomService.cs
│   ├── GuestService.cs
│   ├── ReservationService.cs
│   └── ...
│
├── Database
│   └── DBConnection.cs
│
└── Program.cs
```

### Architecture Flow

```text
Windows Forms UI
       │
       ▼
    Services
       │
       ▼
  Repositories
       │
       ▼
     MySQL
```

### Responsibilities

**UI / Forms**

* Displays the application interface
* Handles user interaction
* Displays validation messages
* Sends requests to services

**Services**

* Contains application/business logic
* Performs validation
* Coordinates repository operations
* Keeps business rules away from the UI

**Repositories**

* Handles database operations
* Executes SQL queries
* Maps database records to models

**Models**

* Represents application entities
* Contains data used throughout the application

**Database**

* Provides database connection functionality

---

## 🛠️ Technologies Used

| Technology          | Purpose                          |
| ------------------- | -------------------------------- |
| C#                  | Application programming language |
| Windows Forms       | Desktop user interface           |
| .NET                | Application framework            |
| MySQL               | Relational database              |
| MySQL Connector/NET | MySQL database connectivity      |
| Visual Studio       | Development environment          |
| Git                 | Version control                  |
| GitHub              | Source code hosting              |

---

## 🗄️ Database

The system uses **MySQL** as its database management system.

### Main Tables

```text
users
employees
roomtypes
rooms
guests
reservations
reservationguests
payments
```

### Example Relationship

```text
Reservations
     │
     │ 1
     │
     ▼
ReservationGuests
     │
     │ *
     ▼
   Guests
```

This allows a reservation to contain multiple guests.

For example:

```text
Reservation #1001
│
├── Guest: Juan Dela Cruz
├── Guest: Maria Dela Cruz
└── Guest: Pedro Dela Cruz
```

---

## 🔗 ReservationGuests

The `ReservationGuests` table acts as a junction table between reservations and guests.

```text
ReservationGuests
-------------------------
ReservationGuestID  PK
ReservationID       FK
GuestID             FK
GuestType
```

This structure allows the system to support a **many-to-many relationship** between reservations and guests.

### Guest Types

Examples:

```text
Primary
Adult
Child
Additional Guest
```

---

## 📋 Requirements

Before running the project, make sure you have:

* Windows
* Visual Studio
* .NET SDK / .NET Runtime compatible with the project
* MySQL Server
* MySQL Workbench or another MySQL client
* MySQL Connector/NET

---

## ⚙️ Installation

### 1. Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/HotelManagementSystem.git
```

Navigate to the project:

```bash
cd HotelManagementSystem
```

### 2. Create the Database

Create a MySQL database:

```sql
CREATE DATABASE hotel_management;
```

Then import the project's database SQL script if provided.

### 3. Configure the Database Connection

Update the connection settings in the project's database configuration.

Example:

```csharp
Server=localhost;
Database=hotel_management;
Uid=root;
Pwd=your_password;
```

> Do not commit real database passwords or other credentials to GitHub.

### 4. Restore Dependencies

Open the project in Visual Studio and restore the required NuGet packages.

### 5. Build the Project

Build the solution:

```text
Build → Build Solution
```

### 6. Run the Application

Press:

```text
F5
```

or select:

```text
Debug → Start Debugging
```

---

## 🖥️ Application Modules

The planned application navigation includes:

```text
Dashboard
│
├── Rooms
├── Guests
├── Reservations
├── Check-In
├── Check-Out
├── Billing
├── Payments
├── Reports
└── Users
```

---

## 🔍 Search & Pagination

The application implements search and pagination for larger datasets.

Example:

```text
Search: Juan

Showing 1–10 of 35 guests

[ Previous ]  Page 1 of 4  [ Next ]
```

This prevents the application from loading unnecessarily large datasets into the UI at once.

---

## 🔒 Validation

The application performs validation before saving information.

For example, guest registration validates required fields such as:

* First Name
* Last Name
* Email
* Phone
* Address
* Nationality

Example:

```csharp
if (string.IsNullOrWhiteSpace(guest.FirstName))
{
    return false;
}
```

This helps prevent incomplete records from being stored in the database.

---

## 🚀 Future Improvements

Possible future improvements include:

* Dashboard statistics
* Advanced reporting
* Printable invoices
* PDF report generation
* Receipt printing
* Role-based permissions
* User activity logs
* Advanced reservation calendar
* Automatic room availability checking
* Payment history
* Database backup and restore
* Improved error logging
* Email notifications
* SMS notifications

---

## 📸 Screenshots

Screenshots can be added here as the application UI is completed.

Example:

```text
screenshots/
├── login.png
├── dashboard.png
├── rooms.png
├── guests.png
├── reservations.png
├── checkin.png
├── checkout.png
└── billing.png
```

Then display them in the README:

```markdown
![Dashboard](screenshots/dashboard.png)
```

---

## 🎯 Learning Goals

This project is also intended as a learning project for developing practical skills in:

* C#
* Object-Oriented Programming
* Windows Forms development
* SQL and database design
* MySQL
* Repository Pattern
* Service Layer
* Layered Architecture
* CRUD operations
* Asynchronous programming
* Data validation
* Pagination
* Git and GitHub

---

## 🤝 Contributing

This project is primarily developed as a personal learning and portfolio project.

Suggestions, improvements, and constructive feedback are welcome.

If you would like to contribute:

1. Fork the repository
2. Create a feature branch

```bash
git checkout -b feature/new-feature
```

3. Commit your changes

```bash
git commit -m "Add new feature"
```

4. Push the branch

```bash
git push origin feature/new-feature
```

5. Open a Pull Request

---

## 📄 License

This project is intended for educational and portfolio purposes.

If a specific open-source license is added to the repository, this section should be updated accordingly.

---

## 👨‍💻 Author

**Reinz Justine Dagang**

BS Information Technology

GitHub: `reinzjustinedagang`

---

⭐ If you find this project useful or interesting, consider giving the repository a star!
