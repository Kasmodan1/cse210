using System;

class EternalGoal : Goal
{
    private int _eternalGoalPoints;
    private int _eventCount;

    public EternalGoal(DateTime goalStartDate, DateTime goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints)
    : base(goalStartDate, goalEndDate, goalType, goalName, goalDescription, goalPoints)
    {
        _eternalGoalPoints = goalPoints;
        _eventCount = 0;
    }

    public override int CalculatePoints()
    {
        return _eternalGoalPoints * _eventCount;
    }

    public override void RecordEvent()
    {
        _eventCount++;
    }
}