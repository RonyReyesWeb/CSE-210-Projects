using System;

class Program
{
    // Adding a test line to see if it will work doing it from here
    static void Main(string[] args)
    {
        //Implementing the job class
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
}