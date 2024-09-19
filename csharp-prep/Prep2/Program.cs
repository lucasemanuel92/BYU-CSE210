using System;

class Program
{
    static void Main(string[] args)
    {
        // Recieving the grande and converting string to int
        Console.Write("Insert your grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "A";
        string status = "Approved";

        
        // Estabilishing grades
        // A
        if (grade >=90 && grade < 94) {
            letter = "A-";
        } else if (grade >= 94) {
            letter = "A";
        }
        // B
        if (grade >= 80 && grade < 84) {
            letter = "B-";
        } else if (grade >= 84 && grade < 87) {
            letter = "B";
        } else if (grade >= 87 && grade < 90) {
            letter = "B+";
        }
        // C
        if (grade>= 70 && grade < 73){
            letter = "C-";
        } else if (grade >= 74 && grade < 77) {
            letter = "C";
        } else if (grade >= 77 && grade > 80) {
            letter = "C+";
        }
        // D
        if (grade >= 60 && grade < 63){
            letter = "D-";
        } else if (grade >= 64 && grade < 67) {
            letter = "D";
        } else if (grade >= 67 && grade > 70) {
            letter = "D+";
        }
        // F
        if (grade < 60) {
            letter = "F";
            status = "Reproved";
        }
        
        // Printing the final result
        Console.WriteLine($"Your stauts is: {status}, your grade is {letter}, having {grade}% score.");

    }
}