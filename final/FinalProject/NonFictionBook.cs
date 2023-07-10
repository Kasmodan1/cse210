using System;

class NonFictionBook : Book
{

    protected string _theme;

    public NonFictionBook(string title, string author, long isbn, string genre, bool availability)
    : base(title, author, isbn, genre, availability)
    {
    
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

    public override void DisplayBookDetails()
    {

    }

    public override void Borrow()
    {
        Availability = false;
        Console.WriteLine("Borrowing a fiction book: " + Title);
    }

    public override void Return()
    {
        Availability = true;
        Console.WriteLine("Returning a fiction book: " + Title);
    }

}