using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        int guess = 0;
        int count = 0;

        do
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            count++;
            if (guess > magic)
            {
                Console.WriteLine($"Your guess {guess} is higher then the magic number.");
            }
            else if (guess < magic)
            {
                Console.WriteLine($"Your guess {guess} is lower then the magic number.");
            }
            else
            {
                Console.WriteLine($"You guessed the magic number {magic} in {count} tries.");
            }
        } while (guess != magic);
    }
}