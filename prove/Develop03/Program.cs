using System;
using System.Collections.Generic;
using System.Linq;

//modifyed reference so it would account for books that have a numbere before the name.


class Program
{
    static void Main(string[] args)
    {
        // this will create the scripture object.
        Scripture scripture = new Scripture(new Reference("1 Nephi 3:7"), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        // clear the screen
        Console.Clear();

        //display the whole scripture
        scripture.Display();

        // created while loop to go though scriptue until completly blank.
        while (!scripture.AllWordsHidden) 
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
            scripture.HideRandomWords();
            scripture.Display();

        }
       
        Console.Write("Exiting the program...");
        
    }
}
