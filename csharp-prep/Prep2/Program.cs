using System;

class Program
{
    static void Main(string[] args)
   {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string value = "";

        if (percent >= 90)
        {
            value = "A";
        }
        else if (percent >= 80)
        {
            value = "B";
        }
        else if (percent >= 70)
        {
            value = "C";
        }
        else if (percent >= 60)
        {
            value = "D";
        }
        else
        {
            value = "F";
        }

        Console.WriteLine($"Your grade is: {value}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
