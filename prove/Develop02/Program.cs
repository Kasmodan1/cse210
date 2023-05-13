using System;

// I've enjoyed writing This program out, I've always liked arrays and 
// how useful they are when I coded in Ruby back in the day. 
// Though I have to admit I probably spent way too much time trying to use the best way instead of quick and dirty. 
// I did have to use Google and MDN a lot to read how to accomplish the idea I wanted to do my head. 
// Looking up all the errors I was getting and figuring them out was fun but challening. 
// I'm not sure If I should have created all of the Class that I did make.
// Maybe I should have combined them more.

// Some improvements that I did along the way 1. added more prompts. 2. made sure the saved file entries do not get overwritten but amended. 3. Try to use more advanced features instead of chunky blocks like arrays(lists).

class Program
{
    static void Main(string[] args)
    { 
        //create a new instance of the Entry class
        Entry entry1 = new Entry(); 

        // create a new instance of the Journal class
        Journal journal1 = new Journal();

        //set selection of the menu to 0 outside of the loop.
        int selected = 0;
        
        // created while loop to go though menu until 5 is chosen.
        while (selected !=5)
        {
            selected = entry1.MenuSelection();

            if (selected == 1)
            {
                //this will let them know what they selected.
                Console.WriteLine("you selected opition 1.");

                // This is creating a new instance of Prompt
                Prompt prompt1 = new Prompt();

                //capturing the returns from PromptGenerator class
                (string promptText, string response) = prompt1.PromptList();

                //Gathers date,prompt,and response
                JournalEntry entry = new JournalEntry(DateTime.Now, promptText, response);

                // useing this funtion to go though each entry
                journal1.AddJournalEntries(entry);

            }

            else if (selected == 2)
            {
                //this will display the entries.
                Console.WriteLine("you selected opition 2.");  

                //use this instace of the Journal class to display entries - Dont make a new one -
                string entriesText = journal1.DisplayJournalEntries();

                Console.WriteLine(entriesText);
            }
        
            else if (selected == 3)
            {
                //this will load a journal file.
                Console.WriteLine("you selected opition 3.");  

                journal1.LoadJournalEntries();
         
            }

            else if (selected == 4)
            {
                //this will save the journal entrys to a file.
                Console.WriteLine("you selected opition 4.");  

                //having it go though each entry and pipe it to save function.
                foreach (var entry in journal1.entries)
                {
                    journal1.SaveJournalEntires(entry.Date, entry.Prompt, entry.Response);
                }

                Console.WriteLine("Entries have saved to a file.");
            }

            else if (selected == 5)
            {
                //this will quite the program.
                Console.WriteLine("you selected opition 5.");  
                Console.WriteLine("Quiting program."); 
            }

        }

    }

}