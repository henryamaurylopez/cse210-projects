// Program: creates a resume containing two jobs and displays the resume and its job history.
// Import console input/output functionality.
using System;

// Define the class that contains the program entry point.
class Program
{
    /// <summary>Creates sample job and resume objects, then displays the resume.</summary>
    /// <param name="args">Command-line arguments; this program does not use them.</param>
    /// <returns>Nothing.</returns>
    static void Main(string[] args)
    {
        // Create the first job record.
        Job job1 = new Job();
        // Set the first job's title.
        job1._jobTitle = "Software Engineer";
        // Set the first job's employer.
        job1._company = "Tech Solutions Inc.";
        // Set the first job's starting year.
        job1._startYear = 2020;
        // Set the first job's ending year.
        job1._endYear = 2023;

        // Create the second job record.
        Job job2 = new Job();
        // Set the second job's employer.
        job2._company = "Innovatech";
        // Set the second job's title.
        job2._jobTitle = "Senior Developer";
        // Set the second job's starting year.
        job2._startYear = 2023;
        // Set the second job's ending year.
        job2._endYear = 2025;

        // Create the resume that will contain the person's name and jobs.
        Resume resume = new Resume();
        // Set the name displayed on the resume.
        resume._name = "John Doe";

        // Add the first job to the resume's job list.
        resume._jobs.Add(job1);
        // Add the second job to the resume's job list.
        resume._jobs.Add(job2);

        // Display the resume and all of its jobs.
        resume.Display();
    }
}