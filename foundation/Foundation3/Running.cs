

class Running : Activity
{
    private double DistanceKm;

    public Running(string date, int durationMinutes, double distanceKm)
        : base(date, durationMinutes)
    {
        DistanceKm = distanceKm;
    }

    public override double CalculateDistance()
    {
        return DistanceKm;
    }

    public override double CalculateSpeed()
    {
        return (DistanceKm / GetDurationMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        return GetDurationMinutes() / DistanceKm;
    }
}