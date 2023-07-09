using System;

class NonFictionBook : Book
{

  protected string _theme;

  public NonFictionBook(string theme, string title, string author, string isbn, string genre, bool availability)
  : base(title, author, isbn, genre, availability)
    {
    
    }

  public override void DisplayBookDetails()
  {

  }

}