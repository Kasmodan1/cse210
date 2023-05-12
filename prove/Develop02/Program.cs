using System;

class Program
{
    static void Main(string[] args)
    { 
        //create a new Entry
        Entry entry1 = new Entry(); 

        int selected = 0;
        
        // created while loop to go though menu until 5 is chosen.
        while (selected !=5)
        {
            selected = entry1.MenuSelection();

            if (selected == 1)
            {
                //this will call the Prompt for a question.
                Console.WriteLine("you selected opition 1.");
            }
            else if (selected == 2)
            {
                //this will display what was enterd.
                Console.WriteLine("you selected opition 2.");  
            }
            else if (selected == 3)
            {
                //this will save the journal entrys to a file.
                Console.WriteLine("you selected opition 3.");  
            }
            else if (selected == 4)
            {
                //this will load a journal file.
                Console.WriteLine("you selected opition 4.");  
            }
            else if (selected != 5)
            {
                //this will quite the program.
                Console.WriteLine("you selected opition 5.");  
                Console.WriteLine("Quiting program."); 
            }
            
            

        }

    }
}