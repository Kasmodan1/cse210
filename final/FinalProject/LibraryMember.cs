using System;

class LibraryMember {

  private string _membername;
  private string _libraryid;
  private List<Book> _borrowedbooks;

  public string MemberName
  {
    get { return _membername; }
    protected set { _membername = value; }
  }

  public string libraryID
  {
    get { return _libraryid; }
    private set {_libraryid = value; }
  }

  public void BorrowBook()
  {

  }

  public void ReturnBook()
  {

  }

  public void DisplayBorrowedBooks()
  {

  }

}
