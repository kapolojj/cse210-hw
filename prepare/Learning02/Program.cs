using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Add an Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Get a Random Prompt");
            Console.WriteLine("4. Save Journal to File");
            Console.WriteLine("5. Load Journal from File");
            Console.WriteLine("6. Exit");

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
                        string randomPrompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Random Prompt: {randomPrompt}");
                        break;
                    case 4:
                        Console.Write("Enter the file name to save the journal: ");
                        string saveFileName = Console.ReadLine();
                        myJournal.SaveToFile(saveFileName);
                        break;
                    case 5:
                        Console.Write("Enter the file name to load the journal: ");
                        string loadFileName = Console.ReadLine();
                        myJournal.LoadFromFile(loadFileName);
                        break;
                    case 6:
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

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        File.WriteAllLines(file, entries.ConvertAll(entry => entry.Text));
        Console.WriteLine($"Journal saved to {file}.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Entry newEntry = new Entry(line);
                entries.Add(newEntry);
            }
            Console.WriteLine($"Journal loaded from {file}.");
        }
        else
        {
            Console.WriteLine($"File {file} does not exist.");
        }
    }
}

class Entry
{
    public string Text { get; }

    public Entry(string text)
    {
        Text = text;
    }

    public void Display()
    {
        Console.WriteLine(Text);
    }
}

class PromptGenerator
{
    private string[] prompts = { "What's on your mind today?", "Describe your day.", "Write about a recent experience.", "What are your goals for the week?" };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}
