using System;
using System.Collections.Generic;

public class Scripture
{
    
    private Reference _reference;
    private List<Word> _words;
    private string _memoryHint = "";

    public Scripture(Reference reference, string text)
    {
        
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split( " ");

        foreach (string part in parts)
        {
            Word word = new Word (part);
            _words.Add(word);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " " ;

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        int index = random.Next(_words.Count);

        _words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
        
    }   
    
    public string GetMemoryHint()
    {
        return _memoryHint;
    }

    public void SetMemoryHint(string hint)
    {
        _memoryHint = hint;
    }
}