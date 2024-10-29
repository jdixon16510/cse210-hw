using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Sofware Engineer";
        job1._startYear = "1975";
        job1._endYear = "2024";
        
        Job job2 = new Job();
        job2._company = "Oracle";
        job2._jobTitle = "Civil Engineer";
        job2._startYear = "1995";
        job2._endYear = "2016";
        

        Resume myResume = new Resume();
        myResume._name = "Joseph Dixon";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}