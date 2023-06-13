using System;
using System.Threading;

class Breathing : Activity
{  
    public void StartBreathingActivity()
    {


//1.The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
//2. The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
//3. After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
//4. After each message, the program should pause for several seconds and show a countdown.
//5. It should continue until it has reached the number of seconds the user specified for the duration.
//6. The activity should conclude with the standard finishing message for all activities.


        // Use Display from parent class
        base.DisplayMsg("Welcome to the Breathing Activity.", "This activity will help you relax by guiding you through breathing in and out slowly.","Clear your mind and focus on your breathing.", "How long, in seconds, would you like for your session?");

        int seconds;

        try
        {
            seconds = int.Parse(Console.ReadLine());
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer value.");

            return;
        }
        
        // use this tuple for act duration
        var (startTime, endTime, duration) = base.ActivityDuration(seconds);

        //clear terminal
        Console.Clear();

        base.DisplayMsg("Get ready...You will begin to breath in and out Soon.");

        base.ActivityPause(5);

        Console.Clear();

        while(startTime < endTime)
        {
        
            //Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");

            //DateTime pauseStart = base._pauseStart;
            //DateTime pauseEnd = base._pauseEnd;

            //TimeSpan pauseDuration = pauseEnd - pauseStart;
            //TimeSpan totalPauseDuration = pauseDuration;

            if (startTime + duration <= endTime)
            {
                base.ActivityCountTime(2, "Now breath in...{0}");

                base.ActivityCountTime(4, "Now breath out...{0}");
            }
               
            startTime = DateTime.Now;
        }
        base.DisplayMsg("Well done!!");

        base.ActivityResetTime(true);

        base.DisplayMsg($"You have completed another {seconds} seconds of Breathing Activity."); 

        base.ActivityPause(5);
        
    } 
 
}