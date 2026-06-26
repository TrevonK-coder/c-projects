using System;
using System.Collections.Generic;
using System.Linq; // Required for using LINQ extensions and lambda expressions like .Where()

namespace LambdaExpressionAssignment
{
    // Requirement 1: Create an Employee class with properties: Id, FirstName, LastName
    public class Employee
    {
        // Define public properties for Id, First Name, and Last Name
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory title for the console application.
            Console.WriteLine("Lambda Expression Assignment");
            Console.WriteLine("-----------------------------");

            // Requirement 2: Create a list of at least 10 employees.
            // At least two employees should have the first name "Joe".
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },      // Joe #1
                new Employee() { Id = 2, FirstName = "Alice", LastName = "Johnson" },
                new Employee() { Id = 3, FirstName = "Bob", LastName = "Davis" },
                new Employee() { Id = 4, FirstName = "Joe", LastName = "Jones" },      // Joe #2
                new Employee() { Id = 5, FirstName = "Charlie", LastName = "Brown" },
                new Employee() { Id = 6, FirstName = "Emily", LastName = "Miller" },
                new Employee() { Id = 7, FirstName = "Frank", LastName = "Wilson" },
                new Employee() { Id = 8, FirstName = "Grace", LastName = "Taylor" },
                new Employee() { Id = 9, FirstName = "Joe", LastName = "Anderson" },   // Joe #3 (additional test case)
                new Employee() { Id = 10, FirstName = "Hannah", LastName = "Thomas" }
            };

            // Display all employees in the initial list
            Console.WriteLine("All Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine("ID: " + emp.Id + " | Name: " + emp.FirstName + " " + emp.LastName);
            }
            Console.WriteLine();

            // ==========================================
            // FOREACH LOOP FILTERING
            // ==========================================
            // Requirement 3: Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> joesForeach = new List<Employee>();

            // Iterate through the original employees list
            foreach (Employee emp in employees)
            {
                // In your comparison statement, reference the property (FirstName) of the object (emp) you are checking
                if (emp.FirstName == "Joe")
                {
                    // Add the matching employee to our new list
                    joesForeach.Add(emp);
                }
            }

            // Display results from the foreach loop filter
            Console.WriteLine("Employees named 'Joe' (filtered using Foreach loop):");
            foreach (var joe in joesForeach)
            {
                Console.WriteLine("ID: " + joe.Id + " | Name: " + joe.FirstName + " " + joe.LastName);
            }
            Console.WriteLine();

            // ==========================================
            // LAMBDA FILTERING FOR "JOE"
            // ==========================================
            // Requirement 4: Perform the same action again, but this time with a lambda expression.
            // Using LINQ's .Where() method, passing a lambda expression (x => x.FirstName == "Joe")
            // to filter the collection, and converting the result back to a List.
            List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();

            // Display results from the lambda filter
            Console.WriteLine("Employees named 'Joe' (filtered using Lambda expression):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine("ID: " + joe.Id + " | Name: " + joe.FirstName + " " + joe.LastName);
            }
            Console.WriteLine();

            // ==========================================
            // LAMBDA FILTERING FOR ID > 5
            // ==========================================
            // Requirement 5: Using a lambda expression, make a list of all employees with an Id number greater than 5.
            // Using LINQ's .Where() with lambda (x => x.Id > 5) to select employees with ID greater than 5.
            List<Employee> idsGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            // Display results for employees with ID > 5
            Console.WriteLine("Employees with ID > 5 (filtered using Lambda expression):");
            foreach (var emp in idsGreaterThanFive)
            {
                Console.WriteLine("ID: " + emp.Id + " | Name: " + emp.FirstName + " " + emp.LastName);
            }

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
