using System;

class NonFictionBook : Book
{

    protected string _theme;

    public NonFictionBook(string title, string author, long isbn, string genre, bool availability, string theme)
    : base(title, author, isbn, genre, availability)
    {
        Availability = availability;
        Theme = theme;
    }

    public NonFictionBook(string title, string author, long isbn, string genre)
    : base(title, author, isbn, genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true; 
    }

    public string Theme
    {
        get { return _theme; }
        protected set {_theme = value; }
    }

    public override void DisplayBookDetails()
    {
        // Implement the logic to display the details of a non-fiction book
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Availability: {(Availability ? "Available" : "Not available")}");
        Console.WriteLine($"The Theme: {Theme}");
    }

    public override void Borrow()
    {
        Availability = false;
        Console.WriteLine($"Successfully Borrowed the Nonfiction book: {Title}");
    }

    public override void Return()
    {
        Availability = true;
        Console.WriteLine($"Successfully Returned the Nonfiction book: {Title}");
    }

}