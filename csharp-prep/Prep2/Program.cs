using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercent = int.Parse(gradeInput);
        string gradeLetter = "";
        string sign = "";

        if (gradePercent >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        int subGrade = gradePercent % 10;

        if (subGrade < 3)
        {
            sign = "-";
        } 
        else if (subGrade >= 7)
        {
            sign = "+";
        }
        else
        {
            sign = "";
        }

        if (gradePercent > 93)
        {
            sign = "";
        }
        if (gradeLetter == "F")
        {
            sign = "";
        }



        Console.WriteLine($"Your grade for the term is {gradeLetter}{sign}");

        if (gradeLetter != "F")
        {
            Console.WriteLine("Congradulations for passing the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately you have not passed the course. Please keep trying.");
        }


// subgrade = grade % 10

// if subgrade < 3:
//     sign = '-'
// elif subgrade >= 7:
//     sign = '+'
// else:
//     sign = ''

// if grade > 93:
//     sign = ''

// if letter == 'F':
//     sign = ''
     
// print (f'Your grade for this course is {letter}{sign}')

// if grade >= 70:
//     print (f'Congradulations you have passed the class.')
// else:
//     print ('You have recieved a failing grade. Reach out to mentoring for additional help. ')




//         if grade >= 90:
//     letter = 'A'
// elif grade >= 80:
//     letter = 'B'
// elif grade >= 70:
//     letter = 'C'
// elif grade >= 60:
//     letter = 'D'
// elif grade < 60:
//     letter = 'F'


    }
}