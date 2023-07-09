using System;

class BiographyBook : NonFictionBook
{
  private string _subject;

  public BiographyBook(string topic, string title, string author, long isbn, string genre, bool availability)
  : base(topic, title, author, isbn, genre, availability)
    {
    
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