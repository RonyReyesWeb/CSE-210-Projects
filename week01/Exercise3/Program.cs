using System;

class Program
{
    static void Main()
    {
        //Step 2 LOOP ON

        // Ask user for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // Ask for the user's guess
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());


        // Compare guess to magic number and print response
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            // guess > magicNumber
            else
            {
                Console.WriteLine("Lower");
            }

            // Ask for another guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
        // When guess equals magic number
        Console.WriteLine("You guessed it!");
    }
}