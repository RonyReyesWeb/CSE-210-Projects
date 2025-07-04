using System;

class Program
{
    static void Main()
    {
        // Prompt for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();


        // Prompt for first name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Output in specified format
        Console.WriteLine($"Your first name  is {firstName}.");
        Console.WriteLine($"Your last name  is {lastName}.");
    }
}