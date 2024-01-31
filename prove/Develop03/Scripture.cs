using System;

class Scripture {
    private Reference _reference;
    private List<Word> _words;
    
    // Separating parts of the referred scripture
    public Scripture (string book, int chapter, int verse, string saying) {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();

        // Separating the saying
        string[] splitText = saying.Split(' ');
        foreach (string word in splitText) {
            _words.Add(new Word(word));
        }
    }

    // Creating the hide display
    public void Display() {
        Console.WriteLine($"{_reference}: ");
        foreach (Word word in _words) {
            
            // Creating the effect ____ in hidden word
            if (word.IsHidden()) {
                Console.Write(new string('_', word.GetText().Length) + "");
            }
            else {
                Console.Write(word.GetText() + " ");
            }
        }
    }

    // Creating the random select words
    public bool HideRadomWord() {
        List<Word> visibleWords = GetVisibleWords();
        if (visibleWords.Count < 2)
            return false;

        Random random = new Random();
        int randomIndex1 = random.Next(visibleWords.Count);
        int randomIndex2;

        do {
            randomIndex2 = random.Next(visibleWords.Count);
        }

        while (randomIndex1 == randomIndex2);
        visibleWords[randomIndex1].Hide();
        visibleWords[randomIndex2].Hide();
        return true;
    }

    private List<Word> GetVisibleWords() {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words) {
            if (!word.IsHidden())
            visibleWords.Add(word);
        }
        return visibleWords;
    }
}