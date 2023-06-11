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
        DateTime breathingEndTime = base._endTime;
        TimeSpan breathingDuration = base._duration;

        // Use Display from parent class
        base.DisplayMsg("Welcome to the Breathing Activity.", "This activity will help you relax by guiding you through breathing in and out slowly.","Clear your mind and focus on your breathing.", "How long, in seconds, would you like for your session?");

        int seconds = int.Parse(Console.ReadLine());

        base.ActivityDuration(seconds);

        // Use Display from parent class
        base.DisplayMsg("Welcome to the Breathing Activity.", "This activity will help you relax by guiding you through breathing in and out slowly.","Clear your mind and focus on your breathing.");

        Console.Clear();

        base.DisplayMsg("Get ready...You will begin to breath in and out Soon.");
        
        Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");

        base.ActivityPauseTime(5);

        base.ActivityPauseTime(2, "Now breath out...");



        
        
    } 

    
}