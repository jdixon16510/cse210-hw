using System;

class Program
{
    static void Main(string[] args)
    {
        Entry newEntry = new Entry();
        Journal theJournal = new Journal();

        string input = "0";
        while (input != "5")
        {
            Console.WriteLine(
                "Please enter a number from the menu\n\n"+
                "Main Menu\n"+
                "1 - Journal Entry\n"+
                "2 - Display Journal\n"+
                "3 - Save to a File\n"+
                "4 - Retrieve from a File\n"+
                "5 - Quit"
                );
            input = Console.ReadLine();
            if (input == "1")
            {
                theJournal.AddEntry(newEntry);
                
                // Console.WriteLine($"Menu Selection {input}");
            }
            else if (input == "2")
            {
                theJournal.DisplayAll();

                // Console.WriteLine($"Menu Selection {input}");
            }
            else if (input == "3")
            {
                Console.Write("File to save: ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile("fileName");

                // Console.WriteLine($"Menu Selection {input}");
            }
            else if (input == "4")
            {
                Console.Write("File to open: ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile("fileName");
                
                // Console.WriteLine($"Menu Selection {input}");
            }
        }
        
    }
}