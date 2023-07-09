using System;
using System.Collections.Generic;

class FileManager {

  	public string _bookdatafile { get; private set; }
  	public string _memberdatafile { get; private set; }

  	public void SaveBooks(List<Book> books)
  	{
		// Implement the logic to save the list of books to a data file
        if (string.IsNullOrEmpty(_bookdatafile))
        {
            Console.Write("What is the filename for the goal file?: ");
            _bookdatafile = Console.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter(_bookdatafile))
        {
            foreach (Book book in books)
            {
                // Convert the book object to a string representation
                string bookString = ConvertBookToString(book);

                // Write the book string to the file
                writer.WriteLine(bookString);
            }
        }
        Console.WriteLine($"Books saved to {_bookdatafile} successfully.");
    }

  	public List<Book> LoadBooks()
  	{
		// Implement the logic to load the list of books from a data file
        return new List<Book>(); // Placeholder return statement
  	}

  	public void SaveMembers(List<LibraryMember> members)
  	{
        if (string.IsNullOrEmpty(_memberdatafile))
        {
            Console.Write("What is the filename for the goal file?: ");
            _memberdatafile = Console.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter(_memberdatafile))
        {
            foreach (LibraryMember member in members)
            {
                // Convert the book object to a string representation
                string memberString = ConvertMemberToString(member);

                // Write the book string to the file
                writer.WriteLine(memberString);
            }
        }
        Console.WriteLine($"Members saved to {_memberdatafile} successfully.");// Implement the logic to save the list of members to a data file
  	}

    public List<LibraryMember> LoadMembers()
    {
        // Implement the logic to load the list of members from a data file
        return new List<LibraryMember>(); // Placeholder return statement
    }

  	public string ConvertBookToString(Book book)
    {
        //string representation using the book's properties
        string bookToString = $"{book.Title},{book.Author},{book.ISBN},{book.Genre},{book.Availability}";

        return bookToString; 
    }

    public Book ConvertStringToBook(string bookString)
    {
        // Implement the logic to convert a string representation to a book object
        return null; // Placeholder return statement
    }

    public string ConvertMemberToString(LibraryMember member)
    {
        //string representation using the LibraryMember properties
        string memberToString = $"{member._memberfirstname},{member._memberlastname},{member._libraryid}";
        return memberToString;
    }

    public LibraryMember ConvertStringToMember(string memberString)
    {
        // Implement the logic to convert a string representation to a member object
        return null; // Placeholder return statement
    }
}
