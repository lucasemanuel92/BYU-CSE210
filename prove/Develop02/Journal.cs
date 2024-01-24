using System;

public class Journal {

    public List<Entry> _entries = new List<Entry>();

    public void NewEntry() {
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.GetResponse();
        _entries.Add(userEntry);
    }
    // Creating the display interface
    public void DisplayEntries() {
        foreach (Entry entry in _entries) {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"What you think: {entry._response}");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

    // Creating the save Mode and creating in as .csv file
    public void LoadEntries(string filename) {
        if (filename.EndsWith(".csv")) {

            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines) {
            
                // Spliting the code in a list
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine(); // Jump on line
            }
        }
        else {
            using (StreamReader reader = new StreamReader(filename)) {
                string journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }

    // Creating saved entries
    public void SaveEntries(string filename) {
        using (StreamWriter opFile = new StreamWriter(filename, true)) {
            if (filename.EndsWith(".csv")) {
                foreach (Entry entry in _entries) { 
                    opFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }
            else {
                foreach (Entry entry in _entries) {
                    opFile.WriteLine($"Date:{entry._date},{entry._prompt},{entry._response}");
                    opFile.WriteLine($"Prompt:{entry._prompt}");
                    opFile.WriteLine($"{entry._response}");
                    opFile.WriteLine();
                }
            }
        }
    }
}