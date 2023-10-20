using System;

class Program
{
    static void Main(string[] args)
    {
        // Journal myJournal = new Journal();
        // PromptGenerator promptGenerator = new PromptGenerator();
        

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                    Console.Clear();
                    

                    BreathingActivity Info_object = new BreathingActivity ();
                    var info_1 = Info_object.info_1 ();
                    Console.WriteLine($"{info_1}");
                    Console.WriteLine();

                    BreathingActivity instruction_object = new BreathingActivity ();
                    var instruction_1 = instruction_object.instruction_1 ();
                    Console.WriteLine($"{instruction_1}");
                    Console.WriteLine();

                    BreathingActivity breathingExercise = new BreathingActivity();
                    breathingExercise.StartBreathing();
                    
                   
                        break;
                    case 2:
                    Console.Clear();
                    

                    ReflectingActivity Infoo_object = new ReflectingActivity ();
                    var infoo_1 = Infoo_object.info_1 ();
                    Console.WriteLine($"{infoo_1}");
                    Console.WriteLine();

                    ReflectingActivity instruction_object2 = new ReflectingActivity ();
                    var instruction_2 = instruction_object2.instruction_1 ();
                    Console.WriteLine($"{instruction_2}");
                    Console.WriteLine();

                    ReflectingActivity exercise = new ReflectingActivity();
                    exercise.StartReflectionActivity();

                        // myJournal.DisplayAll();
                        break;
                    case 3:
                        Console.Clear();
                    

                    ListingActivity Infooo_object = new ListingActivity ();
                    var infooo_1 = Infooo_object.info_1 ();
                    Console.WriteLine($"{infooo_1}");
                    Console.WriteLine();

                    ListingActivity instruction_object3 = new ListingActivity ();
                    var instruction_3 = instruction_object3.instruction_1 ();
                    Console.WriteLine($"{instruction_3}");
                    Console.WriteLine();

                    ListingActivity exercise_2 = new ListingActivity();
                    exercise_2.StartListingActivity();
                        break;
                    case 4:
                        Console.Write("Quiting Programme...");
                        for (int i=5; i>0; i--)
                        {
                            Console.Write(".");
                            Thread.Sleep(1000);
                            // Console.Write("\b");
                        }
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    case 5:
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
