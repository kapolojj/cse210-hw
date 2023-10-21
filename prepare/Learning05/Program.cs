using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
}

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

class Program
{
    public static void Main()
    {
        EternalQuest quest = new EternalQuest();
        bool quit = false;

        while (!quit)
        {
            // EternalQuest nfo_object = new EternalQuest ();
            // var totalPoints = nfo_object.totalPoints ();
            // Console.WriteLine($"Total Points: {totalPoints}");
            // Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Create New Goal
                    // Add your code here to create a new goal
                    Console.Write("Enter the name of the goal: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Enter the number of points for the goal: ");
                    if (!int.TryParse(Console.ReadLine(), out int goalPoints))
                    {
                        Console.WriteLine("Invalid points. Please enter a valid number.");
                        break; // or return; to exit the option
                    }
                    break;
                case "2":
                    // List Goals
                    quest.DisplayStatus();
                    break;
                case "3":
                    // Save Goals
                    // Add your code here to save goals to a file
                    Console.Write("Enter the filename to save the goals: ");
                    string saveFilename = Console.ReadLine();
                    quest.SaveGoalsToFile(saveFilename);
                    break;
                case "4":
                    // Load Goals
                    // Add your code here to load goals from a file
                    Console.Write("Enter the filename to load the goals: ");
                    string loadFilename = Console.ReadLine();
                    quest.LoadGoalsFromFile(loadFilename);
                    break;
                case "5":
                    // Record Event
                    // Add your code here to record an event for a goal
                    Console.Write("Enter the name of the goal you want to record an event for: ");
                    string goalNameToRecord = Console.ReadLine();
                    quest.RecordEvent(goalNameToRecord);
                    break;
                case "6":
                    // Quit
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
