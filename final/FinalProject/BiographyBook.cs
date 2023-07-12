using System;

class BiographyBook : NonFictionBook
{
    private string _subject;

    public BiographyBook(string title, string author, long isbn, string genre, bool availability, string theme, string subject)
    : base(title, author, isbn, genre, availability, theme)
    {
        Availability = availability;
        Theme = theme;
        Subject = subject;

    }

    public BiographyBook(string title, string author, long isbn, string genre)
    : base(title, author, isbn, genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true; 
    }

    public string Subject
    {
        get { return _subject; }
        private set {_subject = value; }
    }

    public override void DisplayBookDetails()
    {
        // Implement the logic to display the details of a Biography book
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Availability: {(Availability ? "Available" : "Not available")}");
        Console.WriteLine($"The Theme: {Theme}");
        Console.WriteLine($"The Subject: {Subject}");
    }

    public override void Borrow()
    {
        Availability = false;
        Console.WriteLine($"Successfully Borrowed the Biography book: {Title}");
    }

    public override void Return()
    {
        Availability = true;
        Console.WriteLine($"Successfully Returned the Biography book: {Title}");
    }
}