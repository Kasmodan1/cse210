using System;

class MysteryBook : FictionBook
{
    private string _detective;
    private string _crime;

    public MysteryBook(string title, string author, long isbn, string genre, bool availability, int targetage) 
    : base(title, author, isbn, genre, availability, targetage)
    {   
        Title = title;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Availability = availability;
        TargetAge = targetage;
    }

    public string Detective
    {
        get { return _detective; }
        private set {_detective = value; }
    }

    public string Crime
    {
        get { return _crime; }
        private set {_crime = value; }
    }

    public override void DisplayBookDetails()
    {
        // Implement the logic to display the details of a fiction book
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Availability: {(Availability ? "Available" : "Not available")}");
        Console.WriteLine($"Detective: {Detective}");
        Console.WriteLine($"Crime : {Crime}");
        Console.WriteLine($" ");
    }

    public void SetDetective(string detective)
    {
        Detective = detective;
    }

    public void SetCrime(string crime)
    {
        Crime = crime;
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