using System;

/// <summary>
/// Stores and displays all information pertaining to a single job.
/// </summary>
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    /// <summary>
    /// Displays the details of this job.
    /// </summary>
    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}