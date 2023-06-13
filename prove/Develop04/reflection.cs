using System;
using System.Threading;
using System.Linq;

class Reflection : Activity
{  
    
    private List<string> _reflectionPrompts;
    private List<string> _reflectionQuestions;
    private Random _random;

    private Reflection()
    {
        _reflectionPrompts = new List<string>();
        _random = new Random();
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");

    }
    private string GetReflectionPrompt()
    {

        int count = _reflectionPrompts.Count;

        if (count == 0)
        {
            return null;
        }
        int randomIndex = _random.Next(count);
        string  selectedPrompt = _reflectionPrompts[randomIndex];
        return selectedPrompt;
    }
    public void StartReflectionActivity()
    {
 
        base.DisplayMsg("Welcome to the Reflection Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "How long, in seconds, would you like for your session?");

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

        // use this tuple for duration
        var (startTime, endTime, duration) = base.ActivityDuration(seconds);

        //clear terminal
        Console.Clear();

        base.DisplayMsg("Get ready...You will begin by reflecting on thought provoking questions.");

        base.ActivityPause(8);

        Console.Clear();

        base.DisplayMsg("Consider the following prompt:");

        string selectedPrompt = GetReflectionPrompt();

        if (selectedPrompt != null)
        {
            Console.WriteLine(selectedPrompt);
        }


    }

}