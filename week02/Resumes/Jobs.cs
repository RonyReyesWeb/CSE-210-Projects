using System;

// Create Job file
public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear;
    public int _endYear;
    
    // Adding display method to show all information on it
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
