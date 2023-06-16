using System;
using System.Collections.Generic;
using System.Threading; 

//Base class
public abstract class Activity 
{
    protected string name;
    public string description;
    protected int duration;


    public Activity (string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public abstract void Start();
        
    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void showSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        int animationIndex = 0;

        while (DateTime.Now < endTime)
        {
            string animation = animationStrings[animationIndex];
            Console.Write(animation);
            Thread.Sleep(250);
            Console.Write("\b \b");
            animationIndex = (animationIndex + 1) % animationStrings.Count;
        }
    }
    protected void ShowCountdown(int seconds)
    {
        for(int i = seconds; i> 0;  i--)
        {
            Console.WriteLine($"Time remaing: {i} seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}