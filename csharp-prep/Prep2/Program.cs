using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int gpercent = int.Parse(response);

        if (gpercent >= 90)
        {
            grade = "A";
        }

        else if (gpercent >= 80);
        {
            grade = "B";
        }
        
        else if (gpercent >= 70);
        {
            grade = "C";
        }

        else if (gpercent >= 60);
        {
            grade = "D";
        }

        else if (gpercent < 60);
        {
            grade = "F";
        }

    }
}