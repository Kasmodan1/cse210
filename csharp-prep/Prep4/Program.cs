using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        do {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            int numbers = int.Parse(Console.ReadLine());
                if (numbers != 0) {
                    numbersList.Add(numbers);
                }
        } while (numbers != 0);
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        
    }
}