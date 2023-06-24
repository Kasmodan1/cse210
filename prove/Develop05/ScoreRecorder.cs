using System;

class ScoreRecorder
{
    private int _score;
    private List<Goal> _goals;

    public ScoreRecorder()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEventForGoal(string goalName)
    {
        Goal goal = _goals.Find(g => g.GetName() == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.CalculatePoints();
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.ListGoalDetails();
            Console.WriteLine();
        }
    }
}