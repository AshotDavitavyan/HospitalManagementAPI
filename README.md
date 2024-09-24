# Hospital Management API

This project is an **ASP.NET Core Web API** for managing hospital data. It provides endpoints for managing patients, doctors, regions, specializations, and cabinets, with full CRUD operations.

## Table of Contents

- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Installation and Setup](#installation-and-setup)
- [Running the Application](#running-the-application)
- [API Endpoints](#api-endpoints)
- [Service Layer](#service-layer)
- [Unit of Work Pattern](#unit-of-work-pattern)
- [DTOs (Data Transfer Objects)](#dtos-data-transfer-objects)
- [Swagger Integration](#swagger-integration)

## Technologies Used

- **ASP.NET Core 6**
- **Entity Framework Core**
- **MS SQL Server**
- **Swagger/OpenAPI** for API documentation
- **AutoMapper** for object mapping between models and DTOs
- **Dependency Injection** for managing services and repositories

## Installation and Setup

### Prerequisites

Before you begin, ensure you have the following tools installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Entity Framework Core CLI](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
- [Postman](https://www.postman.com/downloads/) (optional for testing APIs)
  
### Setup

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-repo/hospital-management-api.git
   cd hospital-management-api
   
2. **Configure Database Connection**

   Open the `appsettings.json` file in the root of your API project. Update the connection string to match your local MS SQL Server setup. It should look like this:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=HospitalManagement;Trusted_Connection=True;"
     }
   }

3. **Build the project:**

    ```bash
    dotnet build
    
### Running the Application

 **Run the API:**

  ```bash
  dotnet run --project HospitalManagementAPI
  ```
## API Endpoints

The following endpoints are provided by this API:

### Patients

- **GET** `/patients` - Get all patients
- **GET** `/patients/{id}` - Get a specific patient by ID
- **POST** `/patients` - Add a new patient
- **PUT** `/patients/{id}` - Update a patient by ID
- **DELETE** `/patients/{id}` - Delete a patient by ID

### Doctors

- **GET** `/doctors` - Get all doctors
- **GET** `/doctors/{id}` - Get a specific doctor by ID
- **POST** `/doctors` - Add a new doctor
- **PUT** `/doctors/{id}` - Update a doctor by ID
- **DELETE** `/doctors/{id}` - Delete a doctor by ID

## Service Layer

The service layer is responsible for handling business logic. Each service implements the corresponding interface, e.g., `IPatientService`, `IDoctorService`, etc. Services use repositories to interact with the database.

Example service methods include:

- `AddPatientAsync(PatientCreateDto dto)`
- `UpdatePatientAsync(int id, PatientUpdateDto dto)`
- `DeletePatientAsync(int id)`

## DTOs (Data Transfer Objects)

DTOs are used to decouple domain models from the API contracts. Example DTOs:

- **PatientDto**: used for returning patient information to the client.
- **PatientCreateDto**: used for creating new patients.
- **DoctorDto**, **DoctorCreateDto**, etc.

## Contributing

1. Fork the repository.
2. Create a feature branch.
3. Commit your changes.
4. Open a pull request.  
