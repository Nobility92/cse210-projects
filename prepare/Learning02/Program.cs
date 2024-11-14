using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
        job1._jobTitle = "Web Developer (Microsoft)";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Team Lead (GMS)";
        job2._startYear = 2022;
        job2._endYear = 2024;

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Henry Nwaokonko";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}