using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        File.WriteAllLines(file, _entries.ConvertAll(entry => entry.Text));
        Console.WriteLine($"Journal saved to {file}.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Entry newEntry = new Entry(line);
                _entries.Add(newEntry);
            }
            Console.WriteLine($"Journal loaded from {file}.");
        }
        else
        {
            Console.WriteLine($"File {file} does not exist.");
        }
    }
}
