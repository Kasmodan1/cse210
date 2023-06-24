using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _pointsPerEvent;
    private int _bonusPoints;

    public ChecklistGoal(string name, int targetCount, int pointsPerEvent, int bonusPoints) : base(name)
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
        Console.WriteLine($"Completed: {_currentCount}/{_targetCount}");
    }
}