using System;

class SelfHelpBook : NonFictionBook
{
    private string topic;

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

    }
}