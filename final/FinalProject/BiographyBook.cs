using System;

class BiographyBook : NonFictionBook
{
    private string _subject;

    public BiographyBook(string title, string author, long isbn, string genre, bool availability, string theme)
    : base(title, author, isbn, genre, availability)
    {
        
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

    }
}