using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            int number = Console.ReadLine();

        }

        static int SquareNumber()
        {
            Console.WriteLine($"{PromptUserNumber}, the square of your number is {PromptUserNumber}");
        }

        static void DisplayResults()
        {
            {PromptUserName}
        }


        Console.WriteLine("Hello Prep5 World!");
    }
}