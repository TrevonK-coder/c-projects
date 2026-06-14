# Interface Assignment

A C# console application demonstrating interface definitions, inheritance, interface implementation, and polymorphism.

## Features & Requirements Met

1. **IQuittable Interface**: Created `IQuittable` interface defining a `void Quit()` method.
2. **Multiple Inheritance/Implementation**: Had the `Employee` class inherit from both the abstract base class `Person` and the `IQuittable` interface, implementing all required abstract members.
3. **Polymorphic Object Creation**: Instantiated an `Employee` object cast as the `IQuittable` interface type in the `Main()` method:
   ```csharp
   IQuittable quittableEmployee = new Employee();
   ```
4. **Method Execution**: Called the `Quit()` method on the interface-typed object.
5. **Detailed Comments**: Included rich, descriptive comments on all code blocks.

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
