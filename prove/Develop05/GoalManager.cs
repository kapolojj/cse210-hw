class GoalManager
{
    public void MenuLoop()
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
