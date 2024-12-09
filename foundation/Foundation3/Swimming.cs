

class Swimming : Activity
{
    private int Laps;

    public Swimming(string date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double CalculateDistance()
    {
        return Laps * 50.0 / 1000;
    }

    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        return (distance / GetDurationMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return GetDurationMinutes() / distance;
    }
}
