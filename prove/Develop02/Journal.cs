using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        PromptGenerator newPrompt = new PromptGenerator(); 
        
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        newEntry._date = $"{today}";
        
        newEntry._promptText = newPrompt.GetRandomPrompt();

        Console.Write(newEntry._promptText);
        string post = Console.ReadLine();
        newEntry._entryText = post;


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

    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string firstName = parts[0];
            string lastName = parts[1];
            
        }
    }
}