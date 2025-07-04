using System;

class Program
{
    static void Main()
    {
        //Step 1 no loop

        // Ask user for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // Ask for the user's guess
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        //testing the result
        Console.WriteLine($"Your magic number is: {magicNumber}");
        Console.WriteLine($"Your guess is: {guess}");


    }
}