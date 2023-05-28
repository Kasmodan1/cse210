using System;

class ReferenceIdentification
{
    // 
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ReferenceIdentification(string referenceIid)
    {
        string[] 
        
        
        Console.WriteLine("Hello Develop03 World!");
    }

    // custome ToString for this class use.
    public override string ToString()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

    }
    
}