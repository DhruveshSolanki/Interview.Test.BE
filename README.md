# GraduationTracker

## Overview

This solution provides a simple graduation tracking system for students. It consists of two projects:

- **GraduationTracker**: The main library containing models, repositories, and services to determine if a student has graduated based on diploma requirements and course marks.
- **GraduationTracker.Tests.Unit**: Unit tests for validating graduation logic.

### Approach

- **Models** represent students, courses, requirements, diplomas, and academic standing.
- **Repository** provides sample data and methods to retrieve students, diplomas, and requirements.
- **Service** encapsulates business logic for evaluating graduation criteria and academic standing.
- **GraduationTracker** service implements graduation logic by checking if a student meets diploma requirements and calculates their academic standing.
- **Unit tests** verify graduation status and standing for various student scenarios.

## Build Instructions

1. **Restore dependencies**  
   Open a terminal in the solution root and run:
   ```sh
   dotnet restore
   ```

2. **Build the solution**  
   ```sh
   dotnet build
   ```

## Run Instructions

### Running Unit Tests

To execute all unit tests:
```sh
dotnet test
```

This will build the solution and run tests in the `GraduationTracker.Tests.Unit` project.

## Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)