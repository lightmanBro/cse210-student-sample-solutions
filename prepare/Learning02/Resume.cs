using System;

/// <summary>
/// Stores and displays the resume of a person including their
/// complete job history.
/// </summary>
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    /// <summary>
    /// Displays the name of the person and all their jobs.
    /// </summary>
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayDetails();
        }
    }
}