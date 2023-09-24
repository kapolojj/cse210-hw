using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _promptText;

    public PromptGenerator()
    {
        _promptText = new List<string>
        { 
    "If I had one thing I could do differently, Which video games did you play today?", 
    "What have you learned from come follow me this week?", 
    "What have you learned from today? ", 
    "How did you get closer to the saviour today?" 
    };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_promptText.Count);
        return _promptText[index];
    }
}
