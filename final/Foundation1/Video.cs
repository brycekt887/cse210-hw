using System;
using System.Collections.Generic;

public class Video
{
    // matches: title, author, length, comments
    private string title;
    private string author;
    private int length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }

    public void AddComment(Comment c)
    {
        comments.Add(c);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine("---- Video ----");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + length + " seconds");
        Console.WriteLine("Number of comments: " + GetCommentCount());

        foreach (Comment c in comments)
        {
            c.DisplayComment();
        }

        Console.WriteLine();
    }
}
