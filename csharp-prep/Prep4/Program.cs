using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        // using System.Collections.Generic;
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter a number. when done enter 0 to escape: ");
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
        }
        int Total = 0;
        int count = 0;
        foreach (int number in numbers)
        {
            count++;
            Total = Total + number;
        }
        float average = (float)Total / count;
        Console.WriteLine($"The sum is: {Total}");
        Console.WriteLine($"The average is: {average}");
        numbers.Sort();
        Console.WriteLine($"The lowest number is: {numbers[0]}");
        Console.WriteLine($"the highest number is: {numbers[numbers.Count - 1]}");
    }
}