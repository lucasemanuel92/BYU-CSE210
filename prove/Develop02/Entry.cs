using System;

public class Entry {

    public string _prompt;
    public string _response;
    public string _date;

    // Creating lists for the prompt
    public void GeneratePrompt() {
        List<string> prompts = new List<string>() {
            "What have you done interesting today?",
            "Which was your favourite verse from the scriptures today?",
            "What made you thankful for today?",
            "What do you think you could have done better today?",
        };

        // Creating the random prompt command
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    // Creating the response line
    public void GetResponse() {
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    // Creating the date generator
    public void GenerateDate() {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();
    }
}