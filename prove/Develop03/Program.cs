/*
    Exceeding Requirements
    Added a text file containing scriptures with references and have them selected randomly. 
    Accounted for multiple word books example 1 Nephi. 
    Put the file methods into the Scripture class to keep the Main program clean.
*/

using System;

class Program
{
    static void Main()
    {
        
        // Get reference and scripture from file
        
        string _filePath = "scriptures.txt";
        
        Scripture scripture = Scripture.LoadFromFile(_filePath);

        
        while (true)
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Check if scripture is completely hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are now hidden. The program has ended. ");
                break;
            }

            // Prompt user
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            // Hide random words. number is how many at a time to hide
            scripture.HideRandomWords(2);
        }
        
    }
}