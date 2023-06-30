using System;
using System.Collections.Generic;
using System.IO;

class FileHandler
{
    public static void SaveGoal(DateTime goalStartDate, DateTime? goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints, int bonusPoints, int targetCount, int currentCount, int? totalScore = null)
    {
        Console.Write("What is the filename for the goal file?:");
        string filename = Console.ReadLine();

        string line = $"{goalStartDate},{goalEndDate},{goalType},{goalName},{goalDescription},{goalPoints},{bonusPoints},{targetCount},{currentCount}";

        if (totalScore.HasValue)
        {
            line += $",{totalScore}";
        }

        try
        {
            File.AppendAllText(filename, line + Environment.NewLine);
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

                if (parts.Length >= 6 && parts.Length <= 9)
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

                    int goalType = int.Parse(parts[2]);
                    string goalName = parts[3];
                    string goalDescription = parts[4];
                    int goalPoints = int.Parse(parts[5]);

                    if (parts.Length >= 7 && parts.Length <= 9)
                    {
                        int targetCount = int.Parse(parts[6]);

                        if (parts.Length == 9)
                        {
                            int bonusPoints = int.Parse(parts[7]);
                            int currentCount = int.Parse(parts[8]);

                            Goal goalInstance = new Goal(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints, bonusPoints, targetCount, currentCount);
                            // Assuming Addgoals() is defined and accessible in the Program class
                            goalInstance.Addgoals(goalInstance);
                        }
                        else
                        {
                            Goal goalInstance = new Goal(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints);
                            // Assuming Addgoals() is defined and accessible in the Program class
                            goalInstance.Addgoals(goalInstance);
                        }
                    }
                    else
                    {
                        Goal goalInstance = new Goal(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints);
                        // Assuming Addgoals() is defined and accessible in the Program class
                        goalInstance.Addgoals(goalInstance);
                    }
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



    //public static void LoadGoal()
    //{
    //    string filename = "Goals.txt";

    //    try
    //    {
    //        string[] lines = File.ReadAllLines(filename);

    //        foreach (string line in lines)
    //        {
    //            string[] parts = line.Split(",");

    //            if () // if this line has only 0-5 parts do this:
    //            {
    //                DateTime goalStartDate = DateTime.Parse(parts[0]);
    //                DateTime? goalEndDate = DateTime.Parse(parts[1]);
    //                int goalType = int.Parse(parts[2]);
    //                string goalName = parts[3];
    //                string goalDescription = parts[4];
    //                int goalPoints = int.Parse(parts[5])
    //                // Assuming Addgoals() is defined and accessible in the Program class
    //                Goal goalInstance = new Goal(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints)
    //                goalInstance.Addgoals(goalInstance);
    //            
    //            else if ()  //if this line has 0-7 parts in that line do this
    //            {
    //                DateTime goalStartDate = DateTime.Parse(parts[0]);
    //                DateTime? goalEndDate = DateTime.Parse(parts[1]);
    //                int goalType = int.Parse(parts[2]);
    //                string goalName = parts[3];
    //                string goalDescription = parts[4];
    //                int goalPoints = int.Parse(parts[5]);
    //                int targetCount = int.Parse(parts[6]);
    //                int bonusPoints = int.Parse(parts[7])
    //                // Assuming Addgoals() is defined and accessible in the Program class
    //                Goal goalInstance = new Goal(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints, targetCount, bonusPoints)
    //                goalInstance.Addgoals(goalInstance);
    //            }
    //        
    //        }

    //        Console.WriteLine("Goals loaded successfully!");
    //    }
    //    catch (IOException e)
    //    {
    //        Console.WriteLine($"An error occurred while loading the goals: {e.Message}");
    //    }
    //    catch (UnauthorizedAccessException e)
    //    {
    //        Console.WriteLine($"You don't have permission to access the file: {e.Message}");
    //    }
    //}

}