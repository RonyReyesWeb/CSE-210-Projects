using System;

class Program
{
    static void Main()
    {
        //Step 3 *FINAL STEP

        //Implementation of randomegenerator 
        Random randomGenerator = new Random();

        // Generate random magic number from 1 to 100
        int magicNumber = randomGenerator.Next(1, 101);

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