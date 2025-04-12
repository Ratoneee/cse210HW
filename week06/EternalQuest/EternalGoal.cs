public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }

    public override int RecordEvent() => GetPoints();

    public override bool IsComplete() => false;

    public override string GetStatus()
    {
        return $"[∞] {GetShortName()} ({GetDescription()})";
    }

    public override string Serialize()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }

    public static EternalGoal Deserialize(string[] parts)
    {
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
