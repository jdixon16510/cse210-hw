// Entry Class
//      has three attributes
//          _date stores the date of the entry
//          _promptText stores the prompt to the user
//          _entryText stores the users entry to the prompt

//      has one method
//          Display will display the attributes to the screen

public class Entry

{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
       Console.WriteLine($"\nDate: {_date}");
       Console.WriteLine($"{_promptText}");
       Console.WriteLine($"{_entryText}");
       
    }
}