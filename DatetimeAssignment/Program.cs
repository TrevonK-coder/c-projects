using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory title for the console application.
            Console.WriteLine("Datetime Assignment");
            Console.WriteLine("-------------------");

            // Requirement 1: Print the current date and time to the console.
            // DateTime.Now retrieves the current local system date and time.
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + currentTime);

            // Requirement 2: Ask the user for a number.
            Console.WriteLine("\nPlease enter a number of hours to look ahead:");
            string userInput = Console.ReadLine();
            double hoursEntered;

            // Validate the user's input to ensure it is a valid double (allowing fractional hours like 2.5).
            if (double.TryParse(userInput, out hoursEntered))
            {
                // Calculate the future date/time by adding the user's hours to the current date/time.
                // The AddHours() method returns a new DateTime object representing that future point in time.
                DateTime futureTime = currentTime.AddHours(hoursEntered);

                // Requirement 3: Print to the console the exact time it will be in X hours.
                Console.WriteLine("\nIn " + hoursEntered + " hour(s), the exact date and time will be: " + futureTime);
            }
            else
            {
                // Display error message if the input is not a valid number.
                Console.WriteLine("Invalid number format entered. Please enter a valid numeric value.");
            }

            // Print closing message.
            Console.WriteLine("\nPress any key to exit...");
        }
    }
}
