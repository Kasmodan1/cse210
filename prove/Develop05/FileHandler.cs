using System;
using System.Collections.Generic;
using System.IO;

class FileHandler
{
     private static string goalFileName; // Variable to store the filename

    public static void SaveGoal(DateTime goalStartDate, DateTime? goalEndDate, bool goalCompleted, int goalType, string goalName, string goalDescription, int goalPoints, int bonusPoints, int targetCount, int currentCount, int? totalScore = null)
    {
        // Check if the filename is already set, if not, ask the user for the filename
        if (string.IsNullOrEmpty(goalFileName))
        {
            Console.Write("What is the filename for the goal file?: ");
            goalFileName = Console.ReadLine();
        }

        string line = $"{goalStartDate},{goalEndDate},{goalCompleted},{goalType},{goalName},{goalDescription},{goalPoints},{bonusPoints},{targetCount},{currentCount}";

        if (totalScore.HasValue)
        {
            line += $",{totalScore}";
        }

        try
        {
            File.AppendAllText(goalFileName, line + Environment.NewLine);
            Console.WriteLine("Goal saved successfully!");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while saving the goal: {e.Message}");
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine($"You don't have permission to access the file: {e.Message}");
        }
    }
        
    public static void LoadGoal(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                if (parts.Length == 11)
                {
                    DateTime.TryParse(parts[0], out DateTime goalStartDate);
                    DateTime? goalEndDate;
                    DateTime endDateValue;

                    if (DateTime.TryParse(parts[1], out endDateValue))
                    {
                        goalEndDate = endDateValue;
                    }
                    else
                    {
                        goalEndDate = null;
                    }
                    bool goalCompleted = bool.Parse(parts[2]);
                    int goalType = int.Parse(parts[3]);
                    string goalName = parts[4];
                    string goalDescription = parts[5];
                    int goalPoints = int.Parse(parts[6]);
                    int targetCount = int.Parse(parts[7]);
                    int bonusPoints = int.Parse(parts[8]);
                    int currentCount = int.Parse(parts[9]);
                    int totalScore = int.Parse(parts[10]);

                    Goal goalInstance;

                    // Create child class instances based on goal type
                    switch (goalType)
                    {
                        case 1:
                            goalInstance = new SimpleGoal(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, totalScore);
                            break;
                        case 2:
                            goalInstance = new EternalGoal(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, currentCount, totalScore);
                            break;
                        case 3:
                            goalInstance = new ChecklistGoal(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, bonusPoints, targetCount, currentCount, totalScore);
                            break;
                        // Add cases for other goal types if applicable
                        default:
                            goalInstance = new Goal(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, bonusPoints, targetCount, currentCount, totalScore);
                            break;
                    }

                    goalInstance.Addgoals(goalInstance);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while loading the goals: {e.Message}");
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine($"You don't have permission to access the file: {e.Message}");
        }
    }
}