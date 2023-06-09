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
        //set the time and DateTime back to start values.
        _startTime = DateTime.MinValue;
        _endTime = DateTime.MinValue;
        _duration = TimeSpan.Zero;

    }
    
    // Pause the activity for a requested duration of time.
    protected void ActivityPauseTime (int seconds)
    {
        DateTime pauseEndTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < pauseEndTime)
        {
            if (seconds < 10)
            {
                Console.WriteLine($"Pausing for {seconds} seconds...");
                Thread.Sleep(1000); // Pause for 1 second
                seconds--;
                Console.Write("\b \b");
            }
            
            else if (seconds >= 10)
            {
                Console.WriteLine($"Pausing for {seconds} seconds...");
                Thread.Sleep(1000); // Pause for 1 second
                seconds--;
                Console.Write("\b  \b");
            }

            else if (seconds >= 100)
            {
                Console.WriteLine($"Pausing for {seconds} seconds...");
                Thread.Sleep(1000); // Pause for 1 second
                seconds--;
                Console.Write("\b   \b"); 
            }

        }

    }

}