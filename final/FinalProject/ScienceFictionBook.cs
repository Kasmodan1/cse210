using System;

class ScienceFictionBook : FictionBook
{
    private string _settings;
    private string _technology;

    public ScienceFictionBook(string title, string author, long isbn, string genre, bool availability, int targetage)
    : base(title, author, isbn, genre, availability, targetage)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = availability;
        TargetAge = targetage;
    }

    public string ScienceSettings
    {
        get { return _settings; }
        private set {_settings = value; }
    }

    public string ScienceTechnology
    {
        get { return _technology; }
        private set {_technology = value; }
    }

    public override void DisplayBookDetails()
    {
        // Implement the logic to display the details of a science fiction book
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Availability: {(Availability ? "Available" : "Not available")}");
        Console.WriteLine($"Target Age: {TargetAge}");
        Console.WriteLine($"Setting: {ScienceSettings}");
        Console.WriteLine($"Technology: {ScienceTechnology}");
        Console.WriteLine($" ");
    }

    public void SetScienceSettings(string settings)
    {
        ScienceSettings = settings;
    }

    public void SetScienceTechnology(string tech)
    {
        ScienceTechnology = tech;
    }

    public override void Borrow()
    {
        Availability = false;
        Console.WriteLine($"Successfully Borrowed the {Genre}: {Title}");
    }

    public override void Return()
    {
        Availability = true;
        Console.WriteLine($"Successfully Returned the {Genre}: {Title}");
    }
    
}