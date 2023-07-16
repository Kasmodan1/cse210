using System;
using System.Collections.Generic;

class Library {

    private static List<Book> _books;
    private static List<LibraryMember> _members;
    private FileManager _fileManager;

    public Library() 
    {
        _books = new List<Book>();
        _members = new List<LibraryMember>();
        _fileManager = new FileManager();
        InitializeBooks();
        InitializeMembers();
    }

    public static void addBook(Book book) 
    {
        _books.Add(book);
    }

    public static void ManualAddBook()
    {
        Console.Write("Enter the book title:");
        string title = Console.ReadLine();

        Console.Write("Enter the book author:");
        string author = Console.ReadLine();

        Console.Write("Enter the book ISBN:");
        long isbn = long.Parse(Console.ReadLine());

        Console.Write("Enter the book availability (true/false):");
        bool isAvailable = bool.Parse(Console.ReadLine());

        
        Console.WriteLine("1. Fiction");
        Console.WriteLine("2. Non-Fiction");
        Console.WriteLine("3. Science Fiction");
        Console.WriteLine("4. Mystery");
        Console.WriteLine("5. Fantasy");
        Console.WriteLine("6. Biography");
        Console.WriteLine("7. Self-help");
        Console.Write("Enter the genre number:");

        int genreNumber = int.Parse(Console.ReadLine());
        
        switch (genreNumber)
        {
            case 1:

                Console.Write("Enter the target age for this book: ");
                int targetAge = Console.Read();
                string fictionGenre = "Fiction";
                FictionBook fiction = new FictionBook(title, author, isbn, fictionGenre, isAvailable, targetAge);
                Library.addBook(fiction);

                break;

            case 2:

                Console.Write("Enter the theme for this book: ");
                string nonFictionTheme = Console.ReadLine();
                string nonFictionGenre = "NonFiction";
                NonFictionBook nonfiction = new NonFictionBook(title, author, isbn, nonFictionGenre, isAvailable, nonFictionTheme);
                Library.addBook(nonfiction);
                break;

            case 3:

                Console.Write("Enter the target age for this book: ");
                int targetAge1 = Console.Read();
                Console.Write("Enter the science settings used in this book: ");
                string scienceSettings = Console.ReadLine();
                Console.Write("Enter the science technology used in this book: ");
                string scienceTechnology = Console.ReadLine();
                string scienceGenre = "Science Fiction";
                ScienceFictionBook scienceFiction = new ScienceFictionBook(title, author, isbn, scienceGenre, isAvailable, targetAge1);
                scienceFiction.SetScienceSettings(scienceSettings);
                scienceFiction.SetScienceTechnology(scienceTechnology);
                Library.addBook(scienceFiction);

                break;

            case 4:

                Console.Write("Enter the target age for this book: ");
                int targetAge2 = Console.Read();
                Console.Write("Enter the Detective used in this book: ");
                string mysteryDetective = Console.ReadLine();
                Console.Write("Enter the Crime types used in this book: ");
                string mysteryCrime = Console.ReadLine();
                string mysteryGenre = "Mystery";
                MysteryBook mystery = new MysteryBook(title, author, isbn, mysteryGenre, isAvailable, targetAge2);
                mystery.SetDetective(mysteryDetective);
                mystery.SetCrime(mysteryCrime);
                Library.addBook(mystery);

                break;

            case 5:

                Console.Write("Enter the target age for this book: ");
                int targetAge3 = Console.Read();
                Console.Write("Enter the fantasy creatures used in this book: ");
                string fantasyCreatures = Console.ReadLine();
                Console.Write("Enter the fantasy world used in this book: ");
                string fantasyWorld = Console.ReadLine();
                string fantasyGenre = "Fantasy";
                FantasyBook fantasy = new FantasyBook(title, author, isbn, fantasyGenre, isAvailable, targetAge3);
                fantasy.SetMagicalCreatures(fantasyCreatures);
                fantasy.SetMythicalWorld(fantasyWorld);
                Library.addBook(fantasy);

                break;

            case 6:

                Console.Write("Enter the theme for this book: ");
                string biographyTheme = Console.ReadLine();
                Console.Write("Enter the Subject for this book: ");
                string biographySubject = Console.ReadLine();
                string biographygenre = "Biography";

                BiographyBook biography = new BiographyBook(title, author, isbn, biographygenre, isAvailable, biographyTheme);
                biography.SetSubject(biographySubject);
                Library.addBook(biography);
                break;

            case 7:

                Console.Write("Enter the theme for this book: ");
                string selfHelpTheme = Console.ReadLine();
                Console.Write("Enter the Topic for this book: ");
                string selfHelpTopic = Console.ReadLine();
                string selfHelpgenre = "Self-help";

                SelfHelpBook selfHelp = new SelfHelpBook(title, author, isbn, selfHelpgenre, isAvailable, selfHelpTheme);
                selfHelp.SetTopic(selfHelpTopic);
                Library.addBook(selfHelp);
                break;

            default:
                Console.WriteLine("Invalid genre number. Book will be added as a general Book.");
                break;
        }
    }

    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }

    public List<Book> SearchBookByTitle(string title)
    {
        List<Book> matchingBooks = new List<Book>();

        foreach (Book book in _books) 
        {
            if (book.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0) 
            {
                book.DisplayBookDetails();
                matchingBooks.Add(book);
            }
        }

        if (matchingBooks.Count == 0)
        {
            Console.WriteLine("No books found with the specified title.");
        }

        return matchingBooks;
    }

    public List<Book> SearchBookByAuthor(string author) 
    {
        List<Book> matchingBooks = new List<Book>();

        foreach (Book book in _books) 
        {
            if (book.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0) 
            {
                book.DisplayBookDetails();
                matchingBooks.Add(book);
            }
        }

        if (matchingBooks.Count == 0)
        {
           Console.WriteLine("No books found by the author."); 
        }

        return matchingBooks;
    }

    public List<Book> SearchBookByISBN(long isbn)
    {   
        List<Book> matchingBooks = new List<Book>();

        string searchISBN = isbn.ToString();

        foreach (Book book in _books)
        {   
            if (book.ISBN.ToString().Contains(searchISBN)) 
            {
                book.DisplayBookDetails();
                matchingBooks.Add(book);
            }
        }

        if (matchingBooks.Count == 0)
        {
            Console.WriteLine("No books found by that ISBN number.");
        }

        return matchingBooks;
    }

    public List<Book> SearchBookByGenre(string genre) 
    {
        List<Book> matchingBooks = new List<Book>();

        foreach (Book book in _books) 
        {
            if (book.Genre.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0) 
            {
                book.DisplayBookDetails();
                matchingBooks.Add(book);
            }
        }
        
        if (matchingBooks.Count == 0)
        {
            Console.WriteLine("No books found by that genre.");
        }
       
        return matchingBooks;
    }

    public static void AddMember(LibraryMember member)
    {
        _members.Add(member);
    } 

    public bool RemoveMember(string memberId)
    {
       LibraryMember memberToRemove = GetMemberByID(memberId);
       if (memberToRemove != null)
       {
            _members.Remove(memberToRemove);
            Console.WriteLine("The chosen Member has been removed successfully.");
            return true;
       }
       else
       {
            Console.WriteLine("Member not found or unable to remove.");
            return false;
       }
    }

    public void SaveMember()
    {
        _fileManager.SaveMembers(_members);
    }

    public void SaveBook()
    {
        _fileManager.SaveBooks(_books);
    }


    public void LoadBook() 
    {
        _books = _fileManager.LoadBooks();
    }

    public void LoadMember() 
    {
        _members = _fileManager.LoadMembers();
    }

    public LibraryMember GetMemberByID(string memberId)
    {
        foreach (LibraryMember member in _members)
        {
            if (member._libraryid == memberId)
            {
                return member;
            }
        }
        return null;
    }

    public static List<LibraryMember> GetMembers()
    {
        return _members;
    }
            
    public static LibraryMember GetMemberByBook(Book book)
    {
        foreach (LibraryMember member in _members)
        {
            if (member.HasBorrowedBook(book))
            {
                return member;
            }
        }

        return null; // Book not found in any member's borrowed books
    }

    private void InitializeMembers()
    {
        AddMember(new LibraryMember("John", "Doe", "John.Doe@email.com"));
        AddMember(new LibraryMember("Jane", "Smith", "Jane.Smith@email.com"));
    }

    private void InitializeBooks()
    {
        // Fiction Books
        FictionBook book1 = new FictionBook("To Kill a Mockingbird", "Harper Lee", 9780061120084, "Fiction", true, 14);
        Library.addBook(book1);

        FictionBook book2 = new FictionBook("Pride and Prejudice", "Jane Austen", 9780141439518, "Fiction", true, 16);
        Library.addBook(book2);

        FictionBook book3 = new FictionBook("The Catcher in the Rye", "J.D. Salinger", 9780316769488, "Fiction", true, 16);

        Library.addBook(book3);
        FictionBook book4 = new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 9780743273565, "Fiction", true, 18);

        Library.addBook(book4);
        FictionBook book5 = new FictionBook("To the Lighthouse", "Virginia Woolf", 9780156907392, "Fiction", true, 16);

        Library.addBook(book5);
        FictionBook book6 = new FictionBook("Brave New World", "Aldous Huxley", 9780060850524, "Fiction", true, 18);

        Library.addBook(book6);
        FictionBook book7 = new FictionBook("The Picture of Dorian Gray", "Oscar Wilde", 9780141439570, "Fiction", true, 18);

        Library.addBook(book7);
        FictionBook book8 = new FictionBook("One Hundred Years of Solitude", "Gabriel Garcia Marquez", 9780060883287, "Fiction", true, 18);

        Library.addBook(book8);
        FictionBook book9 = new FictionBook("The Alchemist", "Paulo Coelho", 9780062315007, "Fiction", true, 14);
        Library.addBook(book9);

        FictionBook book10 = new FictionBook("The Handmaid's Tale", "Margaret Atwood", 9780385490818, "Fiction", true, 16);
        Library.addBook(book10);       


        // Mystery Books
        MysteryBook girlWithDragonTattoo = new MysteryBook("The Girl with the Dragon Tattoo", "Stieg Larsson", 9780307454546, "Mystery", true, 18);
        girlWithDragonTattoo.SetDetective("Lisbeth Salander");
        girlWithDragonTattoo.SetCrime("Murder mystery");
        Library.addBook(girlWithDragonTattoo);

        MysteryBook silentPatient = new MysteryBook("The Silent Patient", "Alex Michaelides", 9781250301697, "Mystery", true, 16);
        silentPatient.SetDetective("Theo Faber");
        silentPatient.SetCrime("Psychological thriller");
        Library.addBook(silentPatient);

        MysteryBook bigLittleLies = new MysteryBook("Big Little Lies", "Liane Moriarty", 9780399587207, "Mystery", true, 16);
        bigLittleLies.SetDetective("Madeline Martha Mackenzie");
        bigLittleLies.SetCrime("Domestic suspense");
        Library.addBook(bigLittleLies);

        MysteryBook inTheWoods = new MysteryBook("In the Woods", "Tana French", 9780143113492, "Mystery", true, 18);
        inTheWoods.SetDetective("Rob Ryan");
        inTheWoods.SetCrime("Missing children");
        Library.addBook(inTheWoods);

        MysteryBook cuckoosCalling = new MysteryBook("The Cuckoo's Calling", "Robert Galbraith (J.K. Rowling)", 9780316206853, "Mystery", true, 16);
        cuckoosCalling.SetDetective("Cormoran Strike");
        cuckoosCalling.SetCrime("Private investigator");
        Library.addBook(cuckoosCalling);

        MysteryBook gone = new MysteryBook("Gone", "Lisa Gardner", 9780553840832, "Mystery", true, 16);
        gone.SetDetective("D.D. Warren");
        gone.SetCrime("Serial killer");
        Library.addBook(gone);

        MysteryBook no1LadiesDetectiveAgency = new MysteryBook("The No. 1 Ladies' Detective Agency", "Alexander McCall Smith", 9781400034772, "Mystery", true, 14);
        no1LadiesDetectiveAgency.SetDetective("Precious Ramotswe");
        no1LadiesDetectiveAgency.SetCrime("Botswana mysteries");
        Library.addBook(no1LadiesDetectiveAgency);

        MysteryBook secretHistory = new MysteryBook("The Secret History", "Donna Tartt", 9781400031702, "Mystery", true, 18);
        secretHistory.SetDetective("No specific detective");
        secretHistory.SetCrime("Campus murder");
        Library.addBook(secretHistory);

        MysteryBook theDry = new MysteryBook("The Dry", "Jane Harper", 9781250105608, "Mystery", true, 16);
        theDry.SetDetective("Aaron Falk");
        theDry.SetCrime("Small-town secrets");
        Library.addBook(theDry);


        MysteryBook snowman = new MysteryBook("The Snowman", "Jo Nesbo", 9780385342995, "Mystery", true, 18);
        snowman.SetDetective("Harry Hole");
        snowman.SetCrime("Serial killer");
        Library.addBook(snowman);


        // Add Science Fiction books to the library.
        ScienceFictionBook dune = new ScienceFictionBook("Dune", "Frank Herbert", 9780441172719, "Science Fiction", true, 14);
        dune.SetScienceSettings("Arrakis (Dune)");
        dune.SetScienceTechnology("Advanced interstellar travel, prescience");
        Library.addBook(dune);

        ScienceFictionBook nineteenEightyFour = new ScienceFictionBook("1984", "George Orwell", 9780451524935, "Science Fiction",true, 16);
        nineteenEightyFour.SetScienceSettings("Dystopian society");
        nineteenEightyFour.SetScienceTechnology("Surveillance technology");
        Library.addBook(nineteenEightyFour);

        ScienceFictionBook endersGame = new ScienceFictionBook("Ender's Game", "Orson Scott Card", 9780765307695, "Science Fiction",true, 12);
        endersGame.SetScienceSettings("Battles in space");
        endersGame.SetScienceTechnology("Advanced military training");
        Library.addBook(endersGame);
        
        ScienceFictionBook hungerGames = new ScienceFictionBook("The Hunger Games", "Suzanne Collins", 9780439023528, "Science Fiction", true, 13);
        hungerGames.SetScienceSettings("Dystopian society, survival games");
        hungerGames.SetScienceTechnology("Advanced weaponry, genetic engineering");
        Library.addBook(hungerGames);

        ScienceFictionBook braveNewWorld = new ScienceFictionBook("Brave New World", "Aldous Huxley", 9780060850524, "Science Fiction", true, 16);
        braveNewWorld.SetScienceSettings("Dystopian society, genetic engineering");
        braveNewWorld.SetScienceTechnology("Advanced reproductive technology, mind control");
        Library.addBook(braveNewWorld);

        ScienceFictionBook neuromancer = new ScienceFictionBook("Neuromancer", "William Gibson", 9780441569595, "Science Fiction", true, 18);
        neuromancer.SetScienceSettings("Cyberpunk, virtual reality");
        neuromancer.SetScienceTechnology("Hacking, artificial intelligence");
        Library.addBook(neuromancer);

        ScienceFictionBook warOfTheWorlds = new ScienceFictionBook("The War of the Worlds", "H.G. Wells", 9780141439976, "Science Fiction", true, 14);
        warOfTheWorlds.SetScienceSettings("Martian invasion");
        warOfTheWorlds.SetScienceTechnology("Alien technology");
        Library.addBook(warOfTheWorlds);

        ScienceFictionBook snowCrash = new ScienceFictionBook("Snow Crash", "Neal Stephenson", 9780553380958, "Science Fiction", true, 17);
        snowCrash.SetScienceSettings("Virtual reality, cyberpunk");
        snowCrash.SetScienceTechnology("Linguistics, computer viruses");
        Library.addBook(snowCrash);

        ScienceFictionBook foundation = new ScienceFictionBook("Foundation", "Isaac Asimov", 9780553293357, "Science Fiction", true, 15);
        foundation.SetScienceSettings("Galactic empire, psychohistory");
        foundation.SetScienceTechnology("Advanced science, space travel");
        Library.addBook(foundation);

        ScienceFictionBook readyPlayerOne = new ScienceFictionBook("Ready Player One", "Ernest Cline", 9780307887436, "Science Fiction", true, 13);
        readyPlayerOne.SetScienceSettings("Virtual reality, dystopian society");
        readyPlayerOne.SetScienceTechnology("Virtual reality gaming, immersive technology");
        Library.addBook(readyPlayerOne);


        // Non-Fiction Books
        NonFictionBook sapiens = new NonFictionBook("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", 9780062316110, "Non-Fiction", true, "Human history");
        Library.addBook(sapiens);

        NonFictionBook educated = new NonFictionBook("Educated: A Memoir", "Tara Westover", 9780399590504, "Non-Fiction", true, "Personal growth");
        Library.addBook(educated);

        NonFictionBook becoming = new NonFictionBook("Becoming", "Michelle Obama", 9781524763138, "Non-Fiction", true, "Autobiography");
        Library.addBook(becoming);

        NonFictionBook immortalLife = new NonFictionBook("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", 9781400052189, "Non-Fiction", true, "Medical ethics");
        Library.addBook(immortalLife);

        NonFictionBook quiet = new NonFictionBook("Quiet: The Power of Introverts in a World That Can't Stop Talking", "Susan Cain", 9780307352156, "Non-Fiction", true, "Introversion");
        Library.addBook(quiet);
        
        NonFictionBook fiveLoveLanguages = new NonFictionBook("The Five Love Languages: The Secret to Love That Lasts", "Gary Chapman", 9780802412706, "Non-Fiction", true, "Relationships");
        Library.addBook(fiveLoveLanguages);

        NonFictionBook sapiensGraphic = new NonFictionBook("Sapiens: A Graphic History: The Birth of Humankind", "Yuval Noah Harari and David Vandermeulen", 9780063051331, "Non-Fiction", true, "Human history");
        Library.addBook(sapiensGraphic);

        NonFictionBook homoDeus = new NonFictionBook("Homo Deus: A Brief History of Tomorrow", "Yuval Noah Harari", 9780062464347, "Non-Fiction", true, "Future studies");
        Library.addBook(homoDeus);

        NonFictionBook justMercy = new NonFictionBook("Just Mercy: A Story of Justice and Redemption", "Bryan Stevenson", 9780812984965, "Non-Fiction", true, "Criminal justice");
        Library.addBook(justMercy);
        

        // Biography Books
        BiographyBook diaryOfYoungGirl = new BiographyBook("The Diary of a Young Girl", "Anne Frank", 9780553577129, "Biography", true, "World War II");
        diaryOfYoungGirl.SetSubject("Anne Frank");
        Library.addBook(diaryOfYoungGirl);

        BiographyBook glassCastle = new BiographyBook("The Glass Castle: A Memoir", "Jeannette Walls", 9780743247542, "Biography", true, "Family Dysfunction");
        glassCastle.SetSubject("Jeannette Walls");
        Library.addBook(glassCastle);

        BiographyBook unbroken = new BiographyBook("Unbroken: A World War II Story of Survival, Resilience, and Redemption", "Laura Hillenbrand", 9780812974492, "Biography", true, "World War II");
        unbroken.SetSubject("Louis Zamperini");
        Library.addBook(unbroken);

        BiographyBook steveJobs = new BiographyBook("Steve Jobs", "Walter Isaacson", 9781451648539, "Biography", true, "Entrepreneurship");
        steveJobs.SetSubject("Steve Jobs");
        Library.addBook(steveJobs);

        BiographyBook bornACrime = new BiographyBook("Born a Crime: Stories from a South African Childhood", "Trevor Noah", 9780399588174, "Biography", true, "Comedy");
        bornACrime.SetSubject("Trevor Noah");
        Library.addBook(bornACrime);

        BiographyBook autobiographyMalcolmX = new BiographyBook("The Autobiography of Malcolm X", "Malcolm X and Alex Haley", 9780345350688, "Biography", true, "Civil Rights Movement");
        autobiographyMalcolmX.SetSubject("Malcolm X");
        Library.addBook(autobiographyMalcolmX);

        BiographyBook leonardoDaVinci = new BiographyBook("Leonardo da Vinci", "Walter Isaacson", 9781501139154, "Biography", true, "Art");
        leonardoDaVinci.SetSubject("Leonardo da Vinci");
        Library.addBook(leonardoDaVinci);

        BiographyBook educated1 = new BiographyBook("Educated: A Memoir", "Tara Westover", 9780399590504, "Biography", true, "Education");
        educated1.SetSubject("Tara Westover");

        BiographyBook immortalLife1 = new BiographyBook("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", 9781400052189, "Biography", true, "Medical Ethics");
        immortalLife1.SetSubject("Henrietta Lacks");
        Library.addBook(educated1);

        BiographyBook quietStrength = new BiographyBook("Quiet Strength: The Principles, Practices, and Priorities of a Winning Life", "Tony Dungy", 9781414318011, "Biography", true, "Sports");
        quietStrength.SetSubject("Tony Dungy");
        Library.addBook(quietStrength);


        // Fantasy Books
        FantasyBook harryPotter1 = new FantasyBook("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 9780590353427, "Fantasy", true, 10);
        harryPotter1.SetMagicalCreatures("Dragons, Hippogriffs, Phoenixes");
        harryPotter1.SetMythicalWorld("Hogwarts School of Witchcraft and Wizardry");
        Library.addBook(harryPotter1);

        FantasyBook theHobbit = new FantasyBook("The Hobbit", "J.R.R. Tolkien", 9780547928227, "Fantasy", true, 12);
        theHobbit.SetMagicalCreatures("Dragons, Dwarves, Elves");
        theHobbit.SetMythicalWorld("Middle-earth");
        Library.addBook(theHobbit);

        FantasyBook gameOfThrones = new FantasyBook("A Game of Thrones", "George R.R. Martin", 9780553381689, "Fantasy", true, 18);
        gameOfThrones.SetMagicalCreatures("Dragons, Direwolves");
        gameOfThrones.SetMythicalWorld("Westeros");
        Library.addBook(gameOfThrones);

        FantasyBook nameOfTheWind = new FantasyBook("The Name of the Wind", "Patrick Rothfuss", 9780756404741, "Fantasy", true, 16);
        nameOfTheWind.SetMagicalCreatures("Arcanists, Chandrian");
        nameOfTheWind.SetMythicalWorld("The Four Corners of Civilization");
        Library.addBook(nameOfTheWind);

        FantasyBook mistborn = new FantasyBook("Mistborn: The Final Empire", "Brandon Sanderson", 9780765350381, "Fantasy", true, 14);
        mistborn.SetMagicalCreatures("Allomancers, Mistwraiths");
        mistborn.SetMythicalWorld("Scadrial");
        Library.addBook(mistborn);

        FantasyBook americanGods = new FantasyBook("American Gods", "Neil Gaiman", 9780380789030, "Fantasy", true, 18);
        americanGods.SetMagicalCreatures("Old Gods, New Gods");
        americanGods.SetMythicalWorld("Contemporary America");
        Library.addBook(americanGods);

        FantasyBook wayOfKings = new FantasyBook("The Way of Kings", "Brandon Sanderson", 9780765365279, "Fantasy", true, 16);
        wayOfKings.SetMagicalCreatures("Highspren, Chasmfiends");
        wayOfKings.SetMythicalWorld("Roshar");
        Library.addBook(wayOfKings);

        FantasyBook liesOfLockeLamora = new FantasyBook("The Lies of Locke Lamora", "Scott Lynch", 9780553588941, "Fantasy", true, 16);
        liesOfLockeLamora.SetMagicalCreatures("Thieves, Gentlemen Bastards");
        liesOfLockeLamora.SetMythicalWorld("Camorr");
        Library.addBook(liesOfLockeLamora);

        FantasyBook finalEmpire = new FantasyBook("The Final Empire", "Michael J. Sullivan", 9780979621130, "Fantasy", true, 14);
        finalEmpire.SetMagicalCreatures("Mistborn, Inquisitors");
        finalEmpire.SetMythicalWorld("The World of Elan");
        Library.addBook(finalEmpire);

        FantasyBook magicians = new FantasyBook("The Magicians", "Lev Grossman", 9780452296299, "Fantasy", true, 16);
        magicians.SetMagicalCreatures("Fillorians, Talking Animals");
        magicians.SetMythicalWorld("Brakebills College, Fillory");
        Library.addBook(magicians);
        

        // Self-help Books
        SelfHelpBook atomicHabits = new SelfHelpBook("Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", "James Clear", 9780735211292, "Self-help", true, "Personal Development");
        atomicHabits.SetTopic("Habit Formation");
        Library.addBook(atomicHabits);

        SelfHelpBook powerOfNow = new SelfHelpBook("The Power of Now: A Guide to Spiritual Enlightenment", "Eckhart Tolle", 9781577314806, "Self-help", true, "Spirituality");
        powerOfNow.SetTopic("Present-Moment Awareness");
        Library.addBook(powerOfNow);

        SelfHelpBook thinkAndGrowRich = new SelfHelpBook("Think and Grow Rich", "Napoleon Hill", 9781585424337, "Self-help", true, "Wealth Creation");
        thinkAndGrowRich.SetTopic("Success Mindset");
        Library.addBook(thinkAndGrowRich);

        SelfHelpBook habitsOfEffectivePeople = new SelfHelpBook("The 7 Habits of Highly Effective People: Powerful Lessons in Personal Change", "Stephen R. Covey", 9781982137274, "Self-help", true, "Personal Development");
        habitsOfEffectivePeople.SetTopic("Productivity and Leadership");
        Library.addBook(habitsOfEffectivePeople);

        SelfHelpBook subtleArtOfNotGiving = new SelfHelpBook("The Subtle Art of Not Giving: A Counterintuitive Approach to Living a Good Life", "Mark Manson", 9780062457714, "Self-help", true, "Personal Growth");
        subtleArtOfNotGiving.SetTopic("Positive Psychology");
        Library.addBook(subtleArtOfNotGiving);

        SelfHelpBook mansSearchForMeaning = new SelfHelpBook("Man's Search for Meaning", "Viktor E. Frankl", 9780807014295, "Self-help", true, "Existential Psychology");
        mansSearchForMeaning.SetTopic("Finding Meaning in Life");
        Library.addBook(mansSearchForMeaning);

        SelfHelpBook youAreABadass = new SelfHelpBook("You Are a Badass: How to Stop Doubting Your Greatness and Start Living an Awesome Life", "Jen Sincero", 9780762447695, "Self-help", true, "Self-Empowerment");
        youAreABadass.SetTopic("Self-Confidence");
        Library.addBook(youAreABadass);

        SelfHelpBook howToWinFriends = new SelfHelpBook("How to Win Friends and Influence People", "Dale Carnegie", 9780671027032, "Self-help", true, "Interpersonal Skills");
        howToWinFriends.SetTopic("Effective Communication");
        Library.addBook(howToWinFriends);

        SelfHelpBook mindset = new SelfHelpBook("Mindset: The New Psychology of Success", "Carol S. Dweck", 9780345472328, "Self-help", true, "Personal Development");
        mindset.SetTopic("Growth Mindset");
        Library.addBook(mindset);

        SelfHelpBook fourAgreements = new SelfHelpBook("The Four Agreements: A Practical Guide to Personal Freedom", "Don Miguel Ruiz", 9781878424310, "Self-help", true, "Spirituality");
        fourAgreements.SetTopic("Toltec Wisdom");
        Library.addBook(fourAgreements);
    }

}
