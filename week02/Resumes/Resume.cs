public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public void Display()
    {
        //Display name
        Console.WriteLine($"{_name}");

        //Display each one of the jobs
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}