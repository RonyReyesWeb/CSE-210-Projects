using System;

class Program
{
    static void Main(string[] args)
    {

        // Call each function in order and pass/receive data between them
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();


    }

    // Function 1: Display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Ask for the user's name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function 3: Ask for the user's favorite number and return it as int
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    // Function 4: Square the given number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
}