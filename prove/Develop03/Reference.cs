using System;

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference()
    {
        Console.WriteLine("Hello Develop03 World!");
    }

    public override string ToString()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse}";
        }
        
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }

    }
    
}