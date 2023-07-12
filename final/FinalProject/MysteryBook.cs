using System;

class MysteryBook : FictionBook
{
    private bool _detective;
    private bool _crime;

    public MysteryBook(string title, string author, long isbn, string genre, bool availability, int targetage)
    : base(title, author, isbn, genre, availability, targetage)
    {
        
    }

    public MysteryBook(string title, string author, long isbn, string genre)
    : base(title, author, isbn, genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true; 
    }

    public bool Detective
    {
        get { return _detective; }
        private set {_detective = value; }
    }

    public bool Crime
    {
        get { return _crime; }
        private set {_crime = value; }
    }

    public override void DisplayBookDetails()
    {
        // Implement the logic to display the details of a fiction book
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Availability: {(Availability ? "Available" : "Not available")}");
        Console.WriteLine($"The Target Age is: {TargetAge}");
        if (Detective == true)
        {
            Console.WriteLine($"This is a detective style book.");
        }
        if (Crime == true)
        {
            Console.WriteLine($"This is a Crime style book.");
        }
    
    }

}