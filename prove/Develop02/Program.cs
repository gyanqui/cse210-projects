using System;
using System.Collections.Generic;
using System.IO;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            // List of prompts
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
                Console.WriteLine("2. Display journal");
                Console.WriteLine("3. Save Journal in a file");
                Console.WriteLine("4. Load Journal from a file");
                Console.WriteLine("5. Quit");

                Console.Write("\nWhat would you like to do? ");
                string choice = Console.ReadLine();
        
                switch (choice)
                {
                    case "1":
                        journal.AddEntry(prompts[new Random().Next(prompts.Count)]);
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
            } Console.WriteLine("Until next time, keep writing!");
        }   
    }

    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
            return $"Date: {Date} - Prompt: {Prompt} \n{Response}\n";
        }
    }

    class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveToFile()
        {
            Console.Write("Create a Filename: ");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved to file.");
        }

        public void LoadFromFile()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(',');
                    string date = fields[0];
                    string prompt = fields[1];
                    string response = fields[2];
                    entries.Add(new Entry(prompt, response, date));
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
    }
} 

/*
Program Diagram 
                            +-----------------+
                            |     Program     |
                            +-----------------+
                            |    -Journal     |
                            +-----------------+
                                        |
                                        |
                                        |
                            +-----------+-----------+
                            |                       |
                    +------+--------+           +-------+-----+
                    |  PromptList   |           |     Entry   |
                    +-----------------------+ +----------------+
                    | -prompts: list of str | | -prompt: str   |
                    |                       | | -response: str |
                    | +get_prompt(): str    | | -date: str     |
                    +-----------------------+ +----------------+
                                            |
                                            |
                        +-------------+-------------------+
                        |             |                   |
            +---------+-----+ +-----+---------+     +------------+
            |   SaveToFile  | |  LoadFromFile |     |  Display   |
            +----------------+ +----------------+   +-------------------------+
            | -filename: str | | -filename: str |   | -journal: list of Entry |
            |                | |                |   |                         |
            | +save(): None  | | +load(): None  |   | +display(): None        |
            +----------------+ +----------------+   +-------------------------+     
*/