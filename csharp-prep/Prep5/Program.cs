using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }
    static void DisplayWelcome(string[] args)
    {
        Console.WriteLine("Welcome to the C# Prep5 program.");
    }
    static void PromptUserName(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
    }
    static void PromptUserNumber(int[] args)
    {
        Console.Write("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
    }
    static void SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
    }
}