using System;

class FictionBook : Book
{

  protected int _targetage;

  public FictionBook(int targetage, string title, string author, string isbn, string genre, bool availability)
  : base(title, author, isbn, genre, availability)
    {
    
    }
  
  public override void DisplayBookDetails()
  {

  }
}