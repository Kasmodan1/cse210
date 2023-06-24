using System;

class EternalGoal : Goal
{
    private int _points;
    private int _eventCount;

    public EternalGoal(string name, int points) : base(name)
    {
        _points = points;
        _eventCount = 0;
    }

    public override int CalculatePoints()
    {
        return _points * _eventCount;
    }

    public override void RecordEvent()
    {
        _eventCount++;
    }
}