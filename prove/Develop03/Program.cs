using System;


//Your program must do the following:

//1.Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
//2.Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
//3.Clear the console screen and display the complete scripture, including the reference and the text.
//4.Prompt the user to press the enter key or type quit.
//5.If the user types quit, the program should end.
//6.If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
//7.The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
//8.When all words in the scripture are hidden, the program should end.
//9.When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)


//Design Requirements
//In addition your program must:

//1.Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.
//2.Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for the reference (for example "John 3:16"), and to represent a word in the scripture.
//3.Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").


class Program
{
    static void Main(string[] args)
    {
        string userinput = string.Empty;


        // created while loop to go though scriptue until completly blank.
        while (userinput.ToLower() != "quit") 
        {

            // displays full scripture: example ******************
            Scripture scripture1 = new Scripture(); 
            
            Console.WriteLine("Press enter to continue or type 'quit to finish:");
            userinput = Console.ReadLine();

            if (userinput.ToLower() == "quit")
            {
                break;
            }
            else if ()
            {
                // This will start by displaying "AAA" and waiting for the user to press the enter key
                Console.WriteLine("AAA");
                Console.ReadLine();

                // This will clear the console
                Console.Clear();

                // This will show "BBB" in the console where "AAA" used to be
                Console.WriteLine("BBB");
            }

        Console.WriteLine("Exiting the program...");
    
        }
       
   
        // Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all they ways acknowledge him, and he shall direct thy paths.

        //Press enter to continue or type 'quit to finish:

        // pressed enter

        //Displays : Proverbs 3:5-6 Trust in the ---- ---- --- thine heart and lean not unto thine own understanding; in all they ways acknowledge him, and he shall direct thy paths.

        // it removes 3 randome words from sentence.
        // hitting enter keep removing 3 more.
        // goes until the whole scripture is empty. then exits.
    }
}
