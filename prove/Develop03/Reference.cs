using System;

class Reference
{
    // 
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string referenceId)
    {
        ParseReferenceId(referenceId);
    }

    private void ParseReferenceId(string referenceId)
    {
        string[] parts;

        if (char.IsDigit(referenceId[0]))
        {
            parts = referenceId.Split(' ',2);
        }
        else
        {
            int firstSpaceIndex = referenceId.IndexOf(' ');
            parts = new string[]
            {
                referenceId.Substring(0, firstSpaceIndex),
                referenceId.Substring(firstSpaceIndex + 1)
            };

        }
        //referenceId format is "<Book> <Chapter>:<StartVerse>-<EndVerse>"
        book = parts[0];
        string[] chapterVerseParts = parts[1].Split(':');
        chapter = int.Parse(chapterVerseParts[0]);

        string[] verseParts = chapterVerseParts[1].Split('-');
        startVerse = int.Parse(verseParts[0]);

        //only if there is a end verse do we parse it.
        endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : startVerse;

    }



    // custome ToString for this class use.
    public string GetReferenceText()
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