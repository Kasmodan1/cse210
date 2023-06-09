using System;

class Activity
{
    protected DateTime _startTime;
    protected DateTime _endTime;
    protected TimeSpan _duration;

    // -- Functions --
    // This function displays the activity message.
    
    public void DisplayMsg(params string[] strings)
    {
        foreach (string message in strings)
        {
            Console.WriteLine(message);
        }
    }

    public TimeSpan ActivityDuration(int seconds)
    {
        DateTime _startTime = DateTime.Now;

        DateTime _endTime = _startTime.AddSeconds(seconds);

        TimeSpan duration = _endTime - _startTime;
        
        // Will return how long the activity will run in (seconds).
        return duration;
    }

    // Reset the activity start and end times to nothing
    public void ActivityResetTime (bool resetTime)
    {
        if (resetTime)
        {
            //set the time and DateTime back to start values.
            _startTime = DateTime.MinValue;
            _endTime = DateTime.MinValue;
            _duration = TimeSpan.Zero;
   
        } 

    }
    
    // Pause the activity for a requested duration of time.
    public void ActivityPauseTime (int seconds)
    {
        DateTime pauseEndTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < pauseEndTime)
        {
            if (seconds < 10)
            {
                Console.Write($"\rPausing for {seconds} seconds...");
                Thread.Sleep(1000); // Pause for 1 second
                seconds--;
            }

            else if (seconds >= 10)
            {
                Console.WriteLine($"\rPausing for {seconds} seconds...");
                Thread.Sleep(1000); // Pause for 1 second
                seconds--;
            }

            else if (seconds >= 100)
            {
                Console.WriteLine($"\rPausing for {seconds} seconds...");
                Thread.Sleep(1000); // Pause for 1 second
                seconds--;
            }

        }

    }

}