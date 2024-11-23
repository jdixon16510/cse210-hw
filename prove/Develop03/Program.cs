using System;

class Program
{
    static void Main()
    {
        
        // Get reference and scripture from file
        string currentFolderPath = Directory.GetCurrentDirectory();
        string _fileName = "scriptures.txt";
        string _filePath = Path.Combine(currentFolderPath, _fileName);
        Scripture scripture = Scripture.LoadFromFile(_filePath);

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
}