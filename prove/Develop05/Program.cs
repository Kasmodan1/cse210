using System;
using System.Threading;
using System.Collections.Generic;


//Added Rank Class that is based on total Points. (gameification)
//Added Start Dates so users would know when they started there goal.
//Also added end Dates so the users would know when they needed to complete the goal by.(this was not enforced if they didn't. Was going to develope that but ran out of time)
//Added Displays Rank info before total Points and gives progress toward next posable level.
//Added error handling on menu selection and saving and loading incase there is an error.

class Program
{
    static void Main(string[] args)
    {


 
        bool exit = false;

        while (!exit)
        {
        
            Console.WriteLine(" ");
            Rank.CheckRank();
            Rank.DisplayProgress();
            Console.WriteLine($"You have {Goal.GetTotalScore()} Total Points");
    
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

                        bool goalCompleted = false;
                        int totalScore = 0;

                        // Create the goal based on the user's input
                        DateTime actualGoalEndDate = goalEndDate ?? DateTime.MinValue;
                        Goal goal = new SimpleGoal(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, totalScore);

                        goal.Addgoals(goal); // Add the new goal to the goal class list
                        Console.WriteLine("Goal added successfully!");

                    }

                    else if (goalType == 2)
                    {
                        //fetch the current date and display it as the start date.
                        DateTime goalStartDate = DateTime.Today;
                        string formattedStartDate = goalStartDate.ToString("MM/dd/yy");
                        Console.WriteLine($"This new goal will begin today {formattedStartDate}");
    
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

                        int currentCount = 0;
                        bool goalCompleted = false;
                        int totalScore = 0;
    
                        // Create the goal based on the user's input
                        Goal goal = new EternalGoal(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, currentCount, totalScore);
    
                        goal.Addgoals(goal); // Add the new goal to the goal class list
                        Console.WriteLine("Goal added successfully!");
                    }

                    else if (goalType == 3)
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

                        Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                        int targetCount = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times?: ");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        int currentCount = 0;
                        bool goalCompleted = false;
                        int totalScore = 0;
    
                        // Create the goal based on the user's input
                        Goal goal = new ChecklistGoal(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, bonusPoints, targetCount, currentCount, totalScore);
    

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
                    // Save goals.
                    List<Goal> goals = Goal.ReturnGoals();
                    foreach (var Goal in goals)
                    {
                        DateTime goalStartDate = Goal.GetGoalStartDate();
                        DateTime? goalEndDate = Goal.GetGoalEndDate();
                        bool goalCompleted = Goal.IsCompleted();
                        int goaltype = Goal.GetGoalType();
                        string goalName = Goal.GetGoalName();
                        string goalDescription = Goal.GetGoalDescription();
                        int goalPoints = Goal.GetGoalPoints();
                        int bonusPoints = Goal.GetBonusPoints();
                        int targetCount = Goal.GetTargetCount();
                        int currentCount = Goal.GetCurrentCount();
                        int totalScore = Goal.GetTotalScore();

                        FileHandler.SaveGoal(goalStartDate, goalEndDate, goalCompleted, goaltype, goalName, goalDescription, goalPoints, bonusPoints, targetCount, currentCount, totalScore);
                    }
                    break;


                case "4":
                    //Load goals
                    Console.Write("What is the name of the file to load?: ");
                    string filename = Console.ReadLine();
                    FileHandler.LoadGoal(filename);
                    break;

                case "5":
                    // record an event for a goal
                    List<Goal> goalList = Goal.ReturnGoals();
                    List<Goal> activeGoals = goalList.Where(goal => !goal.IsCompleted()).ToList();
                    for (int i = 0; i < activeGoals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {activeGoals[i].GetGoalName()}");
                    }
    
                    Console.Write("Enter the number of the goal: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
    
                    if (goalIndex >= 0 && goalIndex < activeGoals.Count)
                    {
                        Goal selectedGoal = activeGoals[goalIndex];
                        selectedGoal.RecordEvent();
                        selectedGoal.CalculatePoints();
        
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