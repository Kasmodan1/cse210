using System;

class FantasyBook : FictionBook
{
    private string _magicalCreatures;
    private string _mythicalWorld;

    public FantasyBook(string title, string author, long isbn, string genre, bool availability, int targetage)
    : base(title, author, isbn, genre, availability, targetage)
    {

    }

    public FantasyBook(string title, string author, long isbn, string genre)
    : base(title, author, isbn, genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true; 
    }

    public string MagicalCreatures
    {
        get { return _magicalCreatures; }
        private set {_magicalCreatures = value; }
    }

    public string MythicalWorld
    {
        get { return _mythicalWorld; }
        private set {_mythicalWorld = value; }
    }


    public override void DisplayBookDetails()
    {
        // Implement the logic to display the details of a fiction book
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Availability: {(Availability ? "Available" : "Not available")}");
        Console.WriteLine($"Target Age: {TargetAge}");
        
    }
    
}