using System;

class Library {

  private List<Book> books;

  public Library() {
    books = new List<Book>();
    initializeBooks();
  }

  public void addBook(Book book) {
    books.Add(book);
  }

  private void initializeBooks()
  {
    // Fiction Books
    addBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", "Fiction"));
    addBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", "Fiction"));
    addBook(new Book("Pride and Prejudice", "Jane Austen", "9780141439518", "Fiction"));
    addBook(new Book("The Catcher in the Rye", "J.D. Salinger", "9780316769488", "Fiction"));
    addBook(new Book("The Lord of the Rings", "J.R.R. Tolkien", "9780345339706", "Fiction"));
    addBook(new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "9780590353427", "Fiction"));
    addBook(new Book("The Da Vinci Code", "Dan Brown", "9780307474278", "Fiction"));
    addBook(new Book("Gone Girl", "Gillian Flynn", "9780307588371", "Fiction"));
    addBook(new Book("The Kite Runner", "Khaled Hosseini", "9781594631931", "Fiction"));
    addBook(new Book("The Girl on the Train", "Paula Hawkins", "9781594634024", "Fiction"));
    
    // Mystery Books
    addBook(new Book("The Girl with the Dragon Tattoo", "Stieg Larsson", "9780307454546", "Mystery"));
    addBook(new Book("The Silent Patient", "Alex Michaelides", "9781250301697", "Mystery"));
    addBook(new Book("Big Little Lies", "Liane Moriarty", "9780399587207", "Mystery"));
    addBook(new Book("In the Woods", "Tana French", "9780143113492", "Mystery"));
    addBook(new Book("The Cuckoo's Calling", "Robert Galbraith (J.K. Rowling)", "9780316206853", "Mystery"));
    addBook(new Book("Gone", "Lisa Gardner", "9780553840832", "Mystery"));
    addBook(new Book("The No. 1 Ladies' Detective Agency", "Alexander McCall Smith", "9781400034772", "Mystery"));
    addBook(new Book("The Secret History", "Donna Tartt", "9781400031702", "Mystery"));
    addBook(new Book("The Dry", "Jane Harper", "9781250105608", "Mystery"));
    addBook(new Book("The Snowman", "Jo Nesbø", "9780385342995", "Mystery"));
    
    // Science Fiction Books
    addBook(new Book("Dune", "Frank Herbert", "9780441172719", "Science Fiction"));
    addBook(new Book("1984", "George Orwell", "9780451524935", "Science Fiction"));
    addBook(new Book("Ender's Game", "Orson Scott Card", "9780765307695", "Science Fiction"));
    addBook(new Book("The Hunger Games", "Suzanne Collins", "9780439023528", "Science Fiction"));
    addBook(new Book("Brave New World", "Aldous Huxley", "9780060850524", "Science Fiction"));
    addBook(new Book("Neuromancer", "William Gibson", "9780441569595", "Science Fiction"));
    addBook(new Book("The War of the Worlds", "H.G. Wells", "9780141439976", "Science Fiction"));
    addBook(new Book("Snow Crash", "Neal Stephenson", "9780553380958", "Science Fiction"));
    addBook(new Book("Foundation", "Isaac Asimov", "9780553293357", "Science Fiction"));
    addBook(new Book("Ready Player One", "Ernest Cline", "9780307887436", "Science Fiction"));
    
