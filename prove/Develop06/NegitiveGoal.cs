

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Deduct points for recording this goal
        return -_points;
    }

    public override string DisplayStatus()
    {
        return $"[ ] {_name} ({_description}) - Avoid to prevent losing {_points} points";
    }

    public override string Save()
    {
        return $"NegativeGoal|{_name}|{_description}|{_points}";
    }
}
