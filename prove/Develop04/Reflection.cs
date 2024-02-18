using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Reflecting : Activity {
    private List<string> _ideasList = new List<string> {
        "Think of a time when you did something you're proud of.",
        "Think of a time when you did something you thought you couldn't",
        "Think of a time when you helped someone"
    };

    private List<string> _questions = new List<string> {
         "How did you feel when it was complete?",
         "What was the reason behind you're choice?",
         "What is your favorite thing about this experience?"
    };

    private List<string> _useQuestions = new List<string>();
    private string _ideas;
    private string _question;
    private string _description = "It will help you to think about important things";


    public Reflecting(string Name, int TimeUsed) : base(Name, TimeUsed){

    }
    public void GetDescription() {
        Console.WriteLine(_description);
    }

    private string GetRandomIdea() {
        var random = new Random();
        int index = random.Next(_ideasList.Count);
        return _ideasList[index];
    }

    private string GetRandomQuestion() {
        var random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void Showidea(int seconds) {
        Console.WriteLine();
        var idea = GetRandomIdea();
        Console.WriteLine("Considering the idea:");
        Console.WriteLine($"\n{idea}");
        Console.WriteLine($"\nPress 'enter' to write.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter) {
            ShowQuestion(seconds);
        }
    }

    public void ShowQuestion(int seconds) {
        _useQuestions.AddRange(_questions);
        Spinner spinner = new Spinner();
        Console.WriteLine($"Now, think about it");
        CountDown(8);
        Stopwatch timer = new Stopwatch();
        timer.Start();
        
        while (timer.Elapsed.TotalSeconds < seconds) {
            if (_useQuestions.Count != 0) {
                var question = GetRandomQuestion();
                Console.Write($" {question}");
                _useQuestions.Remove(question);
            }
            spinner.ShowSpinner();
        }
        timer.Stop();
    
    }
}