using System;

class SimpleGoal : Goal
{
    private static List<SimpleGoal> _simpleGoals = new List<SimpleGoal>();
    private int _simpleGoalPoints;

    public SimpleGoal(DateTime goalStartDate, DateTime? goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints)
    : base(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints)
    {
        _simpleGoalPoints = goalPoints;
        _simpleGoals.Add(this); // Add the current instance to the list of SimpleGoals
    }

    public override int CalculatePoints()
    {
        if (_completed)
        {
            // Check if the goal is a SimpleGoal
            if (this.GetType() == typeof(SimpleGoal))
            {
                // Find the SimpleGoal in the goalsList and return the simpleGoalPoints
                foreach (Goal goal in Goal.ReturnGoals())
                {
                    if (goal.GetType() == typeof(SimpleGoal) && goal.GetGoalName() == this.GetGoalName())
                    {
                        int simpleGoalPoints = ((SimpleGoal)goal)._simpleGoalPoints;
                        SetTotalScore(GetTotalScore() + simpleGoalPoints); // Update the totalScore by adding the simpleGoalPoints
                        return simpleGoalPoints;
                    }
                }
            }
        }
        return 0;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for the goal: {GetGoalName()}"); // Display a message indicating the event is recorded
        _completed = true; // Mark the goal as completed
    
    }

    public override void ListGoalDetails()
    {
        string status = IsGoalComplete(); // Determine the status of the goal

        Console.Write($"{status} ");
        Console.Write($"{GetGoalName()} ");
        Console.Write($"({GetGoalDescription()}) ");
        Console.Write($"Points: {GetGoalPoints()} ");
    }
    
    public static List<SimpleGoal> GetSimpleGoals()
    {
        return _simpleGoals;
    }
    public static new void ListGoals()
    {
        List<Goal> goalsList = Goal.ReturnGoals(); // Get the list of goals from the Goals class

        foreach (Goal goal in goalsList)
        {
            if (goal.GetType() == typeof(SimpleGoal)) // Check if the goal is of type SimpleGoal
            {
                goal.ListGoalDetails(); // Invoke the ListGoalDetails method of the goal instance
                Console.WriteLine();
            }
        }
    }
}