public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {GetShortName()} ({GetDescription()})";
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

    public static SimpleGoal Deserialize(string[] parts)
    {
        return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { _isComplete = bool.Parse(parts[4]) };
    }
}
