using System;
using System.Collections;
using System.Diagnostics;

class Program {
    static void Main(string[] args) {
        Console.Clear();
        Console.Write("Welcome to The Relaxing Program!!");
        
        // Creating the choice menu
        Choices choice = new Choices();
        int seconds;
        int action = 0;
        while (action != 0) {
            action = choice.UserChoicec();
            
            switch (action) {
                
                case 1: // Breathing
                    Console.Clear();
                    Breathing breathing = new Breathing("Breathing", 0);
                    breathing.GetName(); // Name
                    breathing.GetDescription(); // Decription
                    seconds = breathing.GetTime(); // Set the time
                    breathing.GetReady();
                    breathing.Breathing(seconds); // Time counter
                    breathing.GetDone();
                    break;
                
                case 2: // Reflecting
                    Console.Clear();
                    Reflecting reflecting = new Reflecting("Reflecting", 0);
                    reflecting.GetName();
                    reflecting.GetDescription();
                    seconds = reflecting.GetTime();
                    reflecting.GetReady();
                    reflecting.Reflect(seconds);
                    reflecting.GetDone();
                    break;
                
                case 3: // Listing
                    Console.Clear();
                    Listing listing = new Listing("Listing", 0);
                    listing.GetName();
                    listing.GetDescription();
                    seconds = listing.GetTime();
                    listing.GetReady();
                    listing.List(seconds);
                    listing.GetDone();
                    break;

                case 4: // Quit
                    Console.WriteLine("Thank you. Hope to see you back soon!");
                    break;

                default:
                    Console.WriteLine("Not a valid option. Try again.");
                    break;

            }
        }        
    }
}