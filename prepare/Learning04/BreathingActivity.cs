using System;

// This activity helps the user calm down and focus on breathing.
public class BreathingActivity : Activity
{
    private int _inhaleTime = 4;
    private int _exhaleTime = 6;

    public BreathingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void RunBreathingCycle()
    {
        Start();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(_inhaleTime);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            Countdown(_exhaleTime);
            Console.WriteLine();
        }

        End();
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
