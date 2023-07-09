using System;

class MysteryBook : FictionBook
{
  public MysteryBook(int targetage, string title, string author, long isbn, string genre, bool availability)
  : base(targetage, title, author, isbn, genre, availability)
    {
    
    }

  public override void DisplayBookDetails()
  {

  }

}