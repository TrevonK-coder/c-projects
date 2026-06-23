using System;

namespace OperatorOverloadingAssignment
{
    // Requirement 1: Create an Employee class with Id, FirstName and LastName properties.
    public class Employee
    {
        // Define properties of the Employee class.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Requirement 2: Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        // The method must be public static and return a bool.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // First, perform null reference checks using ReferenceEquals to avoid infinite recursion.
            // If both objects refer to the same memory location (or are both null), they are equal.
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one of the objects is null (but not both, since we checked above), they are not equal.
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Compare the Id properties of the two Employee objects and return the result.
            return emp1.Id == emp2.Id;
        }

        // Requirement 3: Comparison operators must be overloaded in pairs (overload "!=" to match "==").
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Negate the result of the overloaded "==" operator to check for inequality.
            return !(emp1 == emp2);
        }

        // Best Practice: When overloading == and !=, it is highly recommended to override the Equals method.
        public override bool Equals(object obj)
        {
            // Cast the object to an Employee.
            Employee otherEmployee = obj as Employee;

            // If the object is null or not an Employee, it cannot be equal.
            if (otherEmployee == null)
            {
                return false;
            }

            // Return true if their Id values are equal.
            return this.Id == otherEmployee.Id;
        }

        // Best Practice: When overriding Equals, you should also override GetHashCode to avoid compiler warnings
        // and ensure the object behaves correctly in hash-based collections like Dictionary or HashSet.
        public override int GetHashCode()
        {
            // Use the Id hashcode as the primary representation.
            return this.Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory title for the console application.
            Console.WriteLine("Operator Overloading Assignment");
            Console.WriteLine("--------------------------------");

            // Requirement 4: Instantiate two objects of the Employee class and assign values to their properties.
            // We'll give these two employees the same ID (1) to check if the equality operator works correctly.
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            Employee employee2 = new Employee()
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Instantiate a third Employee object with a different ID (2) to test inequality.
            Employee employee3 = new Employee()
            {
                Id = 2,
                FirstName = "David",
                LastName = "Johnson"
            };

            // Requirement 4: Compare the two Employee objects using the newly overloaded operators and display the results.
            Console.WriteLine("Employee 1: " + employee1.FirstName + " " + employee1.LastName + " (ID: " + employee1.Id + ")");
            Console.WriteLine("Employee 2: " + employee2.FirstName + " " + employee2.LastName + " (ID: " + employee2.Id + ")");
            Console.WriteLine("Employee 3: " + employee3.FirstName + " " + employee3.LastName + " (ID: " + employee3.Id + ")");
            Console.WriteLine();

            // Test 1: Compare Employee 1 and Employee 2 using the overloaded "==" operator (expected to be equal because of same ID).
            Console.WriteLine("Testing Equality (employee1 == employee2):");
            if (employee1 == employee2)
            {
                Console.WriteLine("Result: Employees are equal (IDs match).");
            }
            else
            {
                Console.WriteLine("Result: Employees are NOT equal.");
            }
            Console.WriteLine();

            // Test 2: Compare Employee 1 and Employee 3 using the overloaded "!=" operator (expected to be not equal because of different IDs).
            Console.WriteLine("Testing Inequality (employee1 != employee3):");
            if (employee1 != employee3)
            {
                Console.WriteLine("Result: Employees are not equal (IDs do not match).");
            }
            else
            {
                Console.WriteLine("Result: Employees are equal.");
            }

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
