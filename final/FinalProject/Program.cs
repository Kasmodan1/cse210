using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Library library = new Library();
        LibraryMember activeMember = null;
        FileManager fileManager = new FileManager();

        bool exit = false;

        while (!exit)
        {

            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Library System Interface ");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" ");
            Console.WriteLine("1. New Member?");
            Console.WriteLine("2. Existing Member?");
            Console.WriteLine("3. Quit");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("4. Library Admin Menu");
            Console.Write("Select a number choice from the menu: ");
    
            string menuChoice = Console.ReadLine();
            Console.Clear();
            switch (menuChoice)
            {
                case "1":

                    // New Member creation
                    Console.Write("Enter your first name: ");
                    string newMemberFirstName = Console.ReadLine();

                    Console.Write("Enter your last name: ");
                    string newMemberLastName = Console.ReadLine();

                    Console.Write("Enter your Email Address (this will be your ID): ");
                    string newLibraryMemberId = Console.ReadLine();

                    LibraryMember newMember = new LibraryMember(newMemberFirstName, newMemberLastName, newLibraryMemberId);

                    Library.AddMember(newMember);

                    Console.Write("New user has been created");
                        
                    break;

                case "2":
                    bool memberMenuExit = false;
                    while (!memberMenuExit)
                    {
                        if (activeMember == null)
                        {
                            Console.Write("Enter member ID (your Email): ");
                            string memberId = Console.ReadLine();

                            LibraryMember member = library.GetMemberByID(memberId);
                            if (member != null)
                            {
                                Console.WriteLine($"Member found: {member._memberfirstname} {member._memberlastname}");
                                activeMember = member;
                            }
                            else
                            {
                                Console.WriteLine("Member not found.");
                                break;
                            }
                        }
                        
                        // Existing Member
                        Console.WriteLine("Welcome to the Member search area.");
                        Console.WriteLine(" ");
                        Console.WriteLine("The types of searches are: ");
                        Console.WriteLine("1. By Title ");
                        Console.WriteLine("2. By Author: ");
                        Console.WriteLine("3. By ISBN#: ");
                        Console.WriteLine("4. By Genre: ");
                        Console.WriteLine(" Other Member Options");
                        Console.WriteLine("5. Display Borrowed Books: ");
                        Console.WriteLine("6. Check-out Books: ");
                        Console.WriteLine("7. Check-in Books: ");

                        Console.WriteLine("8. Exit to main menu ");
                        Console.WriteLine(" ");
                        Console.Write("Select a number choice from the menu: ");
                        int memberMenuChoice = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (memberMenuChoice)
                        {
                            case 1:
                                // search book by title
                                Console.Write("Enter the title of the book:");
                                string searchTitle = Console.ReadLine();
                                Console.Clear();
                                library.SearchBookByTitle(searchTitle);

                                break;

                            case 2:
                                // search book by author
                                Console.Write("Enter the Author of the book:");
                                string searchAuthor = Console.ReadLine();

                                library.SearchBookByAuthor(searchAuthor);
                                break;

                            case 3:
                                // search book by isbn number
                                Console.Write("Enter the ISBN of the book:");
                                long searchIsbn = long.Parse(Console.ReadLine());

                                library.SearchBookByISBN(searchIsbn);
                                break;

                            case 4:
                                // search book by genre
                                Console.Write("Enter the Genre of the book:");
                                string searchGenre = Console.ReadLine();

                                library.SearchBookByGenre(searchGenre);
                                break;

                            case 5:
                                // Display currently borrowed books
                                LibraryMember.DisplayBorrowedBooks();
                                break;

                            case 6:
                                // Check-out Books
                                Console.Write("Enter the title of the book to check out:");
                                string checkoutTitle = Console.ReadLine();

                                // Search for books with the specified title
                                List<Book> matchingBooks = library.SearchBookByTitle(checkoutTitle);

                                if (matchingBooks.Count > 0)
                                {
                                    // Display the matching books with numbered options
                                    Console.WriteLine("Matching Books:");
                                    for (int i = 0; i < matchingBooks.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {matchingBooks[i].Title} {matchingBooks[i].Genre}");
                                    }

                                    Console.Write("Enter the number corresponding to the book you want to check out:");
                                    int selection;
                                    if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= matchingBooks.Count)
                                    {
                                        // Get the selected book
                                        Book checkoutBook = matchingBooks[selection - 1];

                                        if (checkoutBook.Availability)
                                        {
                                            // Borrow the selected book for the logged-in member
                                            activeMember.BorrowBook(checkoutBook);
                                        }
                                        else
                                        {
                                            Console.WriteLine("The selected book is not available for checkout.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid selection.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No books found with the specified title.");
                                }
                                break;

                           case 7:
                                // Check-in Books
                                Console.Write("Enter the title of the book to check in:");
                                string returnTitle = Console.ReadLine();

                                // Search for books with the specified title
                                List<Book> matchingBooks1 = library.SearchBookByTitle(returnTitle);

                                if (matchingBooks1.Count > 0)
                                {
                                    // Display the matching books with numbered options
                                    Console.WriteLine("Matching Books:");
                                    for (int i = 0; i < matchingBooks1.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {matchingBooks1[i].Title}");
                                    }

                                    Console.Write("Enter the number corresponding to the book you want to check in:");
                                    int selection;
                                    if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= matchingBooks1.Count)
                                    {
                                        // Get the selected book
                                        Book returnBook = matchingBooks1[selection - 1];

                                        if (activeMember.HasBorrowedBook(returnBook))
                                        {
                                            // Return the selected book
                                            activeMember.ReturnBook(returnBook);
                                        }
                                        else
                                        {
                                            Console.WriteLine("You have not borrowed the selected book.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid selection.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No books found with the specified title.");
                                }
                                break;

                            case 8:
                                // exit to Main Menu
                                memberMenuExit = true;
                                break;

                            default:
                                Console.WriteLine("Please enter a valid choice.");
                                break;   
                        }
                    }
                    break;

                case "3":

                    // This will exit the while loop.
                    exit = true;
                    break;

                case "4":
                    bool adminMenuExit = false;
                    while (!adminMenuExit)
                    {
                        Console.WriteLine("Library Admin Menu:");
                        Console.WriteLine(" ");
                        Console.WriteLine("1. Manually Add a Book");
                        Console.WriteLine("2. Remove a Book");
                        Console.WriteLine("3. Add a Member");
                        Console.WriteLine("4. Remove a Member");
                        Console.WriteLine("5. Save or Load Member list");
                        Console.WriteLine("6. Save or Load Book List");
                        Console.WriteLine("7. Display Checked Out Books");
                        Console.WriteLine("8. Check-in Borrowed Books");
                        Console.WriteLine("9. Search Book by Author");
                        Console.WriteLine("10. Search Book by Title");
                        Console.WriteLine("11. Search Book by ISBN Number");
                        Console.WriteLine("12. Search Book by Genre");
                        Console.WriteLine("13. Exit to Main Menu");
                        Console.WriteLine();
                        Console.Write("Select a number choice from the menu: ");
                        int adminMenuChoice = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (adminMenuChoice)
                        {
                            case 1:
                                // Manually Add a Book
                                Library.ManualAddBook();
                                break;

                            case 2:
                                // Code for "Remove a Book" option
                                Console.Write("Enter the title of the book to remove:");
                                string removeTitle = Console.ReadLine();

                                // Search for books with the specified title
                                List<Book> matchingBooks2 = library.SearchBookByTitle(removeTitle);

                                if (matchingBooks2.Count > 0)
                                {
                                    // Display the matching books with numbered options
                                    Console.WriteLine("Matching Books: ");
                                    for (int i = 0; i < matchingBooks2.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {matchingBooks2[i].Title},{matchingBooks2[i].Author},{matchingBooks2[i].Genre}");
                                    }

                                    Console.Write("Enter the number corresponding to the book you want to remove:");
                                    int selection;
                                    if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= matchingBooks2.Count)
                                    {
                                        // Get the selected book
                                        Book removeBook = matchingBooks2[selection - 1];

                                        // Remove the book from the library
                                        library.RemoveBook(removeBook);
                                        Console.WriteLine("Book removed successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid selection.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No books found with the specified title.");
                                }
                                break;

                            case 3:
                                // Add a Member
                                Console.Write("Enter the first name of the member: ");
                                string adminNewMemberFirstName = Console.ReadLine();

                                Console.Write("Enter the last name of the member: ");
                                string adminNewMemberLastName = Console.ReadLine();

                                Console.Write("Enter the email address (ID) of the member: ");
                                string newMemberId = Console.ReadLine();

                                LibraryMember adminNewMember = new LibraryMember(adminNewMemberFirstName, adminNewMemberLastName, newMemberId);
                                Library.AddMember(adminNewMember);

                                Console.WriteLine("Member added successfully.");
                                break;

                            case 4:
                                // Remove a Member
                                Console.Write("Enter the member ID to remove: ");
                                string memberIdToRemove = Console.ReadLine();

                                // Remove the member from the library and check the result
                                bool memberRemoved = library.RemoveMember(memberIdToRemove);
                                if (memberRemoved)
                                {
                                    Console.WriteLine("Member removed successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Member not found.");
                                }
                                break;

                            case 5:
                                // Save or Load Member list
                                Console.WriteLine("Menu Options:");
                                Console.WriteLine("1. Save Member list");
                                Console.WriteLine("2. Load Member list");
                                Console.Write("Select a number choice from the menu: ");
                                string fileMemberMenuChoice = Console.ReadLine();
                                Console.Clear();

                                switch (fileMemberMenuChoice)
                                {
                                    case "1":
                                        // Save Member list
                                        library.SaveMember();
                                        Console.WriteLine("Member list saved successfully.");
                                        break;

                                    case "2":
                                        // Load Member list
                                        library.LoadMember();
                                        Console.WriteLine("Member list loaded successfully.");
                                        break;

                                    default:
                                        Console.WriteLine("Please enter a valid choice.");
                                        break;
                                }

                                break;

                            case 6:
                                // Code for "Save or Load Book List" option
                                Console.WriteLine("Menu Options:");
                                Console.WriteLine("1. Save Book list");
                                Console.WriteLine("2. Load Book list");
                                Console.Write("Select a number choice from the menu: ");
                                string fileBookMenuChoice = Console.ReadLine();
                                Console.Clear();

                                switch (fileBookMenuChoice)
                                {
                                    case "1":
                                        // Save Book list
                                        library.SaveBook();
                                        Console.WriteLine("Book list saved successfully.");
                                        break;

                                    case "2":
                                        // Load Book list
                                        library.LoadBook();
                                        Console.WriteLine("Book list loaded successfully.");
                                        break;

                                    default:
                                        Console.WriteLine("Please enter a valid choice.");
                                        break;
                                }

                                break;

                            case 7:
                                // Display Checked Out Books for all Users
                                Console.WriteLine("Checked Out Books:");
                                bool noCheckedOutBooks = true;

                                foreach (LibraryMember member in Library.GetMembers())
                                {
                                    List<Book> borrowedBooks = member.GetBorrowedBooks();
                                    if (borrowedBooks.Count > 0)
                                    {
                                        Console.WriteLine($"Member: {member._memberfirstname} {member._memberlastname}");
                                        Console.WriteLine("Borrowed Books:");
                                        foreach (Book book in borrowedBooks)
                                        {
                                            book.DisplayBookDetails();
                                            Console.WriteLine("------------------------");
                                        }
                                        Console.WriteLine();
                                        noCheckedOutBooks = false;
                                    }
                                }

                                if (noCheckedOutBooks)
                                {
                                    Console.WriteLine("No books currently checked out by any member.");
                                }

                                break;

                            case 8:
                                Console.Write("Enter the title of the book to check in (partial search):");
                                string returnTitle = Console.ReadLine();
                                bool bookReturned = false;

                                List<Book> matchingBooks = new List<Book>();

                                foreach (LibraryMember member in Library.GetMembers())
                                {
                                    List<Book> borrowedBooks = member.GetBorrowedBooks();
                                    foreach (Book book in borrowedBooks)
                                    {
                                        if (book.Title.Contains(returnTitle, StringComparison.OrdinalIgnoreCase))
                                        {
                                            // Check if the book is already in the matchingBooks list
                                            if (!matchingBooks.Contains(book))
                                            {
                                                matchingBooks.Add(book);
                                            }
                                        }
                                    }
                                }

                                if (matchingBooks.Count > 0)
                                {
                                    Console.WriteLine("Matching Books:");
                                    for (int i = 0; i < matchingBooks.Count; i++)
                                    {
                                        Book book = matchingBooks[i];
                                        LibraryMember member = Library.GetMemberByBook(book);
                                        Console.WriteLine($"{i + 1}. {book.Title},{book.Author}, {book.Genre} (Borrowed by {member._memberfirstname} {member._memberlastname})");
                                    }

                                    Console.Write("Enter the number corresponding to the book you want to check in:");
                                    int selection;
                                    if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= matchingBooks.Count)
                                    {
                                        Book returnBook = matchingBooks[selection - 1];

                                        foreach (LibraryMember member in Library.GetMembers())
                                        {
                                            if (member.HasBorrowedBook(returnBook))
                                            {
                                                member.ReturnBook(returnBook);
                                                bookReturned = true;
                                                Console.WriteLine($"Book '{returnBook.Title}' returned by {member._memberfirstname} {member._memberlastname}");
                                                break;
                                            }
                                        }

                                        if (!bookReturned)
                                        {
                                            Console.WriteLine($"The selected book '{returnBook.Title}' is not checked out by any member.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid selection.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No books found with the specified title.");
                                }
                                break;


                            case 9:
                                // Code for "Search Book by Author" option
                                Console.Write("Enter the Author of the book:");
                                string searchAuthor = Console.ReadLine();

                                library.SearchBookByAuthor(searchAuthor);
                                break;

                            case 10:
                                // Code for "Search Book by Title" option
                                Console.Write("Enter the title of the book:");
                                string searchTitle = Console.ReadLine();
                                Console.Clear();
                                library.SearchBookByTitle(searchTitle);
                                break;

                            case 11:
                                // Code for "Search Book by ISBN Number" option
                                Console.Write("Enter the ISBN of the book:");
                                long searchIsbn = long.Parse(Console.ReadLine());

                                library.SearchBookByISBN(searchIsbn);
                                break;

                            case 12:
                                // Code for "Search Book by Genre" option
                                Console.Write("Enter the Genre of the book:");
                                string searchGenre = Console.ReadLine();

                                library.SearchBookByGenre(searchGenre);
                                break;

                            case 13:
                                // exit to Main Menu
                                adminMenuExit = true;
                                break;

                            default:
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Please enter a number from the menu.");
                    break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Exiting the program. Press any key to close...");
        
        Console.ReadKey();

    }
}