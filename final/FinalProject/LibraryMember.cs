using System;
using System.Collections.Generic;

class LibraryMember {

    private List<Book> _borrowedbooks;
  
    public string _memberfirstname { get; private set; }
    public string _memberlastname { get; private set; }
    public string  _libraryid { get; private set; }


    public LibraryMember(string memberFirstName, string memberLastName, string memberLibraryID)
    {
        _memberfirstname =memberFirstName;
        _memberlastname = memberLastName;
        _libraryid = memberLibraryID;
        _borrowedbooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        // Implement the logic for borrowing a book
    }

    public void ReturnBook(Book book)
    {
        // Implement the logic for returning a book
    }

    public void DisplayBorrowedBooks()
    {
        // Implement the logic for displaying borrowed books
    }

}
