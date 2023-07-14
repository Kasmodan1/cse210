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
        if (book.Availability)
        {
            book.Borrow();
            _borrowedbooks.Add(book);
            Console.WriteLine("Book borrowed successfully.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (_borrowedbooks.Contains(book))
        {
            book.Return();
            _borrowedbooks.Remove(book);
            Console.WriteLine("Book returned successfully");
        }
        
    }

    public bool HasBorrowedBook(Book book)
    {
        return _borrowedbooks.Contains(book);
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
