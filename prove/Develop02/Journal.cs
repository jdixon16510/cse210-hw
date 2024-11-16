using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // public void AddEntry(Entry newEntry)
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
            // string date = entry._date;
            // string prompt = entry._promptText;
            // string journalEntry = entry._entryText;

            journalFile.WriteLine ($"{entry._date}~~{entry._promptText}~~{entry._entryText}");

        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Entry fileEntry = new Entry();
        _entries = [];
        

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            string[] journalParts = line.Split("~~");

            fileEntry._date = journalParts[0];
            fileEntry._promptText = journalParts[1];
            fileEntry._entryText = journalParts[2];
            
            Console.WriteLine($"Date: {fileEntry._date}");
            Console.WriteLine($"{fileEntry._promptText}");
            Console.WriteLine($"{fileEntry._entryText}");
            Console.WriteLine();
            
            _entries.Add(fileEntry);
        }
    }
}