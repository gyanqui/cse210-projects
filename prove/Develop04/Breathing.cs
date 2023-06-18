using System;
public class BreathingActivity : Activity
{  
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void PromptBreathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();
        
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe in...");
        GenerateCountdownTimer(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        GenerateCountdownTimer(3);

        while (currentTime <= futureTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            GenerateCountdownTimer(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            GenerateCountdownTimer(6);
            currentTime = DateTime.Now;
        }
    }
}