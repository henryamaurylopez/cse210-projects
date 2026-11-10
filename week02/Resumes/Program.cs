using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Solutions Inc.";
        job1._startYear = 2020;
        job1._endYear = 2023;

        job1.Display();

        Job job2 = new Job();
        job2._company = "Innovatech";
        job2._jobTitle = "Senior Developer";
        job2._startYear = 2023;
        job2._endYear = 2025;

        job2.Display();
    
        Resume resume = new Resume();

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        Console.WriteLine(resume._jobs[0]._jobTitle);
    }
}