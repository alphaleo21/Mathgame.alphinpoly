using System;
using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            welcome();
            while (true)
            {
                Console.Clear();
                int ch = gameMenu();
                if(ch == 5)
                {
                    Console.WriteLine($"Your score is {score}");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    score += startGame(ch);
                }
            }
        }

        static (int, int) randNo() 
        { 
            Random rand = new Random();

            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);

            return (a, b);
        
        }


        static int startGame(int ch)
        {
            var nums = randNo();
            int no1 = nums.Item1;
            int no2 = nums.Item2;
            Console.WriteLine("Give me the answer!!");
            switch (ch)
            {
                case 1:
                    int res = no1 + no2;
                    Console.WriteLine($"{no1}+{no2}");
                    int ans = Convert.ToInt32(Console.ReadLine());
                    if(res == ans) 
                    {
                        Console.WriteLine("You have got the right answer!!");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("Try again!!");
                        return 0;
                    }
                    break;
                default:
                    Console.WriteLine("thankyou");
                    return 0;
            }
                    
        }

        private static int gameMenu()
        {
            var index = 1;
            Console.WriteLine("Select the game you want to play\n");
            Console.WriteLine($"{index++}.Addition");
            Console.WriteLine($"{index++}.Subtraction");
            Console.WriteLine($"{index++}.Multiplication");
            Console.WriteLine($"{index++}.Division");
            Console.WriteLine($"{index}.Quit");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        static void welcome()
        {
            Console.WriteLine("Hello, What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"HELLO {name}, Welcome to the game!!");
        }
    }
}
