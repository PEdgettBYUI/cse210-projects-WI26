using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Welcome to the Score to Letter Grade Converter!");

        // Initialize Variables
        int num = 0;
        string letter;

        Console.Write("Input your score (0-100): ");
        string userInput = Console.ReadLine();
        num = int.Parse(userInput);

        // Determine letter grade
        if (num >= 90)
        {
            letter = "A";
        }
        else if (num >= 80)
        {
            letter = "B";
        }
        else if (num >= 70)
        {
            letter = "C";
        }
        else if (num >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is {letter}.");

        // Pass check

        if (num >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You Failed. Try again next semester");
        }
    }
}