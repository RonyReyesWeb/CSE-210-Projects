using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            // Extra Feature: Added a custom "Gratitude Journal" activity.
            Console.WriteLine("4. Start Gratitude Journal Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    new GratitudeJournalActivity().Run();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
