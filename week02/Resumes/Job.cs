// Job model: stores an employer, job title, and start and end years for one position.
// Define the data and display behavior for a single job.
public class Job
{
    // Store the employer's name; start with an empty value.
    public string _company = "";
    // Store the position's title; start with an empty value.
    public string _jobTitle = "";
    // Store the year the position began; zero indicates no year has been set yet.
    public int _startYear = 0;
    // Store the year the position ended; zero indicates no year has been set yet.
    public int _endYear = 0;

    /// <summary>Prints the job title, company, and employment years.</summary>
    /// <returns>Nothing.</returns>
    public void Display()
    {
        // Print this job's details in one formatted line.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}