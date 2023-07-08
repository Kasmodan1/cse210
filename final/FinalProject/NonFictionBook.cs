using System;

class NonFictionBook : Book
{

  protected string _topic;

  public NonFictionBook(string topic, string title, string author, string isbn, string genre, bool availability)
  : base(title, author, isbn, genre, availability)
    {
    
    }

  public override void DisplayBookDetails()
  {

  }

}