using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------- Resumes Project ---------------");
        Console.WriteLine();

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Google";
        job2._startYear = 2025;
        job2._endYear = 2026;
        job2.Display();

        Console.WriteLine();    
        Resume resume1 = new Resume();
        resume1._name = "Shania Esguerra";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}