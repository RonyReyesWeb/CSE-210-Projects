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

        // Output in specified format adding the comma and last name, then firs and last name.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}