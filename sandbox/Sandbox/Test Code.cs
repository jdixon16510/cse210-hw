using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ')
                         .Select(word => new Word(word))
                         .ToList();
    }

    public static Scripture LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file '{filePath}' was not found.");
        }

        string[] lines = File.ReadAllLines(filePath);
        List<List<string>> scriptureBlocks = new List<List<string>>();
        List<string> currentBlock = new List<string>();

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                if (currentBlock.Count > 0)
                {
                    scriptureBlocks.Add(new List<string>(currentBlock));
                    currentBlock.Clear();
                }
            }
            else
            {
                currentBlock.Add(line.Trim());
            }
        }

        if (currentBlock.Count > 0)
        {
            scriptureBlocks.Add(new List<string>(currentBlock));
        }

        if (scriptureBlocks.Count == 0)
        {
            throw new InvalidOperationException("The file does not contain any valid scripture blocks.");
        }

        // Randomly select a scripture block
        Random random = new Random();
        List<string> selectedBlock = scriptureBlocks[random.Next(scriptureBlocks.Count)];

        // Parse the selected scripture block
        Reference reference = ParseReference(selectedBlock[0]);
        string text = string.Join(" ", selectedBlock.Skip(1));

        return new Scripture(reference, text);
    }

    private static Reference ParseReference(string referenceLine)
    {
        string[] referenceParts = referenceLine.Split(' ');
        if (referenceParts.Length < 3)
        {
            throw new FormatException("The reference line must be in the format 'Book Chapter:Verse[-Verse]'.");
        }

        string book = referenceParts[0];
        string[] chapterAndVerses = referenceParts[1].Split(':');
        if (chapterAndVerses.Length != 2)
        {
            throw new FormatException("The reference line must include a chapter and verse(s) in the format 'Chapter:Verse[-Verse]'.");
        }

        int chapter = int.Parse(chapterAndVerses[0]);
        string[] verses = chapterAndVerses[1].Split('-');
        int startVerse = int.Parse(verses[0]);
        int? endVerse = verses.Length > 1 ? int.Parse(verses[1]) : null;

        return new Reference(book, chapter, startVerse, endVerse);
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public string GetDisplayText()
    {
        string referenceText = reference.GetDisplayText();
        string wordsText = string.Join(" ", words.Select(word => word.GetDisplayText()));
        return $"{referenceText}\n{wordsText}";
    }
}




//MAIN PROGRAM

using System;

class Program
{
    static void Main()
    {
        try
        {
            // Load a random scripture from the file
            string filePath = "scriptures.txt"; // Update with your file path
            Scripture scripture = Scripture.LoadFromFile(filePath);

            // Program loop
            while (true)
            {
                // Clear the console and display the scripture
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                // Check if scripture is completely hidden
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Program will now exit.");
                    break;
                }

                // Prompt user
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input?.ToLower() == "quit")
                {
                    break;
                }

                // Hide random words
                scripture.HideRandomWords(2);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


