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
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private static List<string> questions = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> questions_2 = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
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

            if (questions_2.Count > 0)
            {
                int randomIndex_1 = random.Next(questions_2.Count);
                string currentQuestion_1 = questions_2[randomIndex_1];
                questions_2.RemoveAt(randomIndex_1);

                Console.WriteLine($"Question: {currentQuestion_1}");

                int timeLeft_1 = totalTimeSeconds;

                Console.Write($"Loading your answers (Time Left: {timeLeft_1} seconds)...");
                while (timeLeft_1 > 0)
                {
                    Console.Write(new string('\b', Console.CursorLeft));
                    Console.Write(new string(' ', Console.WindowWidth - 1));
                    Console.Write(new string('\b', Console.CursorLeft));
                    Thread.Sleep(1000);
                    timeLeft_1--;
                }

                Console.Clear();
            }
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
