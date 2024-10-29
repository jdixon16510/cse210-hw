using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numbers;
        numbers = new List<int>();
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do 
        {
            Console.Write("Enter a number. ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        foreach (int x in numbers)
        {
            sum = sum + x;
            
        }

        Console.WriteLine($"The sum is {sum}");

        int count = numbers.Count;
        float average = (float)sum / (float)count;
        Console.WriteLine($"The average is {average}");

        int largest = 0;

        foreach (int x in numbers)
        {
            if (x > largest)
            {
                largest = x;
            }
        }
        Console.WriteLine($"The largest number is {largest}");

        int smallest = largest + 1;

        foreach (int x in numbers)
        {
            if (x > 0 && x < smallest)
            {
                smallest = x;
            }
        }
        Console.WriteLine($"The smallest positive number is {smallest}");

        numbers.Sort();
        foreach (int x in numbers)
        {
           Console.WriteLine(x); 
        }

    }
}