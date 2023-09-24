using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        

        while (true)
        {
            Console.WriteLine("Welcome to the Journal program! ");
            Console.WriteLine("Please select one of the following choices :");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        
                   
                        Console.Write("Enter your journal entry: ");
                        string text = Console.ReadLine();
                        Entry newEntry = new Entry(text);
                        myJournal.AddEntry(newEntry);
                        break;
                    case 2:
                        myJournal.DisplayAll();
                        break;
                    case 3:
                        Console.Write("Enter the file name to load the journal: ");
                        string loadFileName = Console.ReadLine();
                        myJournal.LoadFromFile(loadFileName);
                        break;
                    case 4:
                        Console.Write("Enter the file name to save the journal: ");
                        string saveFileName = Console.ReadLine();
                        myJournal.SaveToFile(saveFileName);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
