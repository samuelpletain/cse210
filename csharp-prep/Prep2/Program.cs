using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letterGrade = "";
        string gradeSign = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (gradePercentage >= 60 && gradePercentage < 93)
        {
            if (gradePercentage % 10 < 3) {
                gradeSign = "-";
            }
            if (gradePercentage % 10 >= 7)
            {
                gradeSign = "+";
            }
        }

        Console.WriteLine($"Your letter grade is {letterGrade}{gradeSign}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed this time. Keep trying, you will get it next time!");
        }

    }
}