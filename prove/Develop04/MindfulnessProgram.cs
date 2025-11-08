using System;

// Main program that runs eveything
public class MindfulnessProgram
{
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("-------------------");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
    }

    public void RunActivity(int choice)
    {
        switch (choice)
        {
            case 1:
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by guiding you through slow breathing."
                );
                breathing.RunBreathingCycle();
                break;

            case 2:
                ReflectionActivity reflection = new ReflectionActivity(
                    "Reflection Activity",
                    "This activity helps you think about times you’ve shown strength and resilience."
                );
                reflection.Start();
                reflection.DisplayPrompt();
                reflection.DisplayQuestions();
                reflection.End();
                break;

            case 3:
                ListingActivity listing = new ListingActivity(
                    "Listing Activity",
                    "This activity helps you think about the good things in your life."
                );
                listing.Start();
                listing.DisplayPrompt();
                listing.CollectResponses();
                listing.DisplaySummary();
                listing.End();
                break;

            case 4:
                Console.WriteLine("\nThanks for using the Mindfulness Program!");
                break;

            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }

    public static void Main()
    {
        MindfulnessProgram program = new MindfulnessProgram();
        int choice = 0;

        while (choice != 4)
        {
            program.DisplayMenu();
            Console.Write("Choose an option (1–4): ");
            string input = Console.ReadLine() ?? "4";
            int.TryParse(input, out choice);

            program.RunActivity(choice);
        }
    }
}
