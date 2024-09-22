using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int newGame = 1;

         while (newGame == 1) {
        // Creating random
        Random randomNumber = new Random();
        int number = randomNumber.Next(1,16);
        //Declaring variables
        int guess = 0;
        int counter = 0;
        
        

        Console.WriteLine("Welcome to our magic number game");

        
        if (newGame == 1) {
            while (guess != number) {
                // Creating insert guess
                Console.Write("Guess the magic number between 1 - 15:  ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
            
                if (guess > number) {
                    Console.WriteLine("Lower");
                    counter ++;
                } else if (guess < number) {
                    Console.WriteLine("Higher");
                    counter ++;
                } else {
                    counter ++;
                    Console.WriteLine($"You guessed it correctly, you tried it {counter} times.");
                    

                    Console.Write("Enter 1 to play or any other number to exit: ");
                    string userInp = Console.ReadLine();
                    newGame = int.Parse(userInp);
                }   
                
            }
        }
    }
}
}