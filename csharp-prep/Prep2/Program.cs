using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int gpercent = int.Parse(response);

       string grade = "";

        if (gpercent >= 90)
        {
            grade = "A";
        }

        else if (gpercent >= 80)
        {
            grade = "B";
        }
        
        else if (gpercent >= 70)
        {
            grade = "C";
        }

        else if (gpercent >= 60)
        {
            grade = "D";
        }

        else if (gpercent < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade for the class is: {grade}");

        if (gpercent >= 70)
        {
            Console.WriteLine("Congradulations you passed the class");
        }
        else 
        {
            Console.WriteLine("I'm sorry you failed. Please try again soon.");
        }


    }
}