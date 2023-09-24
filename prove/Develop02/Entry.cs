using System;

class Entry
{
    private string _date;
    private string _promptText;
    public string Text { get; }

    public Entry(string text)
    {
        Text = text;
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {Text}");
    }
}
