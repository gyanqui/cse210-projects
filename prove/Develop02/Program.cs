using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "Did anything unexpected happen today that surprised you? ",
                "What was the most challenging thing you faced today and how did you overcome it? ",
                "What was the best moment of your day and why? ",
                "Who did you share a special moment with today? ",
                "Did you discover anything new or learn something interesting today? ",
                "Did someone make you feel special or make you smile today?" ,
                "Did you achieve any success in your work, studies or personal projects today? ",
                "Did you do anything today that took you out of your comfort zone? ",
                "What would you like to do more of in your daily life and how do you plan to achieve it? ",
                "What do you most wish for tomorrow? ",
                "How did you show love or compassion towards others today, inspired by your faith? ",
                "Did you receive any unexpected blessings today that you attribute to your faith? If so, can you describe them? ",
                "What was the most inspiring thing you heard or read today that strengthened your faith? ",
                "How did you feel God's presence in your life today? ",
                "What was the most meaningful spiritual experience you had today? ",
                "How did you demonstrate your faith through actions or choices you made today? ",
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("Until next time, keep writing!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}