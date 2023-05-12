using System;

public class Entry
{
    public void enteredSelection()
    {
      // These are the list of options
      string[] entrys = {"1. Write a entry.", "2. Display current entrys.", "3. Load saved entrys.", "4. Save entry.", "5. Quit program." };

      //show the options
      Console.Write("Please select from the following options:");

      for (int display = 0; display < entrys.Length; display++)
        {
          Console.WriteLine(entrys[display]);
        }

      Console.Write(":");
      string input = Console.ReadLine();

    }
}