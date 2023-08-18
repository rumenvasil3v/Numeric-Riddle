using System;

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

            Console.WriteLine("But before we start, I ask you! Do you want to play greates game ever?");
            Console.Write("Choose between [YES/NO]: ");
            string playerAnswer = Console.ReadLine();

            if (playerAnswer == "NO")
            {
                return;
            }

            Console.Write("Okay, great! Now go ahead and try to beat the great mind! But before we start choose your username: ");
            string username = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Okay {username}! Let's go");

            string playerOption;             

            while ((playerOption = Console.ReadLine()) != "NO")
            {
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
                        else if (playerChoice < computerChoice)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Mhm...Try again! You went too low!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    Console.WriteLine();
                    Console.Write("Write your suggestions (1 - 100): ");

                    playerSuggestions = Console.ReadLine();
                    isValid = int.TryParse(playerSuggestions, out playerChoice);
                }

                Console.WriteLine();
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine(@"I knew it you are a great mind, mister!
Congrats!");
                    Console.WriteLine("Now, I ask you! Do you want to face our great mind again, mister!");
                    Console.Write("Choose one of these options [YES/NO]: ");
                }
            }          
        }
    }
}
