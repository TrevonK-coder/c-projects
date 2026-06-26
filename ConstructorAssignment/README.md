# Constructor Assignment

A C# console application demonstrating constant variables, implicitly typed local variables (using `var`), and constructor chaining.

## Features & Requirements Met

1. **Const Variable**: Declared and printed a constant string `schoolName`:
   ```csharp
   const string schoolName = "The Tech Academy C# Bootcamp";
   ```
2. **Var Keyword**: Initialized implicitly typed local variables `studentName` and `studentId` using `var`.
3. **Constructor Chaining**: Chained a single-parameter constructor to a two-parameter constructor in the `Student` class using the `: this()` syntax:
   ```csharp
   public Student(string name) : this(name, "Undeclared") { ... }
   ```
4. **Detailed Comments**: Added comprehensive line-by-line developer comments to explain syntax and compiler mechanics.

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
