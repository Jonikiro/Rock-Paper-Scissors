using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            // Sets up exit variable
            string exit;

            // Sets up for user input
            int userInt;
            string userChoice;

            // Sets up array of choices
            string[] arrChoices = { "rock", "paper", "scissors" };

            do
            {
                // Used for victory/loss calculation
                userInt = 0;

                // User input validation loop
                while (userInt == 0)
                {
                    Console.WriteLine("Choose rock, paper, or scissors: ");
                    
                    // Normalizes user input
                    userChoice = Console.ReadLine().Trim().ToLower();   

                    // User choice announcement
                    if (arrChoices.Any(userChoice.Contains))
                    {
                        Console.WriteLine("\nYou chose " + userChoice + ".");
                        userInt = Array.IndexOf(arrChoices, userChoice) + 1;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter one of the three options: ");
                    }
                }

                // Initiate RNG
                Random random = new Random();
                int computerChoice = random.Next(1, 3);

                // Computer choice announcement
                Console.WriteLine("The computer chose " + arrChoices.ElementAt(computerChoice - 1) + ".");

                // Win/Lose condition announcement
                if (userInt == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((userInt == 1 && computerChoice == 3) ||
                         (userInt == 2 && computerChoice == 1) ||
                         (userInt == 3 && computerChoice == 2))
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost...");
                }

                // Replay functionality
                Console.Write("\nWould you like to try again? Type y or n: ");

                // Normalizes user input
                exit = Console.ReadLine().Trim().ToLower();

                // Input validation
                while (exit != "y" && exit != "n")
                {
                    Console.WriteLine("\nPlease enter y or n: ");

                    // Normalizes user input
                    exit = Console.ReadLine().Trim().ToLower();
                }

                Console.WriteLine("\n");
            } while (exit == "y");
        }
    }
}
