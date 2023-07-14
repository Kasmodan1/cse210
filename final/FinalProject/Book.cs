using System;

public abstract class Book
{
    protected string _title;
    protected string _author;
    protected long _isbn;
    protected string _genre;
    protected bool _availability;

    public Book(string title, string author, long isbn, string genre, bool availability)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = availability;
    }

    public Book(string title, string author, long isbn, string genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true;
    }

    public string Title
    {
        get { return _title; }
        protected set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        protected set { _author = value; }
    }

    public long ISBN
    {
        get { return _isbn; }
        protected set { _isbn = value; }
    }

    public string Genre
    {
        get { return _genre; }
        protected set { _genre = value; }
    }

    public bool Availability
    {
        get { return _availability; }
        protected set { _availability = value; }
    }

    public virtual void DisplayBookDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Availability: " + (Availability ? "Available" : "Not available"));
    }
    
    public void SetAvailability(bool available)
    {
        Availability = available;
    }

    public abstract void Borrow();
    public abstract void Return();
}
