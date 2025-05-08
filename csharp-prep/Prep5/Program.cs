using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome(args);
        string name = PromptUserName(args);
        int favoriteNumber = PromptUserNumber(args);
        int square = SquareNumber(favoriteNumber);
        DisplayResult(name, square);
    }
    static void DisplayWelcome(string[] args)
    {
        Console.WriteLine("Welcome to the C# Prep5 program.");
    }
    static string PromptUserName(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(string[] args)
    {
        Console.Write("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }
    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}