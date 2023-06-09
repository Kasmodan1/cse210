using System;

class Activity
{
    protected DateTime _startTime;
    protected DateTime _endTime;
    protected TimeSpan _duration;

    // -- Functions --
    // This function displays the activity message.
    
    protected void DisplayMsg(params string[] strings)
    {
        foreach (string message in strings)
        {
            Console.WriteLine(message);
        }
    }



    protected TimeSpan ActivityDuration(int seconds)
    {
        DateTime _startTime = DateTime.Now;

        DateTime _endTime = _startTime.AddSeconds(seconds);

        TimeSpan duration = _endTime - _startTime;
        
        return duration;
    }


    public int ActivityClearTime ()
    {

    }
    
    public int ActivityPauseTime ()
    {

    }

}