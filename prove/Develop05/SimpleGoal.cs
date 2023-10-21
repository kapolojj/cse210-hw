public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Completed goal: {Name} (+{Points} points)");
    }

    public override string GetStatus()
    {
        return "[ ] " + Name;
    }
}