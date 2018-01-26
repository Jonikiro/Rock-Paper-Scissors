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
            //Initialize variables
            string exit;                //Sets up exit variable
            int userInt;                //Sets up for user input
            string userChoice;

            do
            {
                userInt = 0;            //Used for victory/loss calculation

                //User input validation loop
                while (true)
                {
                    Console.Write("Choose rock, paper, or scissors: ");
                    userChoice = Console.ReadLine().Trim().ToLower();   //Normalizes user input

                    //User choice announcement
                    switch (userChoice)
                    {
                        case "rock":
                            Console.WriteLine("\nYou chose rock.");
                            userInt = 1;
                            break;
                        case "paper":
                            Console.WriteLine("\nYou chose paper.");
                            userInt = 2;
                            break;
                        case "scissors":
                            Console.WriteLine("\nYou chose scissors.");
                            userInt = 3;
                            break;
                        default:
                            Console.WriteLine("\nPlease enter one of the three options: ");
                            break;
                    }

                    //Loop break check
                    if (userInt != 0) break;
                }

                //Initiate RNG
                Random random = new Random();
                int computerChoice = random.Next(1, 3);

                //Computer choice announcement
                switch (computerChoice)
                {
                    case 1:
                        Console.WriteLine("The computer chose rock.");
                        break;
                    case 2:
                        Console.WriteLine("The computer chose paper.");
                        break;
                    case 3:
                        Console.WriteLine("The computer chose scissors.");
                        break;
                }

                //Win/Lose condition announcement
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

                //Replay functionality
                Console.Write("\nWould you like to try again? Type y or n: ");
                exit = Console.ReadLine().Trim().ToLower();   //Normalizes user input

                while (exit != "y" && exit != "n")  //Input validation
                {
                    Console.WriteLine("\nPlease enter y or n: ");
                    exit = Console.ReadLine().Trim().ToLower();   //Normalizes user input
                }

                Console.WriteLine("\n");
            } while (exit == "y");
        }
    }
}
