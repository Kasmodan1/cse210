using System;
using System.Collections.Generic;

public class JournalEntry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public JournalEntry(DateTime date,string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date.ToShortDateString()} - Prompt: {Prompt} - Response: {Response}";
    }
    
}