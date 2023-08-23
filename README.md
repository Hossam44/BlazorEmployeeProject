# Employee Management

Welcome to the Employee Management project repository. This project is designed to provide an efficient solution for managing employee data across various layers and components.

## Project Overview

The Employee Management project is organized into multiple layers to handle different aspects of employee data management:

### 1. API Project

The API project serves as the entry point for interacting with the application. It exposes endpoints to fetch employee data and perform operations related to employees.

### 2. Business Layer

The business layer is responsible for handling the core logic of employee management. It interacts with the API project to retrieve employee data and execute business rules specific to employees.

### 3. Data Access Layer

The data access layer contains Data Transfer Objects (DTOs) and functions that the API project uses. It also includes repositories responsible for managing interactions with the database using Entity Framework. The layer also houses the DbContext for data operations.

### 4. Business Objects Project

The Business Objects project holds the definitions of business objects and models used throughout the application. This project promotes code reusability and encapsulates the core concepts of the employee management domain.

### 5. Blazor Project

The Blazor project provides the user interface using the Blazor framework. It contains classes that manage application logic and services that interact with the API to fetch and manipulate employee data. This approach separates C# logic from Razor views.



