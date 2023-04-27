using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static void PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = (Console.ReadLine());
        }
        
        
        Console.WriteLine("Hello Prep5 World!");
    }
}