using System;
using System.Collections.Generic;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // adding a display method to the resume class
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
