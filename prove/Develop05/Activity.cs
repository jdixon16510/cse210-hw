

public class Activity
{
    protected int _duration;

    public void StartActivity()
    {
        // Shared start message
        Console.WriteLine("Starting activity...");
        Console.WriteLine("Enter the duration of the activity in seconds:");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Pause(3); 
        
        // Call the PerformActivity method in each subclass
        PerformActivity();

        ShowEndMessage();
    }

    // Shared end message
    public void ShowEndMessage()
    {
        Console.WriteLine("Good job! You completed the activity.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Pause(3); 
    }

    // Pause method with spinner animation
    public void Pause(int seconds)
    {
        Console.WriteLine("Pausing...");
        for (int i = 0; i < seconds; i++)
        {
            ShowSpinner();
            Thread.Sleep(1000); 
        }
        Console.WriteLine(); 
    }

    // Countdown method with spinner animation
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            ShowSpinner();
            Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }

    // Show a rotating spinner (|, /, -, \)
    public void ShowSpinner()
    {
        char[] spinner = { '|', '/', '-', '\\' };
        foreach (char spin in spinner)
        {
            Console.Write($"\r{spin}  ");
            Thread.Sleep(250); 
        }
    }

    
    protected virtual void PerformActivity()
    {
        Console.WriteLine("Performing activity...");
    }
}
