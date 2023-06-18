using System;
using System.Collections.Generic;
using System.Threading;
//Derive class
public class ListingActivity:Activity
{
    private string[] prompts =
    {
        "Who are people that you appreciate ?",
        "What are personal strengths of yours ?",
        "Who are people that you have helped this week ?",
        "When hsve you felt the Holy Ghost this month ?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base(" Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    public override void Start()
    {
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine("Get ready...");
        Pause(3);
        PerformActivity();
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {name} for {duration} seconds.");
        Pause(3);
    }
    private void PerformActivity()
    {
        Random random = new Random();
        int remainingSeconds = duration;
        int itemCount = 0;

        while (remainingSeconds > 0)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            ShowCountdown(5);

            Console.WriteLine("Start Listing items (press Enter after item, type 'done' to finish): ");

            string item = Console.ReadLine();
            while (item.ToLower()  != "done") 
            {
                itemCount++;
                item = Console.ReadLine();
            }

            remainingSeconds -= 10;
        }
        Console.WriteLine($"You listed {itemCount} items.");
    }
}