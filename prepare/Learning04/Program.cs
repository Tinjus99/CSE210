using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");


        Assignment a1 = new Assignment("Sam", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        Math m1 = new Math("Robert", "Fractions", "7.3", "8-19");
        Console.WriteLine(m1.GetHomeworkList());


        Writing w1 = new Writing("Mary", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetWritingInformation());
    }
}