

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Points are awarded every time this event is recorded.
        return _points;
    }

    public override string DisplayStatus()
    {
        return $"[∞] {_name} ({_description})";
    }

    public override string Save()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}
