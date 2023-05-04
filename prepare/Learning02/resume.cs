using System;

  public class Resume 
  {
    //Class: Resume
    //Responsibilities:
    //Keeps track of the person's name and a list of their jobs.
    //Behaviors:
    //Displays the resume, which shows the name first, followed by displaying each one of the jobs.

    public string _name;
    
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
      Console.Write($"Name:{_name} {_jobs}");

      Console.Write($"Name:Jobs");
      
      foreach (Job item in _jobs)
      {
        item.Display();
      }
    }
  }

