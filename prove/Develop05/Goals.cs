using System;
using System.Collections.Generic;

class Goal
{   
    protected int _points;
    protected Boolean _completed;
    protected string _name;
    protected List<string> _goals;

  
    
    protected Goal(string name)
    {
        _name = name;
        _completed = false;
        _points = 0;
        _goals = new List<string>();
    }

    protected string GetName()
    {
        return _name;
    }


    protected bool IsGoalComplete()
    {
        return _completed;
    }

    public int GetPoints()
    {
        return _points;
    }

    protected void SetCompleted(bool completed)
    {
        _completed = completed;
    }
    protected virtual int CalculatePoints()
    {
        return 0;
    }
    protected void RecordEvent()
    {
        // logic to record an event for the goal
    }
    protected int GetTotalScore()
    {
        // implement logic for getting total score.
        return 0;
    }
    protected void ListGoals()
    {
        // put logic to list goals
    }

}