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
         Random random = new Random();

        //get some randome numbers of words to hide.
        int wordsToHide = random.Next(1, 4);

        //get the list of non hidden words
        var nonHiddenWords = words.Where(word => !word.IsHidden).ToList();

        nonHiddenWords = nonHiddenWords.OrderBy(word => random.Next()).ToList();
        
        // Hide the first few words random list
        for (int i = 0; i < wordsToHide && i <nonHiddenWords.Count; i++)
        {
            nonHiddenWords[i].Hide();
        }
        
        
        
    }
}