using System;
using System.Threading;

class Activity
{
    protected DateTime _startTime;
    protected DateTime _endTime;
    protected TimeSpan _duration;
    protected DateTime _pauseStart;
    protected DateTime _pauseEnd;
    protected DateTime _countTime;

    // -- Functions --
    // This function displays the activity message.
    
    public void DisplayMsg(params string[] strings)
    {
        foreach (string message in strings)
        {
            Console.WriteLine(message);
        }
    }

    //public TimeSpan ActivityDuration(int seconds)
    //{
    //    DateTime _startTime = DateTime.Now;
//
    //    DateTime _endTime = _startTime.AddSeconds(seconds);
//
    //    TimeSpan duration = _endTime - _startTime;
    //    
    //    // Will return how long the activity will run in (seconds).
    //    return duration;
    //
    //}

    public (DateTime startTime, DateTime endTime, TimeSpan duration) ActivityDuration(int seconds)
{
    this._startTime = DateTime.Now;

    this._endTime = this._startTime.AddSeconds(seconds);

    this._duration = this._endTime - this._startTime;
    
    // This will return all three if needed for activities.
    return (this._startTime, this._endTime, this._duration);
}


    // Reset the activity start and end times to nothing
    public void ActivityResetTime (bool resetTime)
    {
        if (resetTime)
        {
            //set the time and DateTime back to start values.
            this._startTime = DateTime.MinValue;
            this._endTime = DateTime.MinValue;
            this._duration = TimeSpan.Zero;
            this._startTime = DateTime.MinValue;
            this._endTime = DateTime.MinValue;
            this._duration = TimeSpan.Zero;
            this._pauseStart =DateTime.MinValue;
            this._pauseEnd =DateTime.MinValue;
            this._countTime = DateTime.MinValue;
   
        } 

    }
    
    // Pause the activity for a requested duration of time.
    public void ActivityCountTime (int seconds, string customMessage = null)
    {
        this._countTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < this._countTime)
        {
            string message = customMessage ?? $"Pausing for {seconds} seconds...";
            Console.Write($"\r{message}", seconds);
            Thread.Sleep(1000); // Pause for 1 second
            seconds--;

        }
        //This awesome nugget moves the cusser back and then it overwrites the line with spaces.
        Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
    }

     public void ActivityPause (int seconds)
    {
        this._pauseStart = DateTime.Now;
        this._pauseEnd = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < this._pauseEnd)
        {
            Console.Write($"\rPausing for {seconds} seconds...");
            Thread.Sleep(1000); // Pause for 1 second
            seconds--;
        }
        //This awesome nugget moves the cusser back and then it overwrites the line with spaces.
        Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
    }

}