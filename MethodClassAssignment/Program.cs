using System;

namespace MethodClassAssignment
{
    // A class containing custom math methods as requested by the assignment
    public class MathOperations
    {
        // A void method that takes two integers as parameters.
        // It performs a math operation on the first integer and displays the second integer to the screen.
        public void PerformMathAndDisplay(int numberOne, int numberTwo)
        {
            // Perform a mathematical operation on the first integer (multiplying it by 5).
            // Note: The assignment specifies doing a math operation on it, but we don't need to return or output it.
            int calculationResult = numberOne * 5;

            // Display the second integer (numberTwo) directly to the console screen.
            Console.WriteLine("The second parameter value is: " + numberTwo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory message for the console application.
            Console.WriteLine("Method Class Assignment");
            Console.WriteLine("------------------------");

            // Instantiate the MathOperations class (create an object of it).
            MathOperations mathOp = new MathOperations();

            // Call the method in the class, passing in two numbers (positional arguments: 12 and 34).
            Console.WriteLine("Calling method with positional arguments (12, 34):");
            mathOp.PerformMathAndDisplay(12, 34);

            Console.WriteLine(); // Print an empty line for clean formatting.

            // Call the method in the class, specifying the parameters by name (named arguments: numberOne and numberTwo).
            Console.WriteLine("Calling method with named arguments (numberOne: 7, numberTwo: 99):");
            mathOp.PerformMathAndDisplay(numberOne: 7, numberTwo: 99);

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
