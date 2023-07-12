using System;

class SelfHelpBook : NonFictionBook
{
    private string topic;

    public SelfHelpBook(string title, string author, long isbn, string genre, bool availability, string theme, string topic) 
    : base(title, author, isbn, genre, availability, theme)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = availability;
        Theme = theme;
        Topic = topic;
    }

    public SelfHelpBook(string title, string author, long isbn, string genre) 
    : base(title, author, isbn, genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = true;
    }

    public string Topic
    {
        get { return topic; }
        private set {topic = value; }
    }

     public override void DisplayBookDetails()
    {
        // Implement the logic to display the details of a SelfHelp book
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Availability: {(Availability ? "Available" : "Not available")}");
        Console.WriteLine($"The Theme: {Theme}");
        Console.WriteLine($"The Topic: {Topic}");
    }

    public override void Borrow()
    {
        Availability = false;
        Console.WriteLine($"Successfully Borrowed the SelfHelp book: {Title}");
    }

    public override void Return()
    {
        Availability = true;
        Console.WriteLine($"Successfully Returned the SelfHelp book: {Title}");
    }
}