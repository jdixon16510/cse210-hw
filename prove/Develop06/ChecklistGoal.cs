

public class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _targetCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                // Bonus points for completing the checklist
                return _points + 500;
            }
            return _points;
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        string status = _currentCount >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) - Completed {_currentCount}/{_targetCount} times";
    }

    public override string Save()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_currentCount}";
    }
}
