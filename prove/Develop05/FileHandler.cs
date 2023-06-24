using System;
using System.Collections.Generic;
using System.IO;

class FileHandler
{
    //    public void SaveGoal(DateTime date, int goalType, string goalName, string goalDescription, string goalData)
    //{
    //    string filename = "Goals.txt";

    //    using (StreamWriter outputFile = new StreamWriter(filename, true))
    //    {
    //        outputFile.WriteLine($"{date}|{goalType}|{goalName}|{goalDescription}|{goalData}");
    //    }
    //}
    public static void SaveGoal(DateTime goaStartDate, DateTime goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints)
    {
        string filename = "Goals.txt";
        string line = $"{goaStartDate}|{goalEndDate}|{goalType}|{goalName}|{goalDescription}|{goalPoints}";

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

    //public void LoadGoal()
    //{
    //    //creates the file
    //    string filename = "Goals.txt";
    //    string[] lines = System.IO.File.ReadAllLines(filename);

    //    // loop though each line item and mapping the parts.
    //    foreach (string line in lines)
    //    {
    //        string[] parts = line.Split("|");

    //        DateTime date = DateTime.Parse(parts[0]);
    //        int goalType = int.Parse(parts[1]);
    //        string goalName = parts[2];
    //        string goalDescription = parts[3];
    //        string goalData = parts[4];

    //        // using the Goal class to map it back to date,goaltype, goalname, goal response, goaldata
    //        Goal entry = new Goal(date, goalType, goalName, goalDescription, goalData);

    //        // This should add it back into the goal list.
    //        Addgoals(entry);
    //    }

    //}

    public static void LoadGoal()
    {
        string filename = "Goals.txt";

        try
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                DateTime goalStartDate = DateTime.Parse(parts[0]);
                DateTime goalEndDate = DateTime.Parse(parts[1]);
                int goalType = int.Parse(parts[2]);
                string goalName = parts[3];
                string goalDescription = parts[4];
                int goalPoints = int.Parse(parts[5]);

                // Assuming Addgoals() is defined and accessible in the Program class
                Goal goalInstance = new Goal(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints);

                goalInstance.Addgoals(goalInstance);
            
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