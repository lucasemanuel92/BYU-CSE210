using System;

public class Job {
    public string _jobOcupation;
    public string _companyName;
    public double _salary;
    public int _yearsOfWorking;


    public void Display() {
        Console.WriteLine($"{_jobOcupation} in {_companyName}, salary: ${_salary}, Years Working: {_yearsOfWorking}");
    }

}