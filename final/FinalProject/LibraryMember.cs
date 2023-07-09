using System;
using System.Collections.Generic;

class LibraryMember {

    private static List<Book> _borrowedbooks;
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

    public static void DisplayBorrowedBooks()
    {
        if (_borrowedbooks.Count == 0)
        {
            Console.WriteLine("No books currently borrowed");
            return;
        }
        // Implement the logic for displaying borrowed books
        Console.WriteLine("Books currently borrowed:");
        foreach (Book book in _borrowedbooks) 
        {
            book.DisplayBookDetails();
            Console.WriteLine("------------------------");
        }
    }

}
