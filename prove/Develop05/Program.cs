using System;
using System.Threading;

class Program
{
    private static int points = Goal.GetPoints();

    static void Main(string[] args)
    {
 
    bool exit = false;

    while (!exit)
    {
        
        Console.WriteLine($"You have {points} points");

        Console.WriteLine(" ");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a number choice from the menu: ");

        string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    //Create a goal.
                    //Goal goal = new Goal();
                    //Breathing  breathing = new Breathing();
                    //breathing.StartBreathingActivity();
                    break;
                case "2":
                    //List the current goals.
                    //Reflection reflection = new Reflection();
                    //reflection.StartReflectionActivity();
                    break;
                case "3":
                    //Save goals.
                    //Listing listing = new Listing();

                    break;

                case "4":
                    //Load goals

                    break;
                case "5":
                    //Record event

                    break;
                case "6":
                    // This will exit the while loop.
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Please enter a number from the menu.");
                    break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Exiting the program. Press any key to close...");
        
        Console.ReadKey();
 
    }

}