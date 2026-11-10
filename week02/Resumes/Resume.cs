// Resume model: stores a person's name and job history and can display them.
// Define a resume containing a name and a collection of jobs.
public class Resume
{
    // Store the person's name; start with an empty value.
    public string _name = "";
    // Store the person's job records; begin with an empty list.
    public List<Job> _jobs = new List<Job>();

    /// <summary>Prints the person's name followed by each job in the resume.</summary>
    /// <returns>Nothing.</returns>
    public void Display()
    {
        // Print the name stored on the resume.
        Console.WriteLine($"Name: {_name}");
        // Label the list of jobs that follows.
        Console.WriteLine("Jobs:");
        // Visit each job stored in the resume.
        foreach (Job job in _jobs)
        {
            // Ask the current job to display its details.
            job.Display();
        }
    }
}