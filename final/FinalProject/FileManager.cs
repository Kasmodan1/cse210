using System;
using System.Collections.Generic;
using System.IO;

class FileManager {

  	public string _bookdatafile { get; private set; }
  	public string _memberdatafile { get; private set; }

  	public void SaveBooks(List<Book> books)
  	{
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
        if (string.IsNullOrEmpty(_bookdatafile))
        {
            Console.Write("Enter the filename for the book data file: ");
            _bookdatafile = Console.ReadLine();
        }

        List<Book> books = new List<Book>();

        using (StreamReader reader = new StreamReader(_bookdatafile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Convert the string representation to a book object
                Book book = ConvertStringToBook(line);

                // Add the book to the list
                books.Add(book);
            }
        }

        Console.WriteLine($"Books loaded from {_bookdatafile} successfully.");

        return books;
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
        Console.WriteLine($"Members saved to {_memberdatafile} successfully.");
  	}

    public List<LibraryMember> LoadMembers()
        {
            if (string.IsNullOrEmpty(_memberdatafile))
            {
                Console.Write("Enter the filename for the member data file: ");
                _memberdatafile = Console.ReadLine();
            }

            List<LibraryMember> members = new List<LibraryMember>();

            using (StreamReader reader = new StreamReader(_memberdatafile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Convert the string representation to a member object
                    LibraryMember member = ConvertStringToMember(line);

                    // Add the member to the list
                    members.Add(member);
                }
            }

            Console.WriteLine($"Members loaded from {_memberdatafile} successfully.");

            return members;
        }

    public string ConvertBookToString(Book book)
    {
        if (book is FictionBook)
        {
            FictionBook fictionBook = (FictionBook)book;
            return $"{fictionBook.Title},{fictionBook.Author},{fictionBook.ISBN},{fictionBook.Genre},{fictionBook.Availability},{fictionBook.TargetAge}";
        }
        else if (book is NonFictionBook)
        {
            NonFictionBook nonFictionBook = (NonFictionBook)book;
            return $"{nonFictionBook.Title},{nonFictionBook.Author},{nonFictionBook.ISBN},{nonFictionBook.Genre},{nonFictionBook.Availability},{nonFictionBook.Theme}";
        }
        else if (book is ScienceFictionBook)
        {
            ScienceFictionBook scienceFictionBook = (ScienceFictionBook)book;
            return $"{scienceFictionBook.Title},{scienceFictionBook.Author},{scienceFictionBook.ISBN},{scienceFictionBook.Genre},{scienceFictionBook.Availability},{scienceFictionBook.TargetAge},{scienceFictionBook.ScienceSettings},{scienceFictionBook.ScienceTechnology}";
        }
        else if (book is MysteryBook)
        {
            MysteryBook mysteryBook = (MysteryBook)book;
            return $"{mysteryBook.Title},{mysteryBook.Author},{mysteryBook.ISBN},{mysteryBook.Genre},{mysteryBook.Availability},{mysteryBook.TargetAge},{mysteryBook.Detective},{mysteryBook.Crime}";
        }
        else if (book is FantasyBook)
        {
            FantasyBook fantasyBook = (FantasyBook)book;
            return $"{fantasyBook.Title},{fantasyBook.Author},{fantasyBook.ISBN},{fantasyBook.Genre},{fantasyBook.Availability},{fantasyBook.TargetAge},{fantasyBook.MagicalCreatures},{fantasyBook.MythicalWorld}";
        }
        else if (book is BiographyBook)
        {
            BiographyBook biographyBook = (BiographyBook)book;
            return $"{biographyBook.Title},{biographyBook.Author},{biographyBook.ISBN},{biographyBook.Genre},{biographyBook.Availability},{biographyBook.Theme},{biographyBook.Subject}";
        }
        else if (book is SelfHelpBook)
        {
            SelfHelpBook selfHelpBook = (SelfHelpBook)book;
            return $"{selfHelpBook.Title},{selfHelpBook.Author},{selfHelpBook.ISBN},{selfHelpBook.Genre},{selfHelpBook.Availability},{selfHelpBook.Theme},{selfHelpBook.Topic}";
        }

        // For the base Book class, use the basic properties
        return $"{book.Title},{book.Author},{book.ISBN},{book.Genre},{book.Availability}";
    }


