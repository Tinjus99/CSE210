using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int number = -1;
        // int count;
        while (number != magicNumber)
            {
                Console.Write("What number do you guess between 1 and 10? ");
                number = int.Parse(Console.ReadLine());
                if (number > magicNumber) 
                {
                    Console.WriteLine("The magic number is lower. ");
                    // count =+ 1;
                }
                else if (number < magicNumber) 
                {
                    Console.WriteLine("The magic number is higher. ");
                    // count =+ 1;
                }
                else
                {
                    // count =+ 1;
                    Console.WriteLine("You guessed the right number! ");
                    // Console.WriteLine($"It took you {count} tries to guess the right number. ");
                }
            } 
    }
}