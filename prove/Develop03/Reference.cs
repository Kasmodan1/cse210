using System;

class Reference
{
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
            int firstSpaceIndex = referenceId.IndexOf(' ');
            parts = new string[]
            {
                referenceId.Substring(0, firstSpaceIndex),
                referenceId.Substring(firstSpaceIndex + 1)
            };
            book = parts[0];
            string[] chapterVerseParts = parts[1].Split(':');
            string[] bookParts = chapterVerseParts[0].Split(' ');
            book = book + " " + bookParts[0];
            chapter = int.Parse(bookParts[1]);

            string[] verseParts = chapterVerseParts[1].Split('-');
            startVerse = int.Parse(verseParts[0]);

            // Remove the chapter and verse part, keeping only the book name
            //string[] bookParts = chapterVerseParts[0].Split(' ');
            //book = bookParts[1];

            // Only if there is an end verse do we parse it.
            if (verseParts.Length > 1)
            {
                endVerse = int.Parse(verseParts[1]);
            }
            else
            {
                endVerse = startVerse;
            }
        }
        else
        {
            parts = referenceId.Split(' ', 2);
            book = parts[0];
            string[] chapterVerseParts = parts[1].Split(':');
            chapter = int.Parse(chapterVerseParts[0]);

            string[] verseParts = chapterVerseParts[1].Split('-');
            startVerse = int.Parse(verseParts[0]);

            // Only if there is an end verse do we parse it.
            endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : startVerse;
        }
    }

    public string GetReferenceText()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse}";
        }
        else if (startVerse < endVerse)
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}";
        }
    }
}