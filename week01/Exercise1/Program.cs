using System;

class Program
{
    static void Main()
    {
        // Prompt for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Output in specified format
        Console.WriteLine($"Your name is {firstName}.");

    }
}