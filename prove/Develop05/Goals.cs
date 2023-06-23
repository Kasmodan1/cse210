using System;
using System.Collections.Generic;

class Goal
{   

    protected bool _completed;
    protected string _name;
    
    public Goal(string name)
    {
        _name = name;
        _completed = false;
    }

    protected string GetName()
    {
        return _name;
    }

    protected bool IsGoalComplete()
    {
        return _completed;
    }

    public virtual int CalculatePoints()
    {
        // Base implementation for calculating points
        return 0;
    }

    public virtual void RecordEvent()
    {
        // Base implementation for recording an event
    }

    public virtual void ListGoalDetails()
    {
        // Base implementation for listing goal details
    }
}