using System;

namespace ConstructorAssignment
{
    // A class demonstrating constructor chaining
    public class Student
    {
        // Define public properties for Name and Major
        public string Name { get; set; }
        public string Major { get; set; }

        // Requirement 3: Chain two constructors together.
        // Constructor 1: Takes one parameter (name) and chains to Constructor 2 by passing a default major ("Undeclared")
        // using the ': this()' syntax.
        public Student(string name) : this(name, "Undeclared")
        {
            // Any specific initialization code for this constructor would go here, 
            // but the properties are already initialized by the chained constructor.
            Console.WriteLine("Called Constructor 1 (single parameter: Name)");
        }

        // Constructor 2: Takes two parameters (name and major) and initializes the properties.
        // This is the master constructor that is being chained to.
        public Student(string name, string major)
        {
            Name = name;
            Major = major;
            Console.WriteLine("Called Constructor 2 (two parameters: Name & Major)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory title for the console application.
            Console.WriteLine("Constructor Assignment");
            Console.WriteLine("----------------------");

            // Requirement 1: Create a const variable.
            // A constant variable must be initialized when declared and its value cannot be changed later.
            const string schoolName = "The Tech Academy C# Bootcamp";
            Console.WriteLine("School Name (constant): " + schoolName);
            Console.WriteLine();

            // Requirement 2: Create a variable using the keyword "var".
            // The "var" keyword creates an implicitly typed local variable where the compiler infers the type.
            var studentName = "Sample Student"; // Infers type 'string'
            var studentId = 10523;             // Infers type 'int'

            Console.WriteLine("Student info from 'var' variables:");
            Console.WriteLine("Name: " + studentName + " | ID: " + studentId);
            Console.WriteLine();

            // Demonstrate constructor chaining by instantiating two Student objects:
            
            // Scenario A: Instantiate a student with only their name (will trigger Constructor 1, which chains to Constructor 2).
            Console.WriteLine("Instantiating Student A (Name only, triggering Constructor 1):");
            Student studentA = new Student("Alice");
            Console.WriteLine("Student A Details -> Name: " + studentA.Name + " | Major: " + studentA.Major);
            Console.WriteLine();

            // Scenario B: Instantiate a student with both name and major (will trigger Constructor 2 directly).
            Console.WriteLine("Instantiating Student B (Name and Major, triggering Constructor 2 directly):");
            Student studentB = new Student("Bob", "Computer Science");
            Console.WriteLine("Student B Details -> Name: " + studentB.Name + " | Major: " + studentB.Major);

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
