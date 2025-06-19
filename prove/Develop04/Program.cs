using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nActivity Menu: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            Console.Write("how long would you like this activity to be? (in seconds): ");
            int duration = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    string name = "Breathing";
                    string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    string beginMessage = "Welcome to the Breathing Activity! Let's get started. follow the prompts as they come up";
                    string endMessage = "Thank you for participating in this Breathing Activity.";
                    string breatheIn = "Breathe in slowly for 5 seconds: ";
                    string holdbreath = "Hold your breath for 5 seconds: ";
                    string breatheOut = "Breathe out slowly for 5 seconds: ";
                    Breathing b1 = new Breathing(name, description, duration, beginMessage, endMessage, holdbreath, breatheIn, breatheOut);

            }
        }
    }
}

// spinner int deconds
// countdown int seconds