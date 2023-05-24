﻿using System;

namespace Numeric_Riddle_Game_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int computerChoice = number.Next(1, 101);

            Console.WriteLine("The computer has chose a number!");
            Console.WriteLine();

            Console.WriteLine("And you need to guess it!");
            Console.WriteLine();

            Console.WriteLine("I give you this only possibility to beat the great mind!");
            Console.WriteLine();

            Console.Write("Write your suggestion (1 - 100): ");

            string playerSuggestions = Console.ReadLine();
            bool isValid = int.TryParse(playerSuggestions, out int playerChoice);

            while (playerChoice != computerChoice)
            {
                if (isValid)
                {
                    if (playerChoice > computerChoice)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Mhm...Try again! You went too high!");
                    }
                }
                else if (isValid)
                {
                    if (computerChoice > playerChoice)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Mhm...Try again! You went too low!");
                    }
                }
                else
                {
                    if (!isValid)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                Console.WriteLine();
                Console.Write("Write your suggestions (1 - 100): ");

                playerSuggestions = Console.ReadLine();
                isValid = int.TryParse(playerSuggestions, out playerChoice);
            }

            Console.WriteLine();
            if (playerChoice == computerChoice)
            {
                Console.WriteLine(@"I knew it you are great mind, mister!
Congrats!");
            }
        }
    }
}
