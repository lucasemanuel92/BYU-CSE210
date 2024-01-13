using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();

        int entry = -1;
        while (entry !=0) {
            Console.Write("Please insert a number (if you want to quit insert 0): ");

            string answer = Console.ReadLine();
            entry = int.Parse(answer);

            if (entry != 0) {
                numbers.Add(entry);
            }
        }

        
        // REQUEST 1
        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }

        Console.WriteLine($"Your final sum is {sum}");

        // REQUEST 2
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}"); 

        // REQUEST 3
        int max = numbers[0];
        foreach (int number in numbers) { 
            if (number >max ) {
                max = number;
            }
        }

        Console.WriteLine($"The max number is {max}");
    }
}
