using System;
using System.Collections.Generic;

// This activity helps the user list things that are positive in their life.
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _responses = new List<string>();

    public ListingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Start listing in...");
        Countdown(3);
        Console.WriteLine("Go ahead and start listing items!");
    }

    public void CollectResponses()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _responses.Add(input);
            }
        }
    }

    public void DisplaySummary()
    {
        Console.WriteLine($"\nYou listed {_responses.Count} items!");
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
