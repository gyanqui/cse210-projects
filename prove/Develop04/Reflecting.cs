using System;
using System.Collections.Generic;
using System.Threading;
//Derive class
public class ReflectingActivity :Activity
{
    private string[] prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",    
        "Think of a time when you did something truly selfless."
    };
    private string[] questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before",
        "How did you get started?",
        "How did it feel when it was complete?",
        "What made this time different than other times when you were not as succesful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity():base(" Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.\r\n ") 
        {

        }

    public override void Start()
    {
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine("Get ready ...");
        Pause(3);
        PerformActivity(this);
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completd {name} for {duration} seconds.");
        Pause(3);

    Private  PerformActivity()
        {
            Random random = new Random();
            int remainingSeconds = duration;

            while (remainingSeconds > 0) 
            {
                string prompt =prompts[random.Next(prompts.Length)];
                Console.WriteLine(prompt);
                ShowSpinner(3);

                foreach (string question in @this.questions)
                {
                    Console.WriteLine(question);
                    ShowSpinner(3);
                }
                remainingSeconds-= 30;
            }
        
        }
    }

}