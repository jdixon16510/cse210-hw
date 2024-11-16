using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.IO;

// Journal Class
//      has one attribute
//          _entries is a list that holds each entry object
//      has four methods
//          AddEntry builds the entry object and adds it to the _entries list
//          DisplayAll displays all the entries in the _entries list and calls the Display method from the Entry Class
//          SaveToFile has one string parameter File and saves all the entries in the _entries list to the file named
//          LoadFromFile has one string parameter File and loads the file, clears any entries and builds a new _entries list


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        Entry newEntry = new Entry(); 
        
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        newEntry._date = $"{today}";
        
        newEntry._promptText = newPrompt.GetRandomPrompt();

        Console.Write(newEntry._promptText);
        string post = Console.ReadLine();
        newEntry._entryText = post;

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter journalFile = new StreamWriter(file))

        foreach (Entry entry in _entries)
        {
            journalFile.WriteLine ($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        _entries = [];
        

        foreach (string line in lines)
        {
            Entry fileEntry = new Entry();
            string[] journalParts = line.Split("~~");

            fileEntry._date = journalParts[0];
            fileEntry._promptText = journalParts[1];
            fileEntry._entryText = journalParts[2];
            
            _entries.Add(fileEntry);
        }
    }
}