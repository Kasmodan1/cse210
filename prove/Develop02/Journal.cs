using System;
using System.Collections.Generic;
using System.IO;

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
        //creates the file
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        // loop though each line item and mapping the parts.
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            DateTime date = DateTime.Parse(parts[0]);
            string prompt = parts[1];
            string response = parts[2];

            // using the JournalEntry class to map it back to date,prompt,response
            JournalEntry entry = new JournalEntry(date, prompt, response);

            // This should add it back into the entry list.
            AddJournalEntries(entry);
        }

    }

}