using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _pointsPerEvent;
    private int _bonusPoints;

    public ChecklistGoal(DateTime goalStartDate, DateTime? goalEndDate,bool goalCompleted, int goalType, string goalName, string goalDescription, int goalPoints, int bonusPoints, int targetCount, int currentCount, int totalScore)
    : base(goalStartDate, goalEndDate, goalCompleted, goalType, goalName, goalDescription, goalPoints, bonusPoints, targetCount, currentCount, totalScore)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _pointsPerEvent = goalPoints;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        // Record an event for the checklist goal
        _currentCount++;
        SetCurrentCount(_currentCount);
        if (_currentCount >= _targetCount)
        {
            SetCompleted(true);
        }
    }

    public override int CalculatePoints()
    {
        if (_completed == false)
        {   

            if (this.GetType() == typeof(ChecklistGoal))
            {
                // Find the ChecklistGoal in the goalsList and return the checklist points
                foreach (Goal goal in Goal.ReturnGoals())
                {
                    if (goal.GetType() == typeof(ChecklistGoal) && goal.GetGoalName() == this.  GetGoalName())
                    {
                        if (_currentCount <= _targetCount)
                        {
                            int checklistGoalPoints = ((ChecklistGoal)goal)._pointsPerEvent;
                            if (IsCompleted() == true)
                            {
                                checklistGoalPoints += _bonusPoints;
                            }
                            SetTotalScore(GetTotalScore() + checklistGoalPoints); // Update the totalScore  by adding the checklist goal points
                            Console.WriteLine($"You have gained {checklistGoalPoints}");

                            return checklistGoalPoints;
                        }
                    }
                }
            }
        }
        return 0;
    }

    public override void ListGoalDetails()
    {
        string status = IsGoalComplete(); // Determine the status of the goal

        Console.Write($"{status} ");
        Console.Write($"Start Date:{GetGoalStartDate().ToString("MM/dd/yy")} ");
        Console.Write($"End Date:{GetGoalEndDate()?.ToString("MM/dd/yy") ?? "N/A"} ");
        Console.Write($"{GetGoalName()} ");
        Console.Write($"({GetGoalDescription()}) ");
        Console.Write($"Points: {GetGoalPoints()} ");
        Console.Write($"Completed: {GetCurrentCount()}/{GetTargetCount()} times ");
    }
}