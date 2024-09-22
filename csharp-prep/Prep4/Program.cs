using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        List<int> numbers = new List<int>();

        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        number = int.Parse(userInput);

        while (number != 0)
        {
            numbers.Add(number);

            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {max}");
    }
}