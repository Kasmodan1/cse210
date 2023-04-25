using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is the magic number?:");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your Guess?:");
        int guessNumber = int.Parse(Console.ReadLine());

        if (magicNumber == guessNumber)
            Console.Write("You guessed the Magic Number!");

        else if (magicNumber > guessNumber)
            Console.Write("Higher");
        
        else if (magicNumber < guessNumber)
            Console.Write("Lower");


    }
}