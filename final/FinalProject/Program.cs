using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");


    }
}


//Book Class:
//
//Properties: title, author, ISBN, genre, availability
//Methods: getters and setters for properties, display book details
//
//FictionBook Class (Inherits from Book):
//
//Additional Properties: targetAge
//Additional Methods: display book details (overridden)
//
//NonFictionBook Class (Inherits from Book):
//
//Additional Properties: topic
//Additional Methods: display book details (overridden)
//
//LibraryMember Class:
//
//Properties: name, libraryID, borrowedBooks
//Methods: getters and setters for properties, borrow book, return book, display //borrowed books
//
//Library Class:
//
//Properties: books, members
//Methods: add book, remove book, search book by title, search book by author, add //member, remove member
//
//Now, let's see how the classes interact and demonstrate the principles of //abstraction, encapsulation, inheritance, and polymorphism:
//
//The Book class serves as a base class for FictionBook and NonFictionBook, showcasing //inheritance. It defines common properties and methods for all types of books, such //as title and author. The display book details method is overridden in the derived //classes to showcase polymorphism.
//
//The LibraryMember class represents a library member, encapsulating their information //and providing methods to borrow and return books. It encapsulates the borrowedBooks //list as a private property, allowing controlled access through methods.
//
//The Library class represents the library itself, encapsulating the books and //members. It provides methods to add and remove books/members and search for books by //title or author. It demonstrates the principle of abstraction by providing a //high-level interface to manage the library's catalog.
