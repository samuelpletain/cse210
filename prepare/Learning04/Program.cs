using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment multiplication = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(multiplication.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fraction", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}