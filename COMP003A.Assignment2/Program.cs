// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: To showcase my ability to create a discount calculator using C# code.

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            string userFirstName; // Variable to store the user's first name
            string userLastName; // Variable to store the user's first name
            int userAge; // Variable to store the user's age
            double productPrice; // Variable to store the product price
            bool isStudent; // Variable to store if the user is a student (true/false)

            Console.Write("**************************************************\nWelcome to the Discount Calculator!\n**************************************************\n"); // Greeting message for the user

            // Prompt the user to enter their name
            Console.Write("What is your first name? ");
            userFirstName = Console.ReadLine(); // Read and assign the user's input to userFirstName

            Console.Write("What is your last name? ");
            userLastName = Console.ReadLine(); // Read and assign the user's input to userLastName

            // Prompt the user to enter their age
            Console.Write("How old are you? ");
            userAge = int.Parse(Console.ReadLine()); // Convert and assign the user's input to userAge

            // Prompt the user to enter the product price
            Console.Write("What is the price of the item you're interested in? ");
            productPrice = int.Parse(Console.ReadLine()); // Convert and assign the user's input to productPrice

            // Prompt the user to indicate if they are a student
            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine()); // Convert and assign the user's input to isStudent

            // Perform calculations
            int futureAge = userAge + 5; // Calculate the user's age in 5 years
            bool isAdult = userAge >= 18; // Determine if the user is 18 or older
            bool isAdultStudent = isStudent && isAdult; // Determine if the user is both a student and an adult

            Console.WriteLine($"\n\n\n**************************************************");
            // Display outputs using string interpolation
            Console.WriteLine($"Hello, {userFirstName} {userLastName}!"); // Greet the user with their name
            Console.WriteLine($"You are currently {userAge} years old.");
            Console.WriteLine($"In 5 years, you will be {futureAge}."); // Display current and future age
            Console.WriteLine($"Are you 18 or older? {isAdult}"); // Display if the user is 18 or older
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}"); // Display if the user is both a student and an adult
            Console.WriteLine($"**************************************************");
        }
    }
}