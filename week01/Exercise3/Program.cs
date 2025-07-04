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


        // Compare guess to magic number and print response
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
        //testing the result
            Console.WriteLine("You guessed it!");
        }

    }
}