

public class ReflectingActivity : Activity
{
    private readonly string[] _prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public new void StartActivity()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. Recognize the power you have.");
        base.StartActivity();
    }

    // Perform the Reflection Activity
    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Pause(2); 

        for (int i = 0; i < _duration / 10; i++) 
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.WriteLine(question);
            Pause(5); 
        }
    }
}



