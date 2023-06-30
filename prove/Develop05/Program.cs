using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static ScoreRecorder scoreRecorder = new ScoreRecorder();

    static void Main(string[] args)
    {
 
    bool exit = false;

    while (!exit)
    {
        
        Console.WriteLine($"You have {scoreRecorder.GetScore()} Total Points");

        Console.WriteLine(" ");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a number choice from the menu: ");

        string menuChoice = Console.ReadLine();
        Console.Clear();
            switch (menuChoice)
            {
                case "1":


                    // ask what goal type to start
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1. Simple Goal ");
                    Console.WriteLine("2. Eternal Goal ");
                    Console.WriteLine("3. CheckList Goal ");
                    Console.Write("which type of goal would you like to create? ");
                    int goalType = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (goalType == 1)
                    {
                        //fetch the current date and display it as the start date.
                        DateTime goalStartDate = DateTime.Today;
                        string formattedStartDate = goalStartDate.ToString("MM/dd/yy");
                        Console.WriteLine($"This new goal will begin today {formattedStartDate}");

                        Console.Write("Do you want to add a end date for this goal? (yes/no): ");
                        string input = Console.ReadLine();

                        DateTime? goalEndDate = null;

                        if (input.ToLower() == "yes")
                        {
                            Console.WriteLine($"Type end date for this goal? example MM/dd/yy");
                            goalEndDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yy", null);
                        }
                     
                        // ask for goal name
                        Console.Write("what is the name of your goal?: ");
                        string goalName = Console.ReadLine();

                        // ask for a description of the goal
                        Console.Write("What is a short description of it?: ");
                        string goalDescription = Console.ReadLine();

                        // ask how many points is it worth once completed
                        Console.Write("What is the amount of points associated with this goal?: ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        // Create the goal based on the user's input
                        DateTime actualGoalEndDate = goalEndDate ?? DateTime.MinValue;
                        Goal goal = new SimpleGoal(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints);

                        goal.Addgoals(goal); // Add the new goal to the goal class list
                        Console.WriteLine("Goal added successfully!");

                    }

                    else if (goalType == 2)
                    {
                        //fetch the current date and display it as the start date.
                        DateTime goalStartDate = DateTime.Today;
                        Console.WriteLine($"This new goal will begin today {goalStartDate}");
    
                        DateTime? goalEndDate = null; // give a null this goal has no end date.
    
                        // ask for goal name
                        Console.Write("what is the name of your goal?: ");
                        string goalName = Console.ReadLine();
    
                        // ask for a description of the goal
                        Console.Write("What is a short description of it?: ");
                        string goalDescription = Console.ReadLine();
    
                        // ask how many points is it worth once completed
                        Console.Write("What is the amount of points associated with     this goal?: ");
                        int goalPoints = int.Parse(Console.ReadLine());
    
                        // Create the goal based on the user's input
                        Goal goal = new EternalGoal(goalStartDate, goalEndDate,  goalType, goalName, goalDescription, goalPoints);
    
                        goal.Addgoals(goal); // Add the new goal to the goal class list
                        Console.WriteLine("Goal added successfully!");
                    }

                    else if (goalType == 3)
                    {
                         //fetch the current date and display it as the start date.
                        DateTime goalStartDate = DateTime.Today;
                        Console.WriteLine($"This new goal will begin today  {goalStartDate}");
    
                        DateTime? goalEndDate = null; // give a null this goal has no end date.
    
                        // ask for goal name
                        Console.Write("what is the name of your goal?: ");
                        string goalName = Console.ReadLine();
    
                        // ask for a description of the goal
                        Console.Write("What is a short description of it?: ");
                        string goalDescription = Console.ReadLine();
    
                        // ask how many points is it worth once completed
                        Console.Write("What is the amount of points associated with this goal?: ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                        int targetCount = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times?: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
    
                        // Create the goal based on the user's input
                        Goal goal = new ChecklistGoal(goalStartDate, goalEndDate,  goalType, goalName, goalDescription, goalPoints, targetCount, bonusPoints);
    

                        goal.Addgoals(goal); // Add the new goal to the goal class list
                        Console.WriteLine("Goal added successfully!");

                    }
                        
                    break;

                case "2":
                    //List All of the current goals.
                    Console.WriteLine("The current Goals are:");
                    Goal.ListGoals();
                    break;

                case "3":
                    //Save goals.
                    //foreach (var goal in Goal.ReturnGoals())
                    //{
                    //    FileHandler.SaveGoal(goal.GetGoalStartDate(), goal.GetGoalEndDate, goal.//GetGoalType(), goal.GetGoalName(), goal.GetGoalDescription(), goal.GetGoalPoints//(), goal.bonusPoints(), goal.targetCount, goal.currentCount);
                    //}
                    break;

                case "4":
                    //Load goals
                    FileHandler.LoadGoal();
                    break;

                case "5":
                // Display the list of goals
                Console.WriteLine("Select a goal to record an event for:");
                List<Goal> goals = Goal.ReturnGoals();
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetGoalName()}");
                }

                Console.Write("Enter the number of the goal: ");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;

                if (goalIndex >= 0 && goalIndex < goals.Count)
                {
                    Goal selectedGoal = goals[goalIndex];
                    selectedGoal.RecordEvent();
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