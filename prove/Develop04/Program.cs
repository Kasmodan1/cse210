using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        
          // Create an instance of the Activity class
        Activity activity = new Activity();

        // Test the DisplayMsg method
        activity.DisplayMsg("Welcome to the activity!");

        // Test the ActivityDuration method
        TimeSpan duration = activity.ActivityDuration(30);
        Console.WriteLine($"Activity duration: {duration}");

        // Test the ActivityPauseTime method
        activity.ActivityPauseTime(5); // Pause for 5 seconds

                // Test the ActivityPauseTime method
        activity.ActivityPauseTime(10); // Pause for 10 seconds

        Console.WriteLine("Testing complete.");

        // Example 1: Use the default message with countdown
        activity.ActivityPauseTime(5);

        // Example 2: Use a custom message without countdown
        activity.ActivityPauseTime(5, "Please wait...");

        // Example 3: Use a custom message with countdown
        activity.ActivityPauseTime(5, "Custom message: {0} seconds remaining...");

        Console.WriteLine("Testing complete.");

        // Test the ActivityResetTime method
        activity.ActivityResetTime(true);

        Console.WriteLine("Testing complete.");


        bool exit = false;

        while (!exit)
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