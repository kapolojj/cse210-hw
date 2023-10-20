using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ReflectingActivity
{
    public string info_1()
    {
        return "Welcome to the Reflection Activity";
    }

    public string instruction_1()
    {
        return "This activity will help you relax by walking your thought breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    private static List<string> questions = new List<string>
    {
        "When have you felt the Holy Ghost this month?",
        "What promptings did you get reading the scriptures today?",
        "In what way did you follow the Savior today?",
        "What plans do you have for your family this week?",
        "What are things do you plan to do better this week?"
    };

    public void StartReflectionActivity()
    {
        Console.Write("Enter the time in seconds for the activity: ");
        if (!int.TryParse(Console.ReadLine(), out int totalTimeSeconds) || totalTimeSeconds <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the time.");
            return;
        }

        Console.WriteLine("Consider the following prompt...");
        Console.WriteLine("-------------------------------------------");
        Thread.Sleep(2000); // Wait for 2 seconds before starting

        Random random = new Random();

        while (totalTimeSeconds > 0 && questions.Count > 0)
        {
            int randomIndex = random.Next(questions.Count);
            string currentQuestion = questions[randomIndex];
            questions.RemoveAt(randomIndex);

            Console.WriteLine($"Question: {currentQuestion}");

            int timeLeft = totalTimeSeconds;

            Console.Write($"Loading your answers (Time Left: {timeLeft} seconds)...");
            while (timeLeft > 0)
            {
                Console.Write(new string('\b', Console.CursorLeft));
                Console.Write(new string(' ', Console.WindowWidth - 1));
                Console.Write(new string('\b', Console.CursorLeft));
                Thread.Sleep(1000);
                timeLeft--;
            }

            Console.Clear();
        }

        Console.WriteLine("Reflection exercise completed!");
        
        // Add loading messages
        Console.Write("Loading menu...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.Clear();
    }
}
