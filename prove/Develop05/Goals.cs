using System;
using System.Collections.Generic;

class Goal
{   

    protected bool _completed;
    protected string _name;
    protected string _type;
    protected string _description;
    protected string _data;

    
    public Goal(string goalname, string goaltype, string goaldescription, string goaldata)
    {
        _name = goalname;
        _completed = false;
        _type = goaltype;
        _description = goaldescription;
        _data = goaldata;
    }

    public string GetGoalName()
    {
        return _name;
    }

    protected void SetGoalName(string goalname)
    {
        _name = goalname;
    }

    public string GetGoalType()
    {
        return _type;
    }

    protected void SetGoalType(string goaltype)
    {
        _type = goaltype;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    protected void SetGoalDescription(string goaldescription)
    {
        _description = goaldescription;
    }

    public string GetGoalData()
    {
        return _data;
    }

    protected void SetGoalData(string goaldata)
    {
        _data = goaldata;
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
        _completed = true;
        // Base implementation for recording an event
    }

    public virtual void ListGoalDetails()
    {
        Console.WriteLine($"Goal: {_name}");
        Console.WriteLine($"Completed: {_completed}");
        // Base implementation for listing goal details
    }
}