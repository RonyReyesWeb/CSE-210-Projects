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

        //testing the results
        Console.WriteLine("You entered: " + grade);


    }
}