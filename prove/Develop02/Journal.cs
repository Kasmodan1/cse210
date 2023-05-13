using System;

public class Journal
{
   public string _entry;

    public Journal(string entry)
    {
         _entry = entry;
    }

    public void JournalDisplay()
    {
        Console.WriteLine("Journal entrys recorded: " + _entry);
    }

    public void JournalSave()
    {

    }

    public void JournalLoad()
    {

    }

}