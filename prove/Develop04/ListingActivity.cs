using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ListingActivity
{
    


    public string info_1()
    {
        return "Welcome to the Listing Activity";
    }
    public string instruction_1()
    {
        return "This activity will help you relax by walking your thought breathing in and out slowly. Clear your mind and focus on your breathing";
    }
   

     private static List<string> questions = new List<string>
    {
        "Who are people that you appreciate? ",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void StartListingActivity()
    {
        Console.Write("Enter the time in seconds for the activity: ");
        if (!int.TryParse(Console.ReadLine(), out int totalTimeSeconds) || totalTimeSeconds <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the time.");
            return;
        }

        int remainingTime = totalTimeSeconds;

        Console.WriteLine("Consider the following prompt...");
        Console.WriteLine("-------------------------------------------");
        Thread.Sleep(2000); // Wait for 2 seconds before starting

        Random random = new Random();
        int randomIndex = random.Next(questions.Count);
        string currentQuestion = questions[randomIndex];
        questions.RemoveAt(randomIndex);

        Console.WriteLine($"Question: {currentQuestion}");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        List<string> userAnswers = new List<string>();
        Console.WriteLine("You can start writing your answers:");
        Console.WriteLine($"You have exactly: {totalTimeSeconds} seconds");

        while (remainingTime > 0)
        {
            if (remainingTime <= 5)
            {
                Console.WriteLine($"Time is running out! {remainingTime} seconds remaining.");
            }

            string answer = Console.ReadLine();
            userAnswers.Add(answer);

            Thread.Sleep(1000); // Wait for 1 second
            remainingTime--;

            if (remainingTime <= 0)
            {
                Console.WriteLine("Time's up!");
                break;
            }
        }
        Console.WriteLine("Reflection exercise completed!");
        Console.Write("Loading your answers..");
        for (int i=5; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            // Console.Write("\b");
        }
        Console.Clear();

        // Console.WriteLine("Activity completed!");
        Console.WriteLine("Your answers:");
        foreach (string answer in userAnswers)
        {
            Console.WriteLine(answer);
        }
    
        Console.Write("Loading menu..");
        for (int i=5; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            // Console.Write("\b");
        }
        Console.Clear();
        
    }
    

}
