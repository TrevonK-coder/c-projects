using System;

namespace InterfaceAssignment
{
    // Class from previous drill: Abstract class called Person.
    public abstract class Person
    {
        // Properties of the Person class.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName to be implemented by derived classes.
        public abstract void SayName();
    }

    // Requirement 1: Create an interface called IQuittable.
    // Interfaces define a contract that implementing classes must follow.
    public interface IQuittable
    {
        // Define a void method called Quit() with no implementation body.
        void Quit();
    }

    // Requirement 2: Have your Employee class inherit from both Person (base class) and IQuittable (interface).
    // In C#, a class can only inherit from one base class but can implement multiple interfaces.
    public class Employee : Person, IQuittable
    {
        // Implement the SayName() method from the Person class.
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Requirement 2: Implement the Quit() method from the IQuittable interface.
        public void Quit()
        {
            // Display message indicating the employee is quitting.
            Console.WriteLine("The employee " + FirstName + " " + LastName + " has quitted the position.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory title for the console application.
            Console.WriteLine("Interface Assignment");
            Console.WriteLine("--------------------");

            // Requirement 3: Use polymorphism to create an object of type IQuittable.
            // We instantiate an Employee object but reference it using the IQuittable interface type.
            IQuittable quittableEmployee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Requirement 3: Call the Quit() method on the IQuittable object.
            // Polymorphism allows us to call the method defined by the interface, executed by the Employee implementation.
            quittableEmployee.Quit();

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
