using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();

       string userName = PromptUserName();
       int userNumber = PromptUserNumber();

       int squareNumber = SquaredNumber(userNumber);

       DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome() {
        Console.WriteLine("WELCOME TO OUR SYSTEM!");
    }

    static string PromptUserName() {
        Console.Write("Please, insert your first name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please insert your number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int number) { 
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square) {
        Console.WriteLine($"Your name is {name} and your number squared is {square}");
    }
}
