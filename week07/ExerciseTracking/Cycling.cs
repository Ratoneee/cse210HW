public class Cycling : Activity
{
    public double Speed { get; set; } // Speed in mph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance() => (Speed / 60) * Duration; // miles

    public override double GetSpeed() => Speed; // mph

    public override double GetPace() => 60 / Speed; // min per mile
}
