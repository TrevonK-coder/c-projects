using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Display the welcome message as the very first line of the program.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the weight of the package.
            Console.WriteLine("Please enter the package weight:");
            
            // Read the user's input from the console.
            string weightInput = Console.ReadLine();
            
            // Variable to store the parsed double value of the weight.
            double weight;

            // Attempt to parse the user's input into a double. If parsing fails, display an error and exit.
            if (!double.TryParse(weightInput, out weight))
            {
                Console.WriteLine("Invalid weight format. Please enter a valid number. Exiting program.");
                return;
            }

            // Requirement 2: If the weight is greater than 50, display the error message and end the program.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Terminate program execution.
                return;
            }

            // Prompt the user to enter the width of the package.
            Console.WriteLine("Please enter the package width:");
            
            // Read the width input from the console.
            string widthInput = Console.ReadLine();
            
            // Variable to store the parsed double value of the width.
            double width;

            // Attempt to parse the width input. If parsing fails, display an error and exit.
            if (!double.TryParse(widthInput, out width))
            {
                Console.WriteLine("Invalid width format. Please enter a valid number. Exiting program.");
                return;
            }

            // Prompt the user to enter the height of the package.
            Console.WriteLine("Please enter the package height:");
            
            // Read the height input from the console.
            string heightInput = Console.ReadLine();
            
            // Variable to store the parsed double value of the height.
            double height;

            // Attempt to parse the height input. If parsing fails, display an error and exit.
            if (!double.TryParse(heightInput, out height))
            {
                Console.WriteLine("Invalid height format. Please enter a valid number. Exiting program.");
                return;
            }

            // Prompt the user to enter the length of the package.
            Console.WriteLine("Please enter the package length:");
            
            // Read the length input from the console.
            string lengthInput = Console.ReadLine();
            
            // Variable to store the parsed double value of the length.
            double length;

            // Attempt to parse the length input. If parsing fails, display an error and exit.
            if (!double.TryParse(lengthInput, out length))
            {
                Console.WriteLine("Invalid length format. Please enter a valid number. Exiting program.");
                return;
            }

            // Calculate the total dimensions (width + height + length).
            double totalDimensions = width + height + length;

            // Requirement 3: If the dimensions total greater than 50, display the error message and end the program.
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Terminate program execution.
                return;
            }

            // Requirement 4: Multiply the three dimensions (height, width, & length) together to get the volume product.
            double volumeProduct = width * height * length;

            // Multiply the product of the dimensions by the weight.
            double dimensionalWeightProduct = volumeProduct * weight;

            // Divide the outcome by 100 to get the final shipping quote.
            double quote = dimensionalWeightProduct / 100.0;

            // Requirement 5: Display the final quote formatted as a currency/dollar amount.
            // Using "F2" format specifier to output standard USD format (e.g. $528.00).
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Requirement 6: Display the closing thank you message.
            Console.WriteLine("Thank you!");
        }
    }
}
