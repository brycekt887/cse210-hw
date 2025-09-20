using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string Grader = "";

        if (percent >= 90)
        {
            Grader = "A";
        }
        else if (percent >= 80)
        {
            Grader = "B";
        }
        else if (percent >= 70)
        {
            Grader = "C";
        }
        else if (percent >= 60)
        {
            Grader = "D";
        }
        else
        {
           Grader = "F";
        }

        Console.WriteLine($"Your grade is: {Grader}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("O no! Better Luck Next Time");
        }
    }
}