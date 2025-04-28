using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
        Console.WriteLine("You passed with an A!");
        }
        else if (grade >= 80)
        {
        Console.WriteLine("You passed with a B!");
        }
        else if (grade >= 70)
        {
        Console.WriteLine("You passed with a C!");
        }
        else if (grade >= 60)
        {
        Console.WriteLine("You passed with a D!");
        }
        else
        {
        Console.WriteLine("You failed with an F!");
        }
    }
}