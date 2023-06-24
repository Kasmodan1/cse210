using System;
using System.Collections.Generic;

class Goal
{   

    protected bool _completed;
    protected string _name;
    protected int _type;
    protected string _description;
    protected List<Goal> goalsList;
    protected int _goalpoints;
    protected DateTime _goalstartdate;
    protected DateTime _goalenddate;
   

    
    public Goal(DateTime goalStartDate, DateTime goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints)
    {
        _goalstartdate = goalStartDate;
        _goalenddate = goalEndDate;
        _completed = false;
        _type = goalType;
        _name = goalName;
        _description = goalDescription;
        _goalpoints = goalPoints;
        goalsList = new List<Goal>();
    
    }

    public static void Addgoals(Goal goal, List<Goal> goalsList)
    {
        goalsList.Add(goal);
        Console.WriteLine("Goal added successfully!");
    }

    public string GetGoalName()
    {
        return _name;
    }

    protected void SetGoalName(string goalname)
    {
        _name = goalname;
    }

    public int GetGoalType()
    {
        return _type;
    }

    protected void SetGoalType(int goaltype)
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

    public int GetGoalPoints()
    {
        return _goalpoints;
    }

    protected void SetGoalData(int goalPoints)
    {
        _goalpoints= goalPoints;
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