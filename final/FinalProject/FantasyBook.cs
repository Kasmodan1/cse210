using System;

class FantasyBook : FictionBook
{
    private string _magicalCreatures;
    private string _mythicalWorld;

    public FantasyBook(string title, string author, long isbn, string genre, bool availability, int targetage, string magicalCreatures, string mythicalWorld)
    : base(title, author, isbn, genre, availability, targetage)
    {
        TargetAge = targetage;
        MagicalCreatures = magicalCreatures;
        MythicalWorld = mythicalWorld;
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

    public FantasyBook(string title, string author, long isbn, string genre, bool availability, int targetage) : base(title, author, isbn, genre, availability, targetage)
    {

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
        Console.WriteLine($"Magical Creatures: {MagicalCreatures}");
        Console.WriteLine($"This book has {MythicalWorld}");
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