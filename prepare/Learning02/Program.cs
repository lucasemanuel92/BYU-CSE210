using System;

class Program
{
    static void Main(string[] args) {
       
       Job job1 = new Job();
       job1._jobOcupation = "Software Developer";
       job1._companyName = "Softplan";
       job1._salary = 12345.65;
       job1._yearsOfWorking = 4;

       Job job2 = new Job();
       job2._jobOcupation = "Software Architeture";
       job2._companyName = "Porsche";
       job2._salary = 14235.94;
       job2._yearsOfWorking = 7;

       Resume myResume = new Resume();
       myResume._name = "Lucas";

       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.Display();


    }
}
