using System;

class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(string name, int points) : base(name)
    {
        _points = points;
    }

    public override int CalculatePoints()
    {
        // Calculate points for a simple goal
        if (_completed)
        {
            return _points;
        }
        return 0;
    }
}