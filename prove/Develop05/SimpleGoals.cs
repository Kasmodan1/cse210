using System;

class SimpleGoal : Goal
{
    private int _simpleGoalPoints;

    public SimpleGoal(DateTime goalStartDate, DateTime goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints)
    : base(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints)
    {
        _simpleGoalPoints = goalPoints;
    }

    public override int CalculatePoints()
    {
        // Calculate points for a simple goal
        if (_completed)
        {
            return _simpleGoalPoints;
        }
        return 0;
    }

    public override void RecordEvent()
    {
        base.RecordEvent(); 
    }

    public override void ListGoalDetails()
    {
        base.ListGoalDetails(); 
    }
}