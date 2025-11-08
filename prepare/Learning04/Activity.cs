using System;
using System.Threading;

// This is the base class for all activities.
// It handles things like the name, description, duration, and the spinner animation.
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        DisplayStartingMessage();
    }

    public void End()
    {
        DisplayEndingMessage();
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter how long you want to do this activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine() ?? "30");

        Console.WriteLine("\nGet ready to begin...");
        DisplayAnimation(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        DisplayAnimation(3);
        Console.WriteLine($"You finished the {_name} for {_duration} seconds!");
        DisplayAnimation(3);
    }

    protected void DisplayAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}
