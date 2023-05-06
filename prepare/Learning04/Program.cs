using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        string studentName1 = "Samuel Bennett";
        string topic1 = "Multiplication";
        Assignment new1 = new Assignment(studentName1, topic1);
        Console.WriteLine(new1.GetSummary());
        Console.WriteLine("\n");

        string studentname2 = "Roberto Rodriguez";
        string topic2 = "Fractions";
        string section2 = "7.3";
        string problems2 = "8-19";
        MathAssignment new2 = new MathAssignment(studentname2, topic2, section2, problems2);
        Console.WriteLine(new2.GetHomeWorkList());
        Console.WriteLine("\n");

        string studentname3 = "Mary Waters";
        string topic3 = "European History";
        string title3 = "The Causes of World War II by Mary Waters";
        WritingAssignment new3 = new WritingAssignment(studentname3, topic3, title3);
        Console.WriteLine(new3.GetWritingInformation());

    }
}