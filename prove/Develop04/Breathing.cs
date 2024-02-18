using System;
using System.Diagnostics;

public class Breathing : Activity {
    private string _first = "Breath in...";
    private string _second = "Breath out...";
    private string _message = "Relax and clear your mind.";

    public Breathing(string Name, int TimeUsed) : base(Name, TimeUsed) {
    
    }
        public void GetDescription() {
        Console.WriteLine(_message);
    }

    public void Breath(int seconds) {
        int secondsTimer = 0;
        while (secondsTimer < seconds) {
            for (int i = 4; i > 0; i--) {
                Console.WriteLine($"{_first}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_first.Length + 2)); 
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_first}  ");  
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_second}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_second.Length + 2));  
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_second}  "); 
            
        }
    }
}