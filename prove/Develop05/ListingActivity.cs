

public class ListingActivity : Activity
{
    private readonly string[] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public new void StartActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        base.StartActivity();
    }

    // Perform the Listing Activity
    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Countdown(5); 

        int count = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.WriteLine("Enter an item:");
            string item = Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}



