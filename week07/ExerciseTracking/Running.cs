public class Running : Activity
{
    public double Distance { get; set; } // Distance in miles

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;

    public override double GetSpeed() => (Distance / Duration) * 60; // mph

    public override double GetPace() => Duration / Distance; // min per mile
}
