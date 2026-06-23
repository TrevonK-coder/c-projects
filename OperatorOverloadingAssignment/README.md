# Operator Overloading Assignment

A C# console application demonstrating operator overloading, specifically overloading `==` and `!=` operators on custom classes.

## Features & Requirements Met

1. **Employee Class**: Created an `Employee` class containing properties `Id` (int), `FirstName` (string), and `LastName` (string).
2. **Operator Overloading**: Overloaded both `==` and `!=` operators on the `Employee` class. Comparison is based strictly on their `Id` property.
3. **Reference Safeguards**: Implemented `ReferenceEquals` checks within the operator overloads to handle null inputs safely and avoid infinite recursive loops.
4. **Best Practices (Equals & GetHashCode)**: Overrode the `Equals()` and `GetHashCode()` methods on the class to keep them consistent with the overloaded equality operators.
5. **Main Program Comparison**: Instantiated two `Employee` objects with matching IDs (and different names) and compared them using `==`. Also compared them to a third `Employee` with a different ID using `!=` to display inequality results.
6. **Detailed Comments**: Fully documented the code with comments explaining each method, property, and comparison flow.

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
