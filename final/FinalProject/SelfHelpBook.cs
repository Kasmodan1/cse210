using System;

class SelfHelpBook : NonFictionBook
{
  private string topic;

  public SelfHelpBook(string theme, string title, string author, string isbn, string genre, bool availability)
  : base(theme, title, author, isbn, genre, availability)
    {
    
    }

  public string Topic
  {
    get { return topic; }
    private set {topic = value; }
  }

  public override void DisplayBookDetails()
  {

  }
}