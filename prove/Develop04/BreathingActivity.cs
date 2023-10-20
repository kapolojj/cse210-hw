using System;

class BreathingActivity
{


    public string info_1()
    {
        return "Welcome to the Breathing Activity";
    }
    public string instruction_1()
    {
        
        // for (int i=5; i>0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b");
        // }
        

        return "This activity will help you relax by walking your thought breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void StartBreathing()
    {
        Console.Write("Enter the time in seconds for the breathing exercise: ");
        if (!int.TryParse(Console.ReadLine(), out int totalTimeSeconds) || totalTimeSeconds <= 0)
        {
            Console.WriteLine("How long, in seconds, would you like for you session? ");
            return;
        }

        int breathTime = totalTimeSeconds / 2;
        int remainingTime = totalTimeSeconds;
        bool isBreatheIn = true;

        Console.WriteLine("Get ready to start the breathing exercise...");

        Thread.Sleep(2000); // Wait for 2 seconds before starting

        while (remainingTime > 0)
        {
            if (isBreatheIn)
            {
                Console.WriteLine($"Breathe in... ({remainingTime} seconds remaining)");
                isBreatheIn = false;
            }
            else
            {
                Console.WriteLine($"Breathe out... ({remainingTime} seconds remaining)");
                isBreatheIn = true;
            }

            Thread.Sleep(1000); // Wait for 1 second
            remainingTime--;
        }

        Console.WriteLine("Breathing exercise completed!");
         Console.Write("Loading menu..");
                    for (int i=5; i>0; i--)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                        // Console.Write("\b");
                    }
                    Console.Clear();
    }

    
    

    // public BreathingActivity(string text)
    // {
    //     Text = text;
    //     _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        
    // }

    // public void Display()
    // {
    //     Console.WriteLine($"Date: {_date}");
    //     Console.WriteLine($"Prompt: {_promptText}");
    //     Console.WriteLine($"Entry: {Text}");
    // }
    
}
