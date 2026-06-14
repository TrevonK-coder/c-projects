# Methods and Objects Assignment

A C# console application demonstrating class inheritance, property definition, and method inheritance.

## Features & Requirements Met

1. **Person Class**: Created the `Person` base class with properties `FirstName` (string) and `LastName` (string).
2. **SayName Method**: Added a void method `SayName()` inside `Person` which prints the full name in the format: `Name: [full name]`.
3. **Employee Class**: Created the `Employee` class that inherits from `Person` and adds an `Id` property (int).
4. **Main Instantiation**: Instantiated `Employee` in the `Main()` method and initialized `FirstName = "Sample"` and `LastName = "Student"`.
5. **Superclass Method Calling**: Called the inherited `SayName()` method on the `Employee` object.
6. **Detailed Comments**: Added comprehensive comments to explain the logic and class relationships.

## How to Build and Run

### Using the .NET SDK

1. Navigate to this directory in your terminal.
2. Execute:
   ```bash
   dotnet run
   ```

### Using legacy .NET Framework Compiler (`csc.exe`)

1. Open a terminal in this directory.
2. Compile:
   ```cmd
   C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe Program.cs
   ```
3. Run the compiled executable:
   ```cmd
   .\Program.exe
   ```
