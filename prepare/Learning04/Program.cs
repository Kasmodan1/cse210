using System;

class Program
{
    static void Main(string[] args)
    {
        Homework homework = new Homework("Scott Midkiff", "Calculus");

        Math math = new Math("7.3" , "8-19", homework.GetStudentName(),homework.GetTopic());

        Writing write = new Writing(homework.GetStudentName(), "European History","WorldWars");

        

        string print1 = homework.GetSummary();
        Console.WriteLine(print1);
        Console.WriteLine("\n");

        string print2 = math.GetHomeworkList();

        Console.WriteLine(print2);
        Console.WriteLine("\n");
        
        string print3 = math.GetMathInformation();
        Console.WriteLine(print3);
        Console.WriteLine("\n");

        string print4 = write.GetWritingInformation();
        Console.WriteLine(print4);
        
    }   
}


