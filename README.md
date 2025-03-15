Clean Architecture Authentication Solution - Project Overview
I've rewritten your authentication solution following clean architecture principles with a clear separation of concerns. Here's a summary of what I've implemented:
Domain Layer

Core business entities and value objects
Business interfaces for services and repositories
No dependencies on other layers

Application Layer

DTOs for data transfer
Service implementations orchestrating business logic
Depends only on the Domain layer

Infrastructure Layer

Repository implementations
Database context
JWT token service implementation
CurrentUser service implementation
Depends only on the Domain layer (not Application)

API Layer (Presentation)

Controllers for authentication and user operations
Error handling middleware
Configuration for authentication and services
Depends on Application and Infrastructure layers

Key Features Implemented

JWT Authentication

Secure token generation and validation
Refresh token support
Extended session with "remember me" option


User Management

Registration with validation
Login with account lockout for failed attempts
Profile management
Admin-only functionality


Security Features

Password policy enforcement
Account lockout after multiple failed attempts
Role-based authorization
Refresh token rotation


Error Handling

Global exception middleware
Consistent API responses
Development vs. production error details



Clean Code Practices Applied

SOLID Principles

Single Responsibility: Each class has one responsibility
Open/Closed: Extensions through interfaces
Liskov Substitution: Using proper inheritance
Interface Segregation: Specific interfaces
Dependency Inversion: Dependencies on abstractions


Dependency Injection

All services registered in the IoC container
Constructor injection for dependencies


Proper Exception Handling

Global exception middleware
Try-catch blocks with specific error messages


Separation of Concerns

Clear boundaries between layers
Each layer has specific responsibilities
