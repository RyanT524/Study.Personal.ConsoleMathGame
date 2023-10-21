﻿
namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game. It's great that you're working on improving yourself");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below: 
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("-------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        engine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Environment.Exit(1);
                        break;

                }
            } while (isGameOn);

        }
    }
}
