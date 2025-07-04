using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // STEP 1: Compute the sum, or total, of the numbers in the list.

        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to read numbers until user enters 0
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // create the results
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // STEP 2: Compute the average of the numbers in the list.
        float average = 0;

        if (numbers.Count > 0)
        {
            average = (float)sum / numbers.Count;
        }

        // STEP 2: Find the maximum number
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Show the result from the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}