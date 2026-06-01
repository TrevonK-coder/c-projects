# Package Express Quote Application

A console-based C# application that calculates a shipping quote for packages based on weight and dimensions, enforcing package size and weight constraints.

## Features

- Welcomes users to **Package Express**.
- Prompts for package weight and ends the program with a custom message if weight exceeds 50.
- Prompts for package dimensions (width, height, length).
- Computes total dimensions and ends the program if the total exceeds 50.
- Calculates shipping quote using the formula: `((Width * Height * Length) * Weight) / 100`.
- Displays the final shipping quote formatted as a dollar amount.
- Completely commented code for readability and maintenance.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (Version 6.0, 7.0, or 8.0) OR the legacy Windows C# compiler (`csc.exe`) included with the .NET Framework.

## How to Build and Run

### Using the .NET SDK (Recommended)

1. Open a terminal (PowerShell, Command Prompt, or terminal of choice) in this directory.
2. Build and run the application:
   ```bash
   dotnet run
   ```

### Using legacy .NET Framework Compiler (`csc.exe`)

If you are on Windows and don't have the modern .NET SDK installed:
1. Open PowerShell or Command Prompt.
2. Compile `Program.cs`:
   ```cmd
   C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe Program.cs /out:PackageExpress.exe
   ```
3. Run the compiled executable:
   ```cmd
   .\PackageExpress.exe
   ```
