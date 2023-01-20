using System;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            //this should work
            job.DisplayJob();
            /* i am making a correction to this code because I tried this   job.Display() method for close to 3 hrs
            but it did not work until i changed it to job.DisplayJob(); then it worked. */
        }
    }
}
