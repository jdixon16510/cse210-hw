

class Cycling : Activity
{
    private double SpeedKph;

    public Cycling(string date, int durationMinutes, double speedKph)
        : base(date, durationMinutes)
    {
        SpeedKph = speedKph;
    }

    public override double CalculateDistance()
    {
        return (SpeedKph * GetDurationMinutes()) / 60;
    }

    public override double CalculateSpeed()
    {
        return SpeedKph;
    }

    public override double CalculatePace()
    {
        return 60 / SpeedKph;
    }
}