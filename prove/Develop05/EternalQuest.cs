public class EternalQuest
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Added goal: {goal.Name}");
    }

    public void RecordEvent(string name)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.Name == name)
            {
                goal.RecordEvent();
                return;
            }
        }

        Console.WriteLine($"Goal not found: {name}");
    }

    public void DisplayStatus()
    {
        int totalPoints = 0;

        Console.WriteLine("Current Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStatus());
            totalPoints += goal.Points;
        }

        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void SaveGoalsToFile(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                file.WriteLine($"{goal.Name},{goal.Points}");
            }
        }

        Console.WriteLine("Goals have been saved to the file.");
    }

    public void LoadGoalsFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 2)
                {
                    string goalName = parts[0];
                    if (int.TryParse(parts[1], out int goalPoints))
                    {
                        // Decide on the goal type (Simple, Eternal, or Checklist) and create the appropriate goal
                        // For example, you can use user input or some logic to determine the goal type.
                        // Once determined, create and add the goal to the _goals list.
                        // Example: AddGoal(new SimpleGoal(goalName, goalPoints));
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal points in the file.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid goal format in the file.");
                }
            }

            Console.WriteLine("Goals have been loaded from the file.");
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}