    // Non-Fiction Books
    addBook(new Book("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "9780062316110", "Non-Fiction"));
    addBook(new Book("Educated: A Memoir", "Tara Westover", "9780399590504", "Non-Fiction"));
    addBook(new Book("Becoming", "Michelle Obama", "9781524763138", "Non-Fiction"));
    addBook(new Book("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", "97);89", "Non-Fiction"));
    addBook(new Book("Quiet: The Power of Introverts in a World That Can't Stop Talking", "Susan Cain", "9780307352156", "Non-Fiction"));
    addBook(new Book("The Five Love Languages: The Secret to Love That Lasts", "Gary Chapman", "9780802412706", "Non-Fiction"));
    addBook(new Book("Sapiens: A Graphic History: The Birth of Humankind", "Yuval Noah Harari and David Vandermeulen", "9780063051331", "Non-Fiction"));
    addBook(new Book("Homo Deus: A Brief History of Tomorrow", "Yuval Noah Harari", "9780062464347", "Non-Fiction"));
    addBook(new Book("Just Mercy: A Story of Justice and Redemption", "Bryan Stevenson", "9780812984965", "Non-Fiction"));
    
    // Biography Books
    addBook(new Book("The Diary of a Young Girl", "Anne Frank", "9780553577129", "Biography"));
    addBook(new Book("The Glass Castle: A Memoir", "Jeannette Walls", "9780743247542", "Biography"));
    addBook(new Book("Unbroken: A World War II Story of Survival, Resilience, and Redemption", "Laura Hillenbrand", "9780812974492", "Biography"));
    addBook(new Book("Steve Jobs", "Walter Isaacson", "9781451648539", "Biography"));
    addBook(new Book("Born a Crime: Stories from a South African Childhood", "Trevor Noah", "9780399588174", "Biography"));
    addBook(new Book("The Autobiography of Malcolm X", "Malcolm X and Alex Haley", "9780345350688", "Biography"));
    addBook(new Book("Leonardo da Vinci", "Walter Isaacson", "9781501139154", "Biography"));
    addBook(new Book("Educated: A Memoir", "Tara Westover", "9780399590504", "Biography"));
    addBook(new Book("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", "9781400052189", "Biography"));
    addBook(new Book("Quiet Strength: The Principles, Practices, and Priorities of a Winning Life", "Tony Dungy", "9781414318011", "Biography"));
  
    // Fantasy Books
    addBook(new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "9780590353427", "Fantasy"));
    addBook(new Book("The Hobbit", "J.R.R. Tolkien", "9780547928227", "Fantasy"));
    addBook(new Book("A Game of Thrones", "George R.R. Martin", "9780553381689", "Fantasy"));
    addBook(new Book("The Name of the Wind", "Patrick Rothfuss", "9780756404741", "Fantasy"));
    addBook(new Book("Mistborn: The Final Empire", "Brandon Sanderson", "9780765350381", "Fantasy"));
    addBook(new Book("American Gods", "Neil Gaiman", "9780380789030", "Fantasy"));
    addBook(new Book("The Way of Kings", "Brandon Sanderson", "9780765365279", "Fantasy"));
    addBook(new Book("The Lies of Locke Lamora", "Scott Lynch", "9780553588941", "Fantasy"));
    addBook(new Book("The Final Empire", "Michael J. Sullivan", "9780979621130", "Fantasy"));
    addBook(new Book("The Magicians", "Lev Grossman", "9780452296299", "Fantasy"));
    
    // Self-help Books
    addBook(new Book("Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", "James Clear", "9780735211292", "Self-help"));
    addBook(new Book("The Power of Now: A Guide to Spiritual Enlightenment", "Eckhart Tolle", "9781577314806", "Self-help"));
    addBook(new Book("Think and Grow Rich", "Napoleon Hill", "9781585424337", "Self-help"));
    addBook(new Book("The 7 Habits of Highly Effective People: Powerful Lessons in Personal Change", "Stephen R. Covey", "9781982137274", "Self-help"));
    addBook(new Book("The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life", "Mark Manson", "9780062457714", "Self-help"));
    addBook(new Book("Man's Search for Meaning", "Viktor E. Frankl", "9780807014295", "Self-help"));
    addBook(new Book("You Are a Badass: How to Stop Doubting Your Greatness and Start Living an Awesome Life", "Jen Sincero", "9780762447695", "Self-help"));
    addBook(new Book("How to Win Friends and Influence People", "Dale Carnegie", "9780671027032", "Self-help"));
    addBook(new Book("Mindset: The New Psychology of Success", "Carol S. Dweck", "9780345472328", "Self-help"));
    addBook(new Book("The Four Agreements: A Practical Guide to Personal Freedom", "Don Miguel Ruiz", "9781878424310", "Self-help"));
  }
}
