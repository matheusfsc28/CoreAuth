# CoreAuth Project

## Project Overview
CoreAuth is a modular authentication core system built with **.NET 10.0** and **Clean Architecture**. It follows **Domain-Driven Design (DDD)** principles to provide a robust and maintainable foundation for user management and authentication processes.

### Technologies
- **Runtime:** .NET 10.0
- **Language:** C#
- **ORM:** Entity Framework Core (EF Core)
- **Database:** PostgreSQL (via Npgsql)
- **Naming Convention:** snake_case (managed via `EFCore.NamingConventions`)
- **Testing Framework:** xUnit

### Architecture
The project is divided into several layers according to Clean Architecture:
- **CoreAuth.Domain:** Contains core business logic, entities (`User`, `RefreshToken`, `PasswordResetToken`), enums, and repository interfaces.
- **CoreAuth.Application:** Implements use cases, commands, and queries (e.g., `CreateUserCommand`).
- **CoreAuth.Infrastructure:** Handles external concerns like data access (EF Core), repository implementations, Unit of Work, and dependency injection configuration.
- **CoreAuth.Exceptions:** Centralized exception handling and localized resource messages (`ResourceMessagesException`).
- **CoreAuth.Common:** Shared utilities, settings (e.g., `JwtTokenSettings`), and common logic.

## Building and Running

### Prerequisites
- .NET 10 SDK or later.
- PostgreSQL database.

### Key Commands
- **Build the solution:**
  ```bash
  dotnet build
  ```
- **Run tests:**
  ```bash
  dotnet test
  ```
- **Run (TODO):** Currently, the solution contains library and infrastructure layers. An entry-point project (e.g., Web API) is not yet present in the `src` directory.

## Development Conventions

### Domain-Driven Design (DDD)
- **Entities:** Entities like `User` use private setters and expose public methods/constructors for state changes.
- **Validation:** Business rule validation is performed directly within entities (e.g., `User.Validate()`), throwing custom exceptions like `ErrorOnValidationException` when rules are violated.

### Data Access
- **Repository Pattern:** Interfaces for reading and writing are split (e.g., `IUserReadRepository`, `IUserWriteRepository`).
- **Unit of Work:** Used to coordinate changes across multiple repositories.
- **Soft Delete:** Implemented via a `BaseEntity` with a `DeletedAt` property. A Global Query Filter in `CoreAuthDbContext` automatically excludes soft-deleted records.
- **Snake Case:** All database tables and columns use `snake_case` naming conventions.

### Error Handling
- Use the custom exceptions defined in `CoreAuth.Exceptions.BaseExceptions`.
- Localized messages are stored in `.resx` files and accessed via `ResourceMessagesException`.

### Testing
- Tests are located in the `tests` directory.
- `CommonTestUtilities` provides builders (e.g., `UserBuilder`) for creating test data.
- Domain tests verify entity behavior and validation logic.
