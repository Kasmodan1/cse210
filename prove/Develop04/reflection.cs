using System;
using System.Threading;
using System.Linq;

class Reflection : Activity
{  
    
    private List<string> _reflectionPrompts;
    private List<string> _reflectionQuestions;
    private Random _random;

    public Reflection()
    {
        _reflectionPrompts = new List<string>();
        _reflectionQuestions = new List<string>();
        _random = new Random();
        InitializePrompts();
        InitializeQuestions();
    }

    private void InitializePrompts()
    {
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
    }

    private void InitializeQuestions()
    {
        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }

    private string GetReflectionItem(List<string> itemList)
    {

        int count = itemList.Count;

        if (count == 0)
        {
            return null;
        }
        int randomIndex = _random.Next(count);
        string  selectedItem = itemList[randomIndex];
        return selectedItem;
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

        //clear terminal
        Console.Clear();

        base.DisplayMsg("Get ready...You will begin by reflecting on thought provoking questions.");

        base.ActivityPause(8);

        Console.Clear();

        base.DisplayMsg("Consider the following prompt:", " ");

        bool continueReflection = true;

        while(continueReflection)
        {

            string selectedPrompt = GetReflectionItem(_reflectionPrompts);

            if (selectedPrompt != null)
            {
                base.DisplayMsg(selectedPrompt, " ");
            }

            base.DisplayMsg("When you have something in mind, press enter to continue.", " ");

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(intercept: true);
            } while (keyInfo.Key != ConsoleKey.Enter);

            continueReflection = false;
        }

        base.DisplayMsg("Now ponder on each of the following questions as they relate to this experience", " ");
        
        base.ActivityCountTime(5, "You may begin in: {0}");

        Console.Clear();

        base.ActivityResetTime(true);

        // use this tuple for duration
        var (startTime, endTime, duration) = base.ActivityDuration(seconds);

        while(startTime < endTime)
        {    
            if (startTime <= endTime)
            {

                string selectedQuestions = GetReflectionItem(_reflectionQuestions);

                if (selectedQuestions != null)
                {
                    base.DisplayMsg(selectedQuestions);
                }

                base.ActivityCountTime(10, " {0}");
            }
            startTime = DateTime.Now;

        }

        base.DisplayMsg("Well done!!");

        base.ActivityResetTime(true);

        base.DisplayMsg($"You have completed another {seconds} seconds of Reflection Activity."); 

        base.ActivityPause(5);
        

    }

}