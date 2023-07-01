using System;

class EternalGoal : Goal
{
    private int _eternalGoalPoints;
    private int _eternalCount;

    public EternalGoal(DateTime goalStartDate, DateTime? goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints, int currentCount)
    : base(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints, currentCount)
    {
        _eternalGoalPoints = goalPoints;
        _eternalCount = currentCount;
    }

    public override int CalculatePoints()
    {
        // Check if the goal is a Eternal goal
        if (this.GetType() == typeof(EternalGoal))
        {
            // Find the EternalGoal in the goalsList and return the eternalGoalPoints
            foreach (Goal goal in Goal.ReturnGoals())
            {
                if (goal.GetType() == typeof(EternalGoal) && goal.GetGoalName() == this.GetGoalName())
                {
                    int eternalGoalPoints = ((EternalGoal)goal)._eternalGoalPoints;
                    SetTotalScore(GetTotalScore() + eternalGoalPoints); // Update the totalScore by adding the eternalGoalPoints
                    return eternalGoalPoints;
                }
            }
        }
        return 0;

    }

   public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for the goal: {GetGoalName()}"); // Display a message indicating the event is recorded
        _eternalCount++;
        SetCurrentCount(_eternalCount); // Update the goal's current count in the goalList
    
    }

        public override void ListGoalDetails()
    {
        string status = IsGoalComplete(); // Determine the status of the goal

        Console.Write($"{status} ");
        Console.Write($"{GetGoalName()} ");
        Console.Write($"({GetGoalDescription()}) ");
        Console.Write($"Points: {GetGoalPoints()} ");
        Console.Write($"Eternal Count: {GetCurrentCount}"); // Display the eternal count
    }
    
}