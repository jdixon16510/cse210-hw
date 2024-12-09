

abstract class Activity
{
    private string Date;
    private int DurationMinutes;

    protected Activity(string date, int durationMinutes)
    {
        Date = date;
        DurationMinutes = durationMinutes;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public string GetSummary()
    {
        double distance = CalculateDistance();
        double speed = CalculateSpeed();
        double pace = CalculatePace();
        return $"{Date} {GetType().Name} ({DurationMinutes} min): " +
               $"Distance: {distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min per km";
    }

    public int GetDurationMinutes()
    {
        return DurationMinutes;
    }
}
