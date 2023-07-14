using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Library library = new Library();
        LibraryMember activeMember = null;

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
                    Console.Write("First name: ");
                    string newMemberFirstName = Console.ReadLine();

                    Console.Write("Last name: ");
                    string newMemberLastName = Console.ReadLine();

                    Console.Write("Enter Email Address (this will be your ID): ");
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

                        Console.WriteLine("6. Exit to main menu ");
                        Console.WriteLine(" ");
                        Console.Write("Select a number choice from the menu: ");
                        int memberMenuChoice = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (memberMenuChoice)
                        {
                            case 1:
                                // search book by title
                                Console.WriteLine("Enter the title of the book:");
                                string searchTitle = Console.ReadLine();

                                library.SearchBookByTitle(searchTitle);

                                break;

                            case 2:
                                // search book by author
                                Console.WriteLine("Enter the Author of the book:");
                                string searchAuthor = Console.ReadLine();

                                library.SearchBookByAuthor(searchAuthor);
                                break;

                            case 3:
                                // search book by isbn number
                                Console.WriteLine("Enter the ISBN of the book:");
                                long searchIsbn = long.Parse(Console.ReadLine());

                                library.SearchBookByISBN(searchIsbn);
                                break;

                            case 4:
                                // search book by genre
                                Console.WriteLine("Enter the Genre of the book:");
                                string searchGenre = Console.ReadLine();

                                library.SearchBookByGenre(searchGenre);
                                break;

                            case 5:
                                // Display currently borrowed books
                                LibraryMember.DisplayBorrowedBooks();
                                break;

                            case 6:
                                //Check-out Books
                                //LibraryMember.BorrowBook();
                                break;

                            case 7:
                                //Check-in Books
                                //LibraryMember.ReturnBook();
                                
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

                    //Display the Library Admin menu.
                    // Manually Add a Book
                    // Remove a Book
                    // Add a Member
                    // Remove a Member
                    // Save or Load Member list use FileManager class
                    // Save or Load Book List use FileManager class
                    // Display checked out Books
                    // Check back in borrowed book by members
                    // search book by author
                    // search book by title
                    // search book by isbn number
                    // search book by genre

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