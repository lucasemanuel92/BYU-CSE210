using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your grade percentage: ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string final_grade = "";

        if (percent >= 90) {
            final_grade = "A";
        }

        else if (percent >= 80) {
            final_grade = "B";
        }
        
        else if (percent >= 70) {
            final_grade = "C";
        }

         else if (percent >= 60) {
            final_grade = "D";
        }

         else {
            final_grade = "F";
         }

        Console.WriteLine($"Your final grade is {final_grade}");

        if (percent >= 70) {
            Console.WriteLine("You passed! Congratulations!!!");
        }

        else {
            Console.WriteLine("You have not been approved. Please contact your teacher.");
        }
    }
}
