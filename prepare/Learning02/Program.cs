using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "KIS Solutions";
        job1._startYear = 2024;
        job1._endYear = 2024;

        Job job2 = new Job();  
        job2._jobTitle = "Physics Teacher";
        job2._company = "Êxito - Acompanhamento Escolar";
        job2._startYear = 2014;
        job2._endYear = 2023;
    }
}