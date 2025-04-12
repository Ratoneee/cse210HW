public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus) 
        : base(name, desc, points)
    {
        _targetCount = target;
        _bonusPoints = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
                return GetPoints() + _bonusPoints;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;

    public override string GetStatus()
    {
        return $"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {GetShortName()} ({GetDescription()}) -- Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonusPoints}|{_targetCount}|{_timesCompleted}";
    }

    public static ChecklistGoal Deserialize(string[] parts)
    {
        var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
        goal._timesCompleted = int.Parse(parts[6]);
        return goal;
    }
}
