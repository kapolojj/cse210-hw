public class EternalGoal : Goal
{
    private int _count = 0;

    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine($"Recorded progress on goal: {Name} (+{Points} points)");
    }

    public override string GetStatus()
    {
        return $"{_count}x {Name}";
    }
}