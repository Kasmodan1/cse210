using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

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