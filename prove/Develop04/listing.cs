using System;
using System.Threading;
using System.Linq;

class Listing : Activity
{ 
    private List<string> _listingPrompts;
    private List<string> _listingItems;
    private Random _random;

    public Listing()
    {
        _listingPrompts = new List<string>();
        _listingItems = new List<string>();
        _random = new Random();
        InitializeListingPrompts();
    }

    private void InitializeListingPrompts()
    {
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");    
    }

    private string InitializeListingItems()
    {
        string input;
        Console.Write("> ");
        input = Console.ReadLine();

        return input;
    }
    
    private string GetListingItem(List<string> itemList)
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

    public void StartListingActivity()
    {
        base.DisplayMsg("Welcome to the Reflection Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "How long, in seconds, would you like for your session?");

        int seconds;
        try
        {
            seconds = int.Parse(Console.ReadLine());
        }

        catch (FormatException)
        {
            base.DisplayMsg("Invalid input. Please enter a valid integer value.");
            return;
        }

        //clear terminal
        Console.Clear();

        base.DisplayMsg("Get ready...You will begin soon by listing your thoughts");

        base.ActivityPause(8);

        base.DisplayMsg("List as many responses as you can to the following prompt:", " ");

        string selectedPrompt = GetListingItem(_listingPrompts);

        if (selectedPrompt != null)
        {
            base.DisplayMsg(selectedPrompt, " ");
        }

        base.ActivityCountTime(5, "You may being in: {0}");

        base.ActivityResetTime(true);

        base.DisplayMsg("Type done if you have completed you listing early", " ");

               // use this tuple for duration
        var (startTime, endTime, duration) = base.ActivityDuration(seconds);


        while(startTime < endTime)
        {
            if (startTime <= endTime)
            {
                string userInput = InitializeListingItems();

                if ( userInput.ToLower() == "done")
                {
                    break;
                }
                else
                {
                    _listingItems.Add(userInput);
                }
            } 

            startTime = DateTime.Now;
        }

    int count = _listingItems.Count;
    
    base.DisplayMsg($"You listed {count} items!");

    base.DisplayMsg("Well done!!");

    base.ActivityResetTime(true);

    base.DisplayMsg($"You have completed another {seconds} seconds of Listing Activity."); 

    base.ActivityPause(10);

    }

} 