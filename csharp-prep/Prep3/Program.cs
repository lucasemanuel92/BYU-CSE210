using System;

class Program
{
    static void Main(string[] args)
    {
       //  REQUEST 1 and 2
        
        // Console.Write($"Insert the magic number: ");
        // int magic = int.Parse(Console.ReadLine());

        // REQUEST 3
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != magic) {
            Console.Write("Insert your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (magic > guess) {
                Console.WriteLine("Higher!!");
            }

            else if (magic < guess) {
                Console.WriteLine("Lower!!");
            }

            else {
                Console.WriteLine("You guess it RIGT!!!! CONGRATULATIONS!!!!");
            }
        }
    }
}
