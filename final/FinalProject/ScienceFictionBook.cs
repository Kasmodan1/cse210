using System;

class ScienceFictionBook : FictionBook
{
    public ScienceFictionBook(string title, string author, long isbn, string genre, bool availability, int targetage)
    : base(title, author, isbn, genre, availability, targetage)
    {
        
    }

    public ScienceFictionBook(string title, string author, long isbn, string genre)
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
}