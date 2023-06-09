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
        
        // Will return how long the activity will run in (seconds).
        return duration;
    }

    // Reset the activity start and end times to nothing
    protected void ActivityResetTime (int time)
    {

    }
    
    // Pause the activity for a requested duration of time
    protected void ActivityPauseTime (int time)
    {
        int seconds = (time / 1000);

        DateTime pauseEndTime = DateTime.Now.AddMilliseconds(time);

        while (DateTime.Now < pauseEndTime)
        {
            Console.WriteLine($"Pausing for {seconds} seconds...");
            Thread.Sleep(1000); // Pause for 1 second
            seconds--;
        }

    }

}