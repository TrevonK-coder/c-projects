# Lambda Expression Assignment

A C# console application demonstrating list operations, filtering using standard `foreach` loops, and filtering using LINQ with lambda expressions.

## Features & Requirements Met

1. **Employee Class**: Created an `Employee` class containing properties `Id` (int), `FirstName` (string), and `LastName` (string).
2. **List Initialization**: Created a list of 10 employees inside the `Main()` method. Exactly three employees in the list have the first name "Joe".
3. **Foreach Filtering**: Filtered the list for employees with `FirstName == "Joe"` using a standard C# `foreach` loop and created a new list, referencing the `FirstName` property explicitly.
4. **Lambda Filtering ("Joe")**: Filtered the list for employees with `FirstName == "Joe"` using a LINQ lambda expression:
   ```csharp
   List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();
   ```
5. **Lambda Filtering (Id > 5)**: Filtered the list for employees with `Id > 5` using a LINQ lambda expression:
   ```csharp
   List<Employee> idsGreaterThanFive = employees.Where(x => x.Id > 5).ToList();
   ```
6. **Detailed Comments**: Fully documented the code with comments explaining each step of list instantiation and filtering logic.

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
