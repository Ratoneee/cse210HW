public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance() => (Laps * 50) / 1000.0; // kilometers

    public override double GetSpeed() => (GetDistance() / Duration) * 60; // kph

    public override double GetPace() => Duration / GetDistance(); // min per km
}
