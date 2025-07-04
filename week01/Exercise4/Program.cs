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

        // Show the result from the results
        Console.WriteLine($"The sum is: {sum}");
    }
}