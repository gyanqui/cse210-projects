using System;
using System.Collections.Generic;
using System.Threading;

//Main Program
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity App!");

        while (true)
        {
            Console.WriteLine("Please choose an activity :");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3.Listing Activity");
            Console.WriteLine("4.Done");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            Activity activity;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                    case "2":
                    activity = new ReflectingActivity();
                    break;
                    case "3":
                    activity = new ListingActivity();
                    break;
                    case "4":
                    Console.WriteLine("Thank you for using the Activity App. Goodbye!");
                    return;
                    default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    continue;
            }

            activity.Start();
            
            Console.WriteLine();
        }
    }
}   
