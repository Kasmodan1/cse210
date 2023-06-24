using System;

class EternalGoal : Goal
{
    private int _points;

    public EternalGoal(string name, int points) : base(name)
    {
        _points = points;
    }

    public override int CalculatePoints()
    {
        // Calculate points for an eternal goal
        return _points;
    }
}