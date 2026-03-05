using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Menu mainmenu = new Menu();

        int choice = 0;
        while (choice != 4)
        {
            mainmenu.displayMenu();

            // Parse User Choice in Menu
            Console.Write("Choose: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;   // Skip to Next Loop Iteration
            }
            // choice = int.Parse(Console.ReadLine());
                Console.Clear();

            switch (choice)
            {
                // Breathing
                case 1:
                    BreathingActivity Breath = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                    Breath.RunBreathingActivity();
                    break;
                // Reflecting
                case 2:
                    ReflectingActivity Reflect = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                    Reflect.RunReflectingActivity();
                    break;
                // Listing
                case 3:
                    ListingActivity List = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                    List.RunListingActivity();
                    break;
                // Quit
                case 4:
                    break;
                // Error Handling
                default:
                    Console.WriteLine("Please input a number from 1-4.");
                    break;
            }
        }

    }
}