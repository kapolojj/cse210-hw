public class ChecklistGoal : Goal
{
    private int _count = 0;
    private int _targetCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        _targetCount = targetCount;
    }

    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine($"Recorded progress on goal: {Name} (+{Points} points)");

        if (_count == _targetCount)
        {
            Points += 500;
            Console.WriteLine($"Completed goal: {Name} (+500 bonus points)");
        }
    }

    public override string GetStatus()
    {
        return $"Completed {_count}/{_targetCount} times: {Name}";
    }
}