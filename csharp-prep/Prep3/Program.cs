using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?:");
        int magicNumber = int.Parse(Console.ReadLine());

        int guessNumber = 0;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your Guess?:");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed the Magic Number!");
            }
            else if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
        }

    }
}