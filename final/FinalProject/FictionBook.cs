using System;

class FictionBook : Book
{
    protected int _targetage;

    public FictionBook(string title, string author, long isbn, string genre, bool availability, int targetage)
    : base(title, author, isbn, genre, availability)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability =availability;
        TargetAge = targetage;
        
    }

    public FictionBook(string title, string author, long isbn, string genre) 
    : base(title, author, isbn, genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true;
    }

    public int TargetAge
    {
        get { return _targetage; }
        protected set {_targetage = value; }
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

    public override void Borrow()
    {
        Availability = false;
        Console.WriteLine($"Successfully Borrowed the fiction book: {Title}");
    }

    public override void Return()
    {
        Availability = true;
        Console.WriteLine($"Successfully Returned the fiction book: {Title}");
    }
}
