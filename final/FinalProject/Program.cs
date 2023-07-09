using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
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
                    Console.WriteLine("First name?: ");
                    string newmemberfirstname = Console.ReadLine();

                    Console.WriteLine("Last name?: ");
                    string newmemberlastname = Console.ReadLine();

                    string newlibrarymemberid = "Enter Email Address this will be your ID ";

                    bool newmemberborrow = false;

                    Library member = new AddMember(newmemberfirstname, newmemberlastname, newlibrarymemberid, newmemberborrow);

                    member.AddMember(member);

                    Console.Write("New user has been created");
                    Console.Clear();
                        
                    break;

                case "2":
                    // create a while loop instead of if statments for case 2
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
                    Console.WriteLine("6. Exit to main menu ");
                    Console.WriteLine(" ");

                    Console.Write("which type of search would you like to do?: ");
                    int searchtype = int.Parse(Console.ReadLine());
                    Console.Clear();
                    
                    if (searchtype == 1)
                    // search book by title
                    {

                    }

                    else if (searchtype == 2)
                    // search book by author
                    {
                      
                    }

                    else if (searchtype == 3)
                    // search book by isbn number
                    {
                        
                    }

                    
                    else if (searchtype == 4)
                    // search book by genre
                    {
                        
                    }

                    else if (searchtype == 5)
                    // Display currently borrowed books
                    {
                        
                    }

                    
                    else if (searchtype == 6)
                    // exit to Main Menu
                    {
                        
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
                    // search by target age
                    // search by theme


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