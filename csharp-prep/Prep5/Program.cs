using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); //Calling display function to go first.

        string name = PromptUserName(); //Should ask for name.

        int number = PromptUserNumber(); // should ask for a number.

        int square = SquareNumber(number); //should square the number.

        DisplayResults(name, square);  // displays name and the sq result.

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
        
    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();

        return name;
    }
        
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}");
    }
}