using System;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    public bool AllWordsHidden => words.All(word => word.IsHidden);
    
    // construct will need the reference and text to store. I should brakes each word with an index to the word list
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select((wordText, index) => new Word(wordText, index)).ToList();
    }
    
    public void Display()
    {
        // get the references
        Console.WriteLine(reference.GetReferenceText());

        // go though each word in the words list
        foreach (var word in words)
        {
            word.Display();
        }
    }

    public void HideRandomWords()
    {
        foreach (var word in words.Where(word => !word.IsHidden))
        {
            word.Hide();
        }
    }
}