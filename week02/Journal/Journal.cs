using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string filename)
{
    if (!File.Exists(filename))
    {
        Console.WriteLine($"Error: The file \"{filename}\" does not exist. Please try again.");
        return; // bounce back, do not continue if the file is not there
    }

    try
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
            else
            {
                Console.WriteLine("Warning: Skipped malformed line.");
            }
        }

        Console.WriteLine("Journal loaded successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
    }
}

}
