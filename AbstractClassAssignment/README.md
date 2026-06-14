# Abstract Class Assignment

A C# console application demonstrating abstract classes, abstract methods, method overriding, and inheritance.

## Features & Requirements Met

1. **Abstract Person Class**: Created the `Person` abstract class containing `FirstName` and `LastName` string properties.
2. **Abstract SayName Method**: Declared `SayName()` as an abstract method with no body in `Person`.
3. **Employee Class**: Inherited `Employee` from `Person`.
4. **Method Implementation**: Overrode and implemented `SayName()` in `Employee` using the `override` keyword to print the person's full name.
5. **Main Execution**: Instantiated an `Employee` with `FirstName = "Sample"`, `LastName = "Student"`, and called `SayName()`.
6. **Detailed Comments**: Added comprehensive line-by-line comments to explain all object-oriented features.

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
