using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0) 
            {
                numbersList.Add(number);
            }
        } while (number != 0);

        foreach (int n in numbersList) 
        {
            Console.WriteLine(n);
        }
        
    }
}