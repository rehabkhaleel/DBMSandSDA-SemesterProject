# Insurance Management System

## Overview

The Insurance Management System (IMS) is a web application built to handle the processes involved in managing insurance policies, user registrations, payment processing, claim handling, and administrative tasks. The system is designed using **ASP.NET** with **C#** and **SQL Server** for database management. This project aims to streamline the workflow for clients, agents, and administrators within the insurance domain.

## Features

1. **Sign Up / Login**: Users can register and sign in to select insurance policies.
2. **Policy Management**: Users can choose a policy, which is initially inactive. Once approved by an agent, the policy status becomes active.
3. **Payment Processing**: Users can make payments for their insurance policies.
4. **Claim Handling**: Users can initiate claims for their policies.
5. **Admin Dashboard**: Admins can access user details for monitoring and administrative purposes.

## Project Scope

- Development of a **web-based insurance management system** for managing user registrations, policy selections, approvals, payments, and claims.
- Integration of the **ASP.NET C#** framework with **SQL Server** for efficient data handling.

## Technologies Used

- **Frontend**: ASP.NET MVC
- **Backend**: C# (ASP.NET Core)
- **Database**: SQL Server
- **IDE**: Visual Studio

## Setup Instructions

### Prerequisites
Before you can run the project, ensure you have the following installed:
- **Visual Studio** (preferably the latest version)
- **SQL Server** (or use SQL Server Express for local development)
- **.NET SDK** (version used: .NET 5 or higher)

### Clone the Repository

```bash
git clone <repository_url>
cd <project_directory>
```

### Set Up the Database
1. Create a new database in **SQL Server** called `InsuranceDB`.
2. Use the SQL scripts provided in the `database/` folder to create necessary tables and stored procedures.
3. Update the **connection string** in `appsettings.json` to point to your local SQL Server instance.

### Running the Project
1. Open the project in **Visual Studio**.
2. Build the solution to restore necessary packages and dependencies.
3. Run the project using **IIS Express** or any web server of your choice.

```bash
dotnet build
dotnet run
```

### Access the Application
Once the application is running, you can access it through:
```
http://localhost:<port_number>
```

## Project Functionality

1. **User Registration**:
   - Users can sign up by providing their details and selecting an insurance policy.
   
2. **Policy Approval**:
   - After sign up, the policy is initially inactive. Agents must approve the policy, changing its status to active.

3. **Payment System**:
   - Active users can make payments for their policies through a simple payment gateway.
   
4. **Claim Processing**:
   - Users can file claims related to their policies for review by the agent.

5. **Admin Dashboard**:
   - Admins have access to user details and can oversee policy management and claim statuses.


## Assumptions and Constraints

- **Assumptions**:
  - Users have basic knowledge of insurance processes.
  - Agents are responsible for policy approval.
  - Admins manage system operations.

- **Constraints**:
  - Limited resources may impact project scope and timeline.
