using System;

class SelfHelpBook : NonFictionBook
{
    private string _topic;

    public SelfHelpBook(string title, string author, long isbn, string genre, bool availability, string theme) 
    : base(title, author, isbn, genre, availability, theme)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = availability;
        Theme = theme;
    }

    public string Topic
    {
        get { return _topic; }
        private set {_topic = value; }
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
        Console.WriteLine($" ");
    }
    
    public void SetTopic(string topic)
    {
        Topic = topic;
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