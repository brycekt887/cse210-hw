using System;

public class Comment
{
    // matches: name, text
    private string name;
    private string text;

    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine(name + " - " + text);
    }
}
