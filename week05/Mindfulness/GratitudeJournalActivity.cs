using System;
using System.Collections.Generic;

public class GratitudeJournalActivity : Activity
{
    private List<string> _responses;

    public GratitudeJournalActivity() : base("Gratitude Journal",
        "This activity helps you reflect on and list the things you're grateful for today. It's a powerful way to boost your positivity and awareness.")
    {
        _responses = new List<string>();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList things you're grateful for. Press ENTER after each one.");
        Console.WriteLine("You can stop at any time by typing 'done'.\n");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write(" - ");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "done")
            {
                break;
            }
            if (!string.IsNullOrWhiteSpace(input))
            {
                _responses.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {_responses.Count} things you are grateful for:");
        foreach (string item in _responses)
        {
            Console.WriteLine($" - {item}");
        }

        DisplayEndingMessage();
    }
}
