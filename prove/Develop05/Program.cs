using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
 
    bool exit = false;

    while (!exit)
    {
        
        Console.WriteLine($"You have {TotalPoints} Total Points");

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

                    // ask what goal type to start
                    Console.Write("1. Simple Goal ");
                    Console.Write("2. Eternal Goal ");
                    Console.Write("3. CheckList Goal ");
                    Console.Write("Enter goal Number: ");

                    int goalType = int.Parse(Console.ReadLine());

                    // ask for goal name
                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();

                    // ask for a description of the goal
                    Console.Write("Enter goal description: ");
                    string goalDescription = Console.ReadLine();

                    // ask how many points is it worth once completed
                    Console.Write("Enter goal points: ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    // Create the goal based on the user's input
                    Goal goal = new SimpleGoal(goalType, goalName, goalDescription, goalPoints);
                    Goal.Addgoals();
                                    

                
    
                    break;

                case "2":
                    //List All of the current goals.
                    Console.WriteLine("Current Goals:");
                    foreach (var goal in goals)
                    {
                        goal.ListGoalDetails();
                        Console.WriteLine();
                    }

                    break;

                case "3":
                    //Save goals.
                    foreach (var goal in goal.Goal)
                    {
                        FileHandler.SaveGoal(goal.Date, goal.type, goal.name, goal.description, goal.data);
                    }
                    break;

                case "4":
                    //Load goals
                    FileHandler.LoadGoal();
    

                    break;

                case "5":
                    //Record event
                    // Display the list of goals
                    Console.WriteLine("Select a goal to record an event for:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].GetGoalName()}");
                    }
                    
                    // Prompt for goal selection
                    Console.Write("Enter the number of the goal: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    
                    // Record event for the selected goal
                    if (goalIndex >= 0 && goalIndex < goals.Count)
                    {
                        goals[goalIndex].RecordEvent();
                        Console.WriteLine("Event recorded for the goal!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal selection!");
                    }

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