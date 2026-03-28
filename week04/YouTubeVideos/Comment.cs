using System;

public class Comment
{
    private string _commenterName;
    private string _commenterText;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _commenterText = text;
    }

    public string GetDisplayText()
    {
        return $"{_commenterName}: {_commenterText}";
    }
}


