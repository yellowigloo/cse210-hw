using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Janitor";
        job1._company = "McDonalds";
        job1._startYear = 2000;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Clown";
        job2._company = "McDonalds";
        job2._startYear = 2010;
        job2._endYear = 2020;

        Job job3 = new Job();
        job3._jobTitle = "Prison Gang Leader";
        job3._company = "Delaware State Pen";
        job3._startYear = 2020;
        job3._endYear = 2022;


        Resume myResume = new Resume();
        myResume._name = "Sohn Jmith";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}