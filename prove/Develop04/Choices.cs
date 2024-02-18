using System;

public class Choices {
    private string _menu = $@"
    Menu Options
Please select one of the following options to start:
1. Breathing
2. Reflecting
3. Listing
4. Quit

Select an option:  ";
    public string _userInput;
    private int _userChoice = 0;
    public int UserChoice() {
        Console.Clear();
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0; // Eliminates not int
        
        try {
            _userChoice = int.Parse(_userInput);
        }
        
        catch (FormatException) {
            _userChoice = 0;
        }
        
        catch (Exception exception) {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }
}
