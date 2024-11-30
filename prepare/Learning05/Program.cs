using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Joseph Dixon", "C# Programming");
        Console.WriteLine (assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Joseph Dixon", "Math", "74", "2-17");
        Console.WriteLine (mathAssignment1.GetSummary());
        Console.WriteLine (mathAssignment1.GethomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Joseph Dixon", "Writing", "Big Blue Mable");
        Console.WriteLine (writingAssignment1.GetSummary());
        Console.WriteLine (writingAssignment1.GetWritingInformation());
    }
}