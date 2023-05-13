using System;
using System.Collections.Generic;
using System.IO;

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
public class Journal
{
    public List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }
    
    public void AddJournalEntries(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public string DisplayJournalEntries()
    {
        string output = "";
        foreach (var entry in entries)
        {
            output += entry.ToString() + "\n";
            
        }
        return output;
    }

    public void SaveJournalEntires(DateTime date, string prompt, string response)
    {
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"{date}|{prompt}|{response}");
        }
    }

    public void LoadJournalEntries()
    {
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            DateTime date = DateTime.Parse(parts[0]);
            string prompt = parts[1];
            string response = parts[2];


        }
    }

}