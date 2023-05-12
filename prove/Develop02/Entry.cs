using System;

public class Entry
{
  public int MenuSelection()
  {
    // These are the list of options.
    string[] entrys = { "1. Write a entry.", "2. Display current entrys.", "3. Load saved entrys.", "4. Save entry.", "5. Quit program." };
    //show the options.
    Console.WriteLine("Please select from the following options:");
        for (int display = 0; display < entrys.Length; display++)
        {
            //go though each and display it adding 1 to display until it reaches the length of array.
            Console.WriteLine(entrys[display]);
        }
    Console.Write("Which option would you like? :");

    // gather what was entered.
    string input = Console.ReadLine();

    //convert string to int.
    int numberChoice = int.Parse(input);
    
    //send back the int to the main program.
    return numberChoice;
  }
}