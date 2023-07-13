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

    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }

    public void SearchBookByTitle(string title)
    {
        foreach (Book book in _books) {
            if (book.Title == title) {
                book.DisplayBookDetails();
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    public void SearchBookByAuthor(string author) {
        foreach (Book book in _books) {
            if (book.Author == author) {
                book.DisplayBookDetails();
                return;
            }
        }
        Console.WriteLine("No books found by the author.");
    }

    public void SearchBookByISBN(long isbn)
    {
        foreach (Book book in _books)
        {   
            if (book.ISBN == isbn) {
                book.DisplayBookDetails();
                return;
            }
        }
        Console.WriteLine("No books found by that ISBN number.");
    }

    public void SearchBookByGenre(string genre) {
        foreach (Book book in _books) {
            if (book.Genre == genre) {
                book.DisplayBookDetails();
            }
        }
        Console.WriteLine("No books found by that genre.");
    }

    public static void AddMember(LibraryMember member)
    {
        _members.Add(member);
    } 

    public void RemoveMember(LibraryMember member)
    {
        _members.Remove(member);
    }

    public void SaveData()
    {
        _fileManager.SaveBooks(_books);
        _fileManager.SaveMembers(_members);
    }

     public void LoadData() {
        _books = _fileManager.LoadBooks();
        _members = _fileManager.LoadMembers();
    }

    private void InitializeMembers()
    {
        AddMember(new LibraryMember("John", "Doe", "John.Doe@email.com"));
        AddMember(new LibraryMember("Jane", "Smith", "Jane.Smith@email.com"));
    }

    private void InitializeBooks()
    {
        // Fiction Books

        // Create instances of Fiction books
        FictionBook greatGatsby = new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 9780743273565, "Fiction");
        FictionBook toKillAMockingbird = new FictionBook("To Kill a Mockingbird", "Harper Lee", 9780061120084, "Fiction");
        FictionBook prideAndPrejudice = new FictionBook("Pride and Prejudice", "Jane Austen", 9780141439518, "Fiction");
        FictionBook catcherInTheRye = new FictionBook("The Catcher in the Rye", "J.D. Salinger", 9780316769488, "Fiction");
        FictionBook lordOfTheRings = new FictionBook("The Lord of the Rings", "J.R.R. Tolkien", 9780345339706, "Fiction");
        FictionBook harryPotter = new FictionBook("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 9780590353427, "Fiction");
        FictionBook daVinciCode = new FictionBook("The Da Vinci Code", "Dan Brown", 9780307474278, "Fiction");
        FictionBook goneGirl = new FictionBook("Gone Girl", "Gillian Flynn", 9780307588371, "Fiction");
        FictionBook kiteRunner = new FictionBook("The Kite Runner", "Khaled Hosseini", 9781594631931, "Fiction");
        FictionBook girlOnTheTrain = new FictionBook("The Girl on the Train", "Paula Hawkins", 9781594634024, "Fiction");

        // Add the Fiction books to the library
        Library.addBook(greatGatsby);
        Library.addBook(toKillAMockingbird);
        Library.addBook(prideAndPrejudice);
        Library.addBook(catcherInTheRye);
        Library.addBook(lordOfTheRings);
        Library.addBook(harryPotter);
        Library.addBook(daVinciCode);
        Library.addBook(goneGirl);
        Library.addBook(kiteRunner);
        Library.addBook(girlOnTheTrain);
    

        // Mystery Books
        MysteryBook girlWithDragonTattoo = new MysteryBook("The Girl with the Dragon Tattoo", "Stieg Larsson", 9780307454546, "Mystery");
        MysteryBook silentPatient = new MysteryBook("The Silent Patient", "Alex Michaelides", 9781250301697, "Mystery");
        MysteryBook bigLittleLies = new MysteryBook("Big Little Lies", "Liane Moriarty", 9780399587207, "Mystery");
        MysteryBook inTheWoods = new MysteryBook("In the Woods", "Tana French", 9780143113492, "Mystery");
        MysteryBook cuckoosCalling = new MysteryBook("The Cuckoo's Calling", "Robert Galbraith (J.K. Rowling)", 9780316206853, "Mystery");
        MysteryBook gone = new MysteryBook("Gone", "Lisa Gardner", 9780553840832, "Mystery");
        MysteryBook ladiesDetectiveAgency = new MysteryBook("The No. 1 Ladies' Detective Agency", "Alexander McCall Smith", 9781400034772, "Mystery");
        MysteryBook secretHistory = new MysteryBook("The Secret History", "Donna Tartt", 9781400031702, "Mystery");
        MysteryBook dry = new MysteryBook("The Dry", "Jane Harper", 9781250105608, "Mystery");
        MysteryBook snowman = new MysteryBook("The Snowman", "Jo Nesbo", 9780385342995, "Mystery");

        // Add the Mystery books to the library.
        Library.addBook(girlWithDragonTattoo);
        Library.addBook(silentPatient);
        Library.addBook(bigLittleLies);
        Library.addBook(inTheWoods);
        Library.addBook(cuckoosCalling);
        Library.addBook(gone);
        Library.addBook(ladiesDetectiveAgency);
        Library.addBook(secretHistory);
        Library.addBook(dry);
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
        NonFictionBook sapiens = new NonFictionBook("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", 9780062316110, "Non-Fiction");
        NonFictionBook educated = new NonFictionBook("Educated: A Memoir", "Tara Westover", 9780399590504, "Non-Fiction");
        NonFictionBook becoming = new NonFictionBook("Becoming", "Michelle Obama", 9781524763138, "Non-Fiction");
        NonFictionBook immortalLife = new NonFictionBook("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", 9781400052189, "Non-Fiction");
        NonFictionBook quiet = new NonFictionBook("Quiet: The Power of Introverts in a World That Can't Stop Talking", "Susan Cain", 9780307352156, "Non-Fiction");
        NonFictionBook fiveLoveLanguages = new NonFictionBook("The Five Love Languages: The Secret to Love That Lasts", "Gary Chapman", 9780802412706, "Non-Fiction");
        NonFictionBook sapiensGraphic = new NonFictionBook("Sapiens: A Graphic History: The Birth of Humankind", "Yuval Noah Harari and David Vandermeulen", 9780063051331, "Non-Fiction");
        NonFictionBook homoDeus = new NonFictionBook("Homo Deus: A Brief History of Tomorrow", "Yuval Noah Harari", 9780062464347, "Non-Fiction");
        NonFictionBook justMercy = new NonFictionBook("Just Mercy: A Story of Justice and Redemption", "Bryan Stevenson", 9780812984965, "Non-Fiction");

        Library.addBook(sapiens);
        Library.addBook(educated);
        Library.addBook(becoming);
        Library.addBook(immortalLife);
        Library.addBook(quiet);
        Library.addBook(fiveLoveLanguages);
        Library.addBook(sapiensGraphic);
        Library.addBook(homoDeus);
        Library.addBook(justMercy);
        
        // Biography Books
        BiographyBook diaryOfYoungGirl = new BiographyBook("The Diary of a Young Girl", "Anne Frank", 9780553577129, "Biography");
        BiographyBook glassCastle = new BiographyBook("The Glass Castle: A Memoir", "Jeannette Walls", 9780743247542, "Biography");
        BiographyBook unbroken = new BiographyBook("Unbroken: A World War II Story of Survival, Resilience, and Redemption", "Laura Hillenbrand", 9780812974492, "Biography");
        BiographyBook steveJobs = new BiographyBook("Steve Jobs", "Walter Isaacson", 9781451648539, "Biography");
        BiographyBook bornACrime = new BiographyBook("Born a Crime: Stories from a South African Childhood", "Trevor Noah", 9780399588174, "Biography");
        BiographyBook autobiographyMalcolmX = new BiographyBook("The Autobiography of Malcolm X", "Malcolm X and Alex Haley", 9780345350688, "Biography");
        BiographyBook leonardoDaVinci = new BiographyBook("Leonardo da Vinci", "Walter Isaacson", 9781501139154, "Biography");
        BiographyBook educated1 = new BiographyBook("Educated: A Memoir", "Tara Westover", 9780399590504, "Biography");
        BiographyBook immortalLife1 = new BiographyBook("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", 9781400052189, "Biography");
        BiographyBook quietStrength = new BiographyBook("Quiet Strength: The Principles, Practices, and Priorities of a Winning Life", "Tony Dungy", 9781414318011, "Biography");

        Library.addBook(diaryOfYoungGirl);
        Library.addBook(glassCastle);
        Library.addBook(unbroken);
        Library.addBook(steveJobs);
        Library.addBook(bornACrime);
        Library.addBook(autobiographyMalcolmX);
        Library.addBook(leonardoDaVinci);
        Library.addBook(educated1);
        Library.addBook(immortalLife1);
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
        SelfHelpBook atomicHabits = new SelfHelpBook("Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", "James Clear", 9780735211292, "Self-help");
        SelfHelpBook powerOfNow = new SelfHelpBook("The Power of Now: A Guide to Spiritual Enlightenment", "Eckhart Tolle", 9781577314806, "Self-help");
        SelfHelpBook thinkAndGrowRich = new SelfHelpBook("Think and Grow Rich", "Napoleon Hill", 9781585424337, "Self-help");
        SelfHelpBook habitsOfEffectivePeople = new SelfHelpBook("The 7 Habits of Highly Effective People: Powerful Lessons in Personal Change", "Stephen R. Covey", 9781982137274, "Self-help");
        SelfHelpBook subtleArtOfNotGivingAFuck = new SelfHelpBook("The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life", "Mark Manson", 9780062457714, "Self-help");
        SelfHelpBook mansSearchForMeaning = new SelfHelpBook("Man's Search for Meaning", "Viktor E. Frankl", 9780807014295, "Self-help");
        SelfHelpBook youAreABadass = new SelfHelpBook("You Are a Badass: How to Stop Doubting Your Greatness and Start Living an Awesome Life", "Jen Sincero", 9780762447695, "Self-help");
        SelfHelpBook howToWinFriends = new SelfHelpBook("How to Win Friends and Influence People", "Dale Carnegie", 9780671027032, "Self-help");
        SelfHelpBook mindset = new SelfHelpBook("Mindset: The New Psychology of Success", "Carol S. Dweck", 9780345472328, "Self-help");
        SelfHelpBook fourAgreements = new SelfHelpBook("The Four Agreements: A Practical Guide to Personal Freedom", "Don Miguel Ruiz", 9781878424310, "Self-help");

        Library.addBook(atomicHabits);
        Library.addBook(powerOfNow);
        Library.addBook(thinkAndGrowRich);
        Library.addBook(habitsOfEffectivePeople);
        Library.addBook(subtleArtOfNotGivingAFuck);
        Library.addBook(mansSearchForMeaning);
        Library.addBook(youAreABadass);
        Library.addBook(howToWinFriends);
        Library.addBook(mindset);
        Library.addBook(fourAgreements);

    }
}
