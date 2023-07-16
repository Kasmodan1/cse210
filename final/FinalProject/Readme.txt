I have created a Library System.

It starts out with a simple menu for the end user. They can create a new user or login as an existing user.

once they create a user they can do seachs for Title,author,ISBN and gerne. they can chech out books and display the ones checked out and also checkin books they
brought back to the Library to turn in.

There is also a Admin menu(4) to go into the admin Librarian fuctions.
The admin fuctions are:
("1. Manually Add a Book"); - this will walk the admin though manually adding new books into the system.
("2. Remove a Book"); - This will remove books
("3. Add a Member");- this will add memebers
("4. Remove a Member"); - remove any member
("5. Save or Load Member list"); - this will save or load memebers from a file.
("6. Save or Load Book List"); - this will save or load books from a file.
("7. Display Checked Out Books"); this will display checkout books and who checked them out.
("8. Check-in Borrowed Books"); this will return books from checked out members

 The Rest are seachs just like normal user.
("9. Search Book by Author");
("10. Search Book by Title");
("11. Search Book by ISBN Number");
("12. Search Book by Genre");


enhacements: - This project was super challenging!
-searches where exact and now are partial.
- display book content is polymorphic.
- added borrowing and returning books - abstract Polymorphism
-- because of this book class became an abstract class so had to redo other functions to accomidate that change.

I used this website for learning C# bits of info - https://learn.microsoft.com/en-us/dotnet/csharp/
also used = https://stackoverflow.com/ <- used this for errors I was getting and how to's none of it was coppied but understanding the logic on how to do it.

Known bugs - I was working on eliminating all know bugs but these are the only two I know of that I havent fixed yet.
- when logging into an existing user and logging out it does not ask you to login again so you can try other users.
- When checking out a book as a user then going into admin to check that book in, it is displaying the book but accociated with the wrong member that checked it out.




