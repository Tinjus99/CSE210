using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nJournal Menu: ");
            Console.WriteLine("1. Write a new entry: ");
            Console.WriteLine("2. Display Journal: ");
            Console.WriteLine("3. Save Journal to file: ");
            Console.WriteLine("4. Load Journal from file: ");
            Console.WriteLine("0. Exit: ");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("See you later!");
                    break;
                default:
                    Console.WriteLine("that is an invalid option. Please try again.");
                    break;
            }
        }
    }

    static List<string> Prompts = new List<string>
    {
        "What Chaos did i cause in the world roday?",
        "what was my favorite part of the day?",
        "who did i interact with today?",
        "what was the most difficult part of the day?",
        "what do i wish that i had done differently?",
        "what did i do to help other poeple today?"
    };
    static Journal journal = new Journal();
    static Random random = new Random();
    

    static void WriteEntry()
    {
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry entry = new Entry(date, prompt, response);
        journal.AddEntry(entry);
        Console.WriteLine("Entry added.");
    }
}