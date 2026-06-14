using System;

namespace MethodsAndObjectsAssignment
{
    // Requirement 1: Create a class called Person.
    public class Person
    {
        // Requirement 1: Give it two properties, each of data type string.
        // One called FirstName, the other LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Requirement 2: Give this class a void method called SayName() that takes no parameters
        // and simply writes the person's full name to the console in the format of: "Name: [full name]"
        public void SayName()
        {
            // Writes the person's full name to the console by joining the first and last name properties.
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Requirement 3: Create another class called Employee and have it inherit from the Person class (using the : symbol).
    public class Employee : Person
    {
        // Requirement 3: Give the Employee class a property called Id and have it be of data type int.
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory title for the console application.
            Console.WriteLine("Methods and Objects Assignment");
            Console.WriteLine("------------------------------");

            // Requirement 4: Inside of the Main method, instantiate and initialize an Employee object
            // with a first name of "Sample" and a last name of "Student".
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 101 // Initialize the ID property to a sample value.
            };

            // Requirement 5: Call the superclass method SayName() on the Employee object.
            // Even though SayName() is defined in the Person class, Employee inherits it and can call it.
            employee.SayName();

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
