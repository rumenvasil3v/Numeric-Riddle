using System;
using System.Xml.Serialization;

namespace Numeric_Riddle_Game_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Red;

            int countOfTries = 10;
            int tries = 0;
            int n = 101;
            Random number = new Random();
            int computerChoice = number.Next(1, n);

            Console.WriteLine("The computer has chose a number!");
            Console.WriteLine();

            Console.WriteLine("And you need to guess it!");
            Console.WriteLine();

            Console.WriteLine("You have only 10 tries to guess it and if you don't, don't worry!");
            Console.WriteLine();

            Console.WriteLine("Come again next time and I am sure it will be your lucky day!");
            Console.WriteLine();

            Console.WriteLine("I give you this only possibility to beat the great mind!");
            Console.WriteLine();

            Console.WriteLine("But before we start, I ask you! Do you want to play the greatest game ever?");
            Console.Write("Choose between [YES/NO]: ");
            string playerAnswer = Console.ReadLine();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (playerAnswer == "NO" || playerAnswer == string.Empty)
            {
                Console.WriteLine("At least I tried! Thank you for your precious time and have a good day!");
                return;
            }

            Console.Write("Okay, great! Now go ahead and try to beat the great mind! But before we start choose your username: ");
            string username = Console.ReadLine();

            while (username == string.Empty)
            {
                Console.WriteLine("Invalid username!");
                Console.WriteLine("Try again!");
                Console.Write("Choose username: ");
                username = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Okay {username}! Let's go");

            Console.Write($"Write your suggestions (1 - {n - 1}): ");
            string playerSuggestions = Console.ReadLine();
            bool isValid = int.TryParse(playerSuggestions, out int playerChoice);

            while (playerChoice != computerChoice)
            {
                if (isValid)
                {
                    if (playerChoice > computerChoice)
                    {
                        tries++;
                        Console.WriteLine("Mhm...Try again! You went too high!");
                    }
                    else if (playerChoice < computerChoice)
                    {
                        tries++;
                        Console.WriteLine("Mhm...Try again! You went too low!");
                    }  
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                if (tries == countOfTries)
                {
                    Console.WriteLine($"Your {countOfTries} tries burned!");
                    Console.WriteLine("Sorry, fellow! Come again next time and see ya!");
                    return;
                }

                Console.WriteLine();
                Console.Write($"Write your suggestions (1 - {n - 1}): ");

                playerSuggestions = Console.ReadLine();
                isValid = int.TryParse(playerSuggestions, out playerChoice);

                if (playerChoice == computerChoice)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine(@"I knew it you are a great mind, mister!
Congrats!");
                    Console.WriteLine("Now, I ask you! Do you want to face our great mind again, mister!");
                    Console.Write("Choose one of these options [YES/NO]: ");
                    string playerOption = Console.ReadLine();

                    if (playerOption == "YES")
                    {
                        countOfTries += 5;
                        tries = 0;

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        n += 100;

                        Console.WriteLine();

                        Console.WriteLine("Ookay then, Go ahead, but this time we increase the difficulty!");
                        Console.WriteLine("But also your tries are increasing +5!");

                        Console.WriteLine();

                        Console.WriteLine($"The computer will choose random number between 1 - {n - 1}!");

                        Console.WriteLine("Soo, it is your risk, but I am sure you will succeed!");

                        Console.WriteLine("Go ahead and show the great mind who is greater!");

                        computerChoice = number.Next(1, n);

                        Console.WriteLine();
                        Console.Write($"Write your suggestions (1 - {n - 1}): ");

                        playerSuggestions = Console.ReadLine();
                        isValid = int.TryParse(playerSuggestions, out playerChoice);
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}

