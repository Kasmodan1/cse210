using System;
using System.Collections.Generic;
using System.Linq;

class Word
{
    public string Text { get; }
    public int Index { get; }
    public bool IsHidden {get; private set;}

    public Word(string text, int index)
    {
        Text = text;
        Index = index;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }
    public void Display()
    {
        if (IsHidden)
            Console.Write("____ ");
        else
            Console.Write(Text + " ");
    }
}
