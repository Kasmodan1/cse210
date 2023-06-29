using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _pointsPerEvent;
    private int _bonusPoints;

    public ChecklistGoal(int goalType, string goalName, string goalDescription, int goalPoints, int targetCount, int pointsPerEvent, int bonusPoints)
    : base(goalType, goalName, goalDescription, goalPoints)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _pointsPerEvent = pointsPerEvent;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        // Record an event for the checklist goal
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _completed = true;
        }
    }

    public override int CalculatePoints()
    {
        // Calculate points for a checklist goal
        int points = _pointsPerEvent * _currentCount;
        if (_completed)
        {
            points += _bonusPoints;
        }
        return points;
    }

    public override void ListGoalDetails()
    {
        // List goal details for a checklist goal
        Console.WriteLine($"Checklist Goal: {_name}");
        Console.WriteLine($"Completed: {_completed}");
        Console.WriteLine($"Current Count: {_currentCount}/{_targetCount}");
    }
}