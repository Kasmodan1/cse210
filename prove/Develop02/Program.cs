using System;

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
                //this will call the Prompt for a question.
                Console.WriteLine("you selected opition 1.");

                // This is creating a new instance of Prompt
                Prompt prompt1 = new Prompt();

                //capturing the returns from PromptGenerator
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