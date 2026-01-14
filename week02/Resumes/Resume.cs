public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        //Display name
        Console.WriteLine($"Name:{_name}");

        //Display each one of the jobs
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}