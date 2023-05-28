using System;

class Scripture
{
    private string reference;
    private List<Word> words;

    public bool AllWordsHidden => words.All(word => word.IsHidden);
    
    // construct will need the reference and text to store. I should brakes each word with an index to the word list
    public Scripture(string reference, string text)
    {
        // stores reference
        this.reference = reference;
        // looks for the spaces between each word then creates new word object for each word and stores in word list.
        words = text.Split(' ').Select((word, index) => new Word(word, index)).ToList();
        hiddenWord = new List<int>();
    }
    
    public void Display()
    {
        // get the references
        Console.WriteLine(reference);

        // go though each word in the words list
        foreach (var word in words)
        {
            //check if the word is hidden else display it
            if (hiddenWord.Contains(word.Index))
                Console.Write("____ ");
            else
                Console.Write(word.Text + " ");
        }
    }
}