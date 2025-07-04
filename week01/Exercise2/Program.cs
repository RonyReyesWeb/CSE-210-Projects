using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their grade percentage
        Console.Write("Enter your grade percentage: ");

        // Read the input from the user as a string
        string input = Console.ReadLine();

        // Convert the input string to an integer grade
        int grade = int.Parse(input);

        // Declare a variable to hold the letter grade
        string letter;

        // Determine the letter grade based on the numeric grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //testing the results
        Console.WriteLine($"Your letter grade is: {letter}");

        // Check if the user passed (70 or above)
        if (grade >= 70)
        {
            // Congratulate the user if they passed
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            // Encourage the user to try again if they did not pass
            Console.WriteLine("Keep trying! You can do better next time.");
        }

    }
}