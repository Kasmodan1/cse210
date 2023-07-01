using System;
using System.Collections.Generic;

class Goal
{   

    protected bool _completed;
    protected string _name;
    protected int _type;
    protected string _description;
    protected static List<Goal> goalsList = new List<Goal>();
    protected int _goalpoints;
    protected static int _totalScore;
    protected DateTime _goalstartdate;
    protected DateTime? _goalenddate;
    protected int _bonuspoints;
    protected int _targetcount;
    protected int _currentcount;
   

    
    public Goal(DateTime goalStartDate, DateTime? goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints)
    {
        _goalstartdate = goalStartDate;
        _goalenddate = goalEndDate;
        _completed = false;
        _type = goalType;
        _name = goalName;
        _description = goalDescription;
        _goalpoints = goalPoints;
    
    }

    public Goal(DateTime goalStartDate, DateTime? goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints, int bonusPoints, int targetCount, int currentCount)
    {
        _goalstartdate = goalStartDate;
        _goalenddate = goalEndDate;
        _completed = false;
        _type = goalType;
        _name = goalName;
        _description = goalDescription;
        _goalpoints = goalPoints;
        _bonuspoints = bonusPoints;
        _targetcount = targetCount;
        _currentcount = currentCount;
    }

    public Goal(DateTime goalStartDate, DateTime? goalEndDate, int goalType, string goalName, string goalDescription, int goalPoints, int goalCurrentCount)
    {
        _goalstartdate = goalStartDate;
        _goalenddate = goalEndDate;
        _type = goalType;
        _name = goalName;
        _description = goalDescription;
        _goalpoints = goalPoints;
        _currentcount = goalCurrentCount;
    }

    public Goal(DateTime goalStartDate, DateTime? goalEndDate,bool goalCompleted, int goalType, string goalName, string goalDescription, int goalPoints, int bonusPoints, int targetCount, int currentCount, int totalScore)
    {
        _goalstartdate = goalStartDate;
        _goalenddate = goalEndDate;
        _completed = goalCompleted;
        _type = goalType;
        _name = goalName;
        _description = goalDescription;
        _goalpoints = goalPoints;
        _bonuspoints = bonusPoints;
        _targetcount = targetCount;
        _currentcount = currentCount;
        _totalScore = totalScore;
    }



    public void Addgoals(Goal goal)
    {
        goalsList.Add(goal);
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

    protected void SetGoalPoints(int goalPoints)
    {
        _goalpoints= goalPoints;
    }

    public static int GetTotalScore()
    {
        return _totalScore;
    }

    protected void SetTotalScore(int totalScore)
    {
        _totalScore = totalScore;
    }

    public DateTime GetGoalStartDate()
    {
        return _goalstartdate;
    }

    protected void SetGoalStartDate(DateTime goalStartDate)
    {
        _goalstartdate = goalStartDate;
    }

    public DateTime? GetGoalEndDate()
    {
        return _goalenddate;
    }

    protected void SetGoalEndDate(DateTime? goalEndDate)
    {
        _goalenddate = goalEndDate;
    }

    public int GetBonusPoints()
    {
        return _bonuspoints;
    }

    public int GetTargetCount()
    {
        return _targetcount;
    }

    public int GetCurrentCount()
    {
        return _currentcount;
    }

    protected void SetCurrentCount(int currentCount)
    {
        _currentcount = currentCount;
    }

    protected string IsGoalComplete()
    {
        if (_completed)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }

    }

    public bool IsCompleted()
    {
        return _completed;
    }
    
    public static List<Goal> ReturnGoals()
    {
       return goalsList;
    
    }

    public static void ListGoals()
    {
        foreach (Goal goal in goalsList)
        {
            goal.ListGoalDetails();
            Console.WriteLine();
        }
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