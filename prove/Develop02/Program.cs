using System;

class Program
{
    static void Main(string[] args) {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to your personal Journal");

        bool running = true;
        while (running) {
            Console.WriteLine("Please select your option: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            switch (choice) {
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;

                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;

                case 3:
                    Console.Write("Insert the file you wanto to save: ");
                    string fileSaved = Console.ReadLine();
                    journal.SaveEntries(fileSaved);
                    Console.WriteLine("Your file have been saved!");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.Write("Inster the file you want to load: ");
                    string fileLoaded = Console.ReadLine();
                    journal.LoadEntries(fileLoaded);
                    Console.WriteLine();
                    break;

                case 5:
                    running = false;
                    Console.WriteLine("Thank you for your time. Don't forget to do it again soon!");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Your entry is not correct. Try again!");
                    break;

            }
        }
    }
}
