using System;

class SimpleGoal : Goal
{
    private int _simpleGoalPoints;

    public SimpleGoal(int goalType, string goalName, string goalDescription, int goalPoints)
    : base(goalType, goalName, goalDescription, goalPoints)
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