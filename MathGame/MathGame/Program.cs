using System;
using System.ComponentModel.Design;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            welcome();
            gameMenu();

        }

        private static void gameMenu()
        {
            var index = 1;
            Console.WriteLine("Select the game you want to play\n");
            Console.WriteLine($"{index++}.Addition");
            Console.WriteLine($"{index++}.Subtraction");
            Console.WriteLine($"{index++}.Multiplication");
            Console.WriteLine($"{index}.Division");
        }

        static void welcome()
        {
            Console.WriteLine("Hello, What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"HELLO {name}, Welcome to the game!!");
        }
    }
}
