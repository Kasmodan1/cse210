using System;


class ScoreRecorder
{
    private int _score;

    public ScoreRecorder()
    {
        _score = 0;
    }

    //public void RecordEventForGoal(string goalName)
    //
    //   Goal goal = _goals.Find(g => g.GetGoalName() == goalName);
    //   if (goal != null)
    //   {
    //       goal.RecordEvent();
    //       _score += goal.CalculatePoints();
    //   }
    //

    public int GetScore()
    {
        return _score;
    }
}