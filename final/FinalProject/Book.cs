using System;

public class Book
{
    private string _title;
    private string _author;
    private string _isbn;
    private string _genre;
    private bool _availability;

    public Book(string title, string author, string isbn, string genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true; // Assuming the book is initially available
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

    public string ISBN
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

    public void DisplayBookDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Availability: " + (Availability ? "Available" : "Not available"));
    }
}
