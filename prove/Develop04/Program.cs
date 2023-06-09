using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

    
        while (!exit);
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a number choice from the menu: ");
        
        string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    Console.WriteLine("Welcome to the Breathing Activity.");
                    //start the breathing activity
                    break;

                case "2":
                    Console.WriteLine("Welcome to the Reflection Activity.");
                    //start the reflection activity.
                    break;

                case "3":
                    Console.WriteLine("Welcome to the Listing Activity.");
                    //start the listing activity
                    break;
                
                case "4":
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
        // thought this was cool so they can hit any key to quit.
        Console.ReadKey();
 
    }

}