using System;

public class Prompt
{
    public (string prompt, string response) PromptList()
    {
        List<string> prompts = new List<string> //should display one question to the user.
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?",
            "What is something new you learned today?",
            "Did you take any risks or step out of your comfort zone today? If so, how did it make you feel?",
            "Did you make progress towards any of your goals today? If not, what can you do differently tomorrow?",
            "Did you practice self-care today? If so, what did you do? If not, what can you do tomorrow to prioritize your well-being?",
            "Did you show kindness to anyone today? If so, who? If not, what opportunities for kindness did you miss?",
            "What was the most challenging aspect of your day today?",
            "Did you have any meaningful conversations with anyone today? If so, what did you discuss?",
            "What is one thing you are grateful for today?",
            "Did you encounter any obstacles today? If so, how did you overcome them?",
            "What did you do to make progress towards a long-term goal today?",
            "Did you do something that made you proud of yourself today? If so, what was it?",
            "What did you do today to take care of your physical health?",
            "Did you encounter any opportunities to learn today? If so, did you take advantage of them?",
            "Was there a moment today when you felt truly happy? If so, what caused it?",
            "Did you do anything to help someone else today? If so, what did you do?"
        };

        // Selects one of the prompts
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        string prompt = prompts[index];

        // Should display the prompt
        Console.WriteLine(prompt);

        // Record what was typed
        string response = Console.ReadLine();

        return (prompt, response);

        // testing the Print the response to the console
        //Console.WriteLine($"You said: {response}");
    
    }
    
}