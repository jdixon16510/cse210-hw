

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    
    public static Scripture LoadFromFile(string filePath)
    {
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
        // Example formats: "1 Nephi 3:7", "John 3:16", "Proverbs 3:5-6"
        string[] parts = referenceLine.Split(' ');

        
        // Extract book name (all parts except the last one)
        string book = string.Join(" ", parts.Take(parts.Length - 1));
        string chapterAndVerses = parts.Last();

        // Parse chapter and verses
        string[] chapterAndVerseParts = chapterAndVerses.Split(':');
        
        int chapter = int.Parse(chapterAndVerseParts[0]);
        string[] verseParts = chapterAndVerseParts[1].Split('-');
        int startVerse = int.Parse(verseParts[0]);
        int? endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : null;

        return new Reference(book, chapter, startVerse, endVerse);
    }
    
    public void HideRandomWords (int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Any(); i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }    
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{referenceText}\n{wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}