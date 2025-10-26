using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------------------------------------------------------
        // Unit 03: Scripture Memorizer
        // Author: Bryce Taylor
        // Description: This program displays a scripture and hides
        // a few random words each time the user presses enter.
        // ---------------------------------------------------------

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        // The main loop runs until the user quits or all words are hidden
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide more words or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // hide a few each time

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are now hidden. Good job memorizing!");
                break;
            }
        }
    }
}
