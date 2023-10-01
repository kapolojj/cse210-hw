using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        var references = new List<Reference>
        {
            new Reference("John", 3, 16),
        };

        foreach (var reference in references)
        {
            var scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");
            var hideWordCount = 0;

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Press Enter to reveal words or type 'quit' to exit:");
                var input = Console.ReadLine();

                if (input != null && input.ToLower() == "quit")
                    return;

                hideWordCount += 1; 
                scripture.HideRandomWords(hideWordCount);

                
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words in this scripture are hidden. Press Enter to continue.");
                    Console.ReadLine();
                    break; 
                }
                else
                {
                    
                    Console.ReadLine();
                }
            }
        }
        Console.WriteLine("All scriptures are completed. Press Enter to exit.");
        Console.ReadLine();
    }
}