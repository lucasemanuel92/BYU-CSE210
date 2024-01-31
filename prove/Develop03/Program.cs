using System;
 
class Program {
    static void Main() {
        
        // Starting the program
        Scripture scripture = new Scripture("Psalms", 46, 10, "Be still, and know that I am God: I will be exalted among the heathen, I will be exalted in the earth.");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress ENTER to continue or QUIT to exit:");

        // Creating the "if" situation to continue or quit
        while (true) {
            string input = Console.ReadLine();
            
            if (input.ToUpper() == "QUIT")
            break;

            if (!scripture.HideRadomWord()) {
                Console.WriteLine("Congratulations");
                break;
            }

            // Re-Starting the program.
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press ENTER to continue or QUIT to exit: \n");
        }
    }
}