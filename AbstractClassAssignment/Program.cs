using System;

namespace AbstractClassAssignment
{
    // Requirement 1: Create an abstract class called Person.
    // Abstract classes cannot be instantiated and are meant to be base classes.
    public abstract class Person
    {
        // Requirement 1: Define two properties: string FirstName and string LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Requirement 2: Give it the method SayName().
        // Declaring it as 'abstract void' means it has no implementation body here,
        // and any non-abstract class inheriting from Person MUST implement this method.
        public abstract void SayName();
    }

    // Requirement 3: Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person
    {
        // Requirement 4: Implement the SayName() method inside of the Employee class.
        // We use the 'override' keyword to provide the implementation for the abstract method.
        public override void SayName()
        {
            // Writes the employee's full name to the console.
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory title for the console application.
            Console.WriteLine("Abstract Class Assignment");
            Console.WriteLine("-------------------------");

            // Requirement 5: Inside the Main() method, instantiate an Employee object
            // with firstName "Sample" and lastName "Student".
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Requirement 5: Call the SayName() method on the object.
            employee.SayName();

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
