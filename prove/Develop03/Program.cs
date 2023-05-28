using System;
using System.Collections.Generic;
using System.Linq;

//modified reference so it would account for books that have a number before the name.
// made random select from 1 to 4 when hidding. used the list shuffling method.
// Added Scripture Lib Class, made it random and also fixed it so it would only display the nonhidden when randomly selecting.


class Program
{
    static void Main(string[] args)
    {
        // this will create the scripture object.
        //Scripture scripture = new Scripture(new Reference("1 Nephi 3:7"), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        ScriptureLibrary library = new ScriptureLibrary();
        
        // clear the screen
        Console.Clear();

        //display the whole scripture
        //scripture.Display();

        while (true)
        {
            if (library.AllScripturesHidden)
            {
                Console.WriteLine("All scriptures have been hidden. Exiting the program...");
                break;
            }
            Scripture randomScripture = library.GetRandomScripture();

            if (randomScripture == null)
            {
                Console.WriteLine("No available scriptures remaining. Exiting the program...");
                break;
            }

            randomScripture.Display();


            // created while loop to go though scriptue until completly blank.
            while (!randomScripture.AllWordsHidden) 
            {
                Console.WriteLine(" ");
                Console.Write("Press enter to continue or type 'quit to finish:");
                string userinput = Console.ReadLine();

                if (userinput == "quit")
                {
                    break;
                }

                // Hide a few random words in the scripture
                Console.Clear();
                randomScripture.HideRandomWords();
                randomScripture.Display();

            }
       
            Console.WriteLine(" ");

            Console.Write("Press enter to continue with a new scripture or type 'quit' to finish: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "quit")
                break;

            Console.Clear();
        }

        Console.WriteLine("Exiting the program...");
     
    }
}
