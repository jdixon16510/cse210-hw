

public class ProgressGoal : Goal
{
    private int _currentProgress;
    private int _totalProgress;

    public ProgressGoal(string name, string description, int points, int totalProgress, int currentProgress = 0)
        : base(name, description, points)
    {
        _totalProgress = totalProgress;
        _currentProgress = currentProgress;
    }

    public override int RecordEvent()
    {
        Console.Write("Enter the amount of progress made: ");
        int progress = int.Parse(Console.ReadLine());
        _currentProgress += progress;

        if (_currentProgress >= _totalProgress)
        {
            int bonus = 500; // Bonus for completing the progress
            int pointsEarned = _points + bonus;
            _currentProgress = _totalProgress; // Clamp progress to the max
            return pointsEarned;
        }

        return _points; // Points for incremental progress
    }

    public override string DisplayStatus()
    {
        string status = _currentProgress >= _totalProgress ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) - Progress {_currentProgress}/{_totalProgress}";
    }

    public override string Save()
    {
        return $"ProgressGoal|{_name}|{_description}|{_points}|{_totalProgress}|{_currentProgress}";
    }
}
