using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDS REQUIREMENTS: Allows the user to choose how many words to hide each time.

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        Scripture scripture = new Scripture(reference, verseText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            Console.Write("How many words would you like to hide? ");
            string inputCount = Console.ReadLine();
            if (int.TryParse(inputCount, out int count))
            {
                scripture.HideRandomWords(count);
            }
            else
            {
                Console.WriteLine("Invalid number. Hiding 3 words by default.");
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("\nFinal Scripture:\n");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Program complete.");
    }
}
