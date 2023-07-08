using System;

class SelfHelpBook : NonFictionBook
{
  private string topic;

  public SelfHelpBook(string topic, string title, string author, string isbn, string genre, bool availability)
  : base(topic, title, author, isbn, genre, availability)
    {
    
    }

  public string Topic
  {
    get { return _topic; }
    private set {topic = value; }
  }

  public override void DisplayBookDetails()
  {

  }
}