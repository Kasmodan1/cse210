using System;

class FantasyBook : FictionBook
{
  public FantasyBook(int targetage, string title, string author, string isbn, string genre, bool availability)
  : base(targetage, title, author, isbn, genre, availability)
    {
    
    }


  public override void DisplayBookDetails()
  {

  }
}