   public Book ConvertStringToBook(string bookString)
    {
        string[] bookData = bookString.Split(',');

        if (bookData.Length < 5)
        {
            // Invalid book string format
            return null;
        }

        string title = bookData[0];
        string author = bookData[1];
        long isbn = long.Parse(bookData[2]);
        string genre = bookData[3];
        bool availability = bool.Parse(bookData[4]);

        Book book;

        switch (genre)
        {
            case "Fiction":
                if (bookData.Length < 6)
                {
                    // Invalid book string format
                    return null;
                }
                int targetAge = int.Parse(bookData[5]);
                book = new FictionBook(title, author, isbn, genre, availability, targetAge);
                break;

            case "Non-Fiction":
                if (bookData.Length < 6)
                {
                    // Invalid book string format
                    return null;
                }
                string nonFictionTheme = bookData[5];
                book = new NonFictionBook(title, author, isbn, genre, availability, nonFictionTheme);
                break;

            case "Science Fiction":
                if (bookData.Length < 8)
                {
                    // Invalid book string format
                    return null;
                }
                int targetAge1 = int.Parse(bookData[5]);
                string scienceSettings = bookData[6];
                string scienceTechnology = bookData[7];
                ScienceFictionBook scienceFiction = new ScienceFictionBook(title, author, isbn, genre, availability, targetAge1);
                scienceFiction.SetScienceSettings(scienceSettings);
                scienceFiction.SetScienceTechnology(scienceTechnology);
                book = scienceFiction;
                break;

            case "Mystery":
                if (bookData.Length < 8)
                {
                    // Invalid book string format
                    return null;
                }
                int targetAge2 = int.Parse(bookData[5]);
                string mysteryDetective = bookData[6];
                string mysteryCrime = bookData[7];
                MysteryBook mystery = new MysteryBook(title, author, isbn, genre, availability, targetAge2);
                mystery.SetDetective(mysteryDetective);
                mystery.SetCrime(mysteryCrime);
                book = mystery;
                break;

            case "Fantasy":
                if (bookData.Length < 8)
                {
                    // Invalid book string format
                    return null;
                }
                int targetAge3 = int.Parse(bookData[5]);
                string fantasyCreatures = bookData[6];
                string fantasyWorld = bookData[7];
                FantasyBook fantasy = new FantasyBook(title, author, isbn, genre, availability, targetAge3);
                fantasy.SetMagicalCreatures(fantasyCreatures);
                fantasy.SetMythicalWorld(fantasyWorld);
                book = fantasy;
                break;

            case "Biography":
                if (bookData.Length < 7)
                {
                    // Invalid book string format
                    return null;
                }
                string biographyTheme = bookData[5];
                string biographySubject = bookData[6];
                BiographyBook biography = new BiographyBook(title, author, isbn, genre, availability, biographyTheme);
                biography.SetSubject(biographySubject);
                book = biography;
                break;

            case "Self-help":
                if (bookData.Length < 7)
                {
                    // Invalid book string format
                    return null;
                }
                string selfHelpTheme = bookData[5];
                string selfHelpTopic = bookData[6];
                SelfHelpBook selfHelp = new SelfHelpBook(title, author, isbn, genre, availability, selfHelpTheme);
                selfHelp.SetTopic(selfHelpTopic);
                book = selfHelp;
                break;

            default:
                // Invalid genre
                return null;
        }

        return book;
    }


    public string ConvertMemberToString(LibraryMember member)
    {
        //string representation using the LibraryMember properties
        string memberToString = $"{member._memberfirstname},{member._memberlastname},{member._libraryid}";

        return memberToString;
    }

    public LibraryMember ConvertStringToMember(string memberString)
    {
        // Split the memberString into individual properties
        string[] properties = memberString.Split(',');

        // Extract the properties and create a new LibraryMember object
        string firstName = properties[0];
        string lastName = properties[1];
        string libraryId = properties[2];

        LibraryMember member = new LibraryMember(firstName, lastName, libraryId);

        return member;
    }
}
