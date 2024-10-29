using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int result = SquareNumber(number);
        DisplayResults(name, result);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string entry = Console.ReadLine();
        int name = int.Parse(entry);
        return name;
    }
    static int SquareNumber(int number)
    {
        int result = number * number;
        return result;
    }
    static void DisplayResults(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}