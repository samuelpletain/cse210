using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        
        int sum = 0;
        int largestNumber = numbers[0];
        int smallestPositiveNumber = numbers[0];

        foreach (int item in numbers)
        {
            sum += item;
            if (item > largestNumber)
            {
                largestNumber = item;
            }
            if (item > 0 && item < smallestPositiveNumber)
            {
                smallestPositiveNumber = item;
            }
        }

        double average = (double)sum / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine($"The sorted list is:");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }

}