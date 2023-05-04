using System;

  public class Job 
  {
    //Class: Job
    //Responsibilities:
    //Keeps track of the company, job title, start year, and end year.
    //Behaviors:
    //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    
    public void Display() 
    {
        Console.Write($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
  }