

public class BreathingActivity : Activity
{
    public new void StartActivity()
    {
        // Call the base class start activity method
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        base.StartActivity();
    }

    // Perform the Breathing Activity
    protected override void PerformActivity()
    {
        Console.WriteLine("Breath in...");
        for (int i = 0; i < _duration / 10; i++) 
        {
            Console.WriteLine("Breath in...");
            Countdown(5); 
            Console.WriteLine("Breath out...");
            Countdown(5); 
        }
    }
}
