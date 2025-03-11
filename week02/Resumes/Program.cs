using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
    job1._jobTitle = "Level designer";
    job1._company = "Valve";
    job1._startYear = 2020;
    job1._endYear = 2023;
    job1.display();

    Job job2 = new Job();
    job2._jobTitle = "software engineer";
    job2._company = "FromSoftware Inc.";
    job2._startYear = 2015;
    job2._endYear = 2019;

    Resume myresume = new Resume();
    myresume._name = "Tony Vigil";

    myresume._jobs.Add(job1);
    myresume._jobs.Add(job2);

    myresume.Display();
    }
}