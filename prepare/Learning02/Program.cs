using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1998;
        job1._endYear = 2000;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2000;
        job2._endYear = 2002;

        Job job3 = new Job();
        job3._jobTitle = "Software Engineer";
        job3._company = "Sony";
        job3._startYear = 2003;
        job3._endYear = 2005;

        Resume resume1 = new Resume();
        resume1._name = "Steven Seagal";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);

        resume1.Display();

    }
}