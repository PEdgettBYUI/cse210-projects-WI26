using System;
using System.ComponentModel;

// This program takes a userInput and creates a list of integer values
// the list stops adding items when the value 0 is entered
// 0 is not appended to the list
// From this list the sum, and average, as well as the largest and smallest values are displayed


class Program
{
    static void Main(string[] args)
    {

        // Create new list reminder:
        // List<t> name = new List<t>();

        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");

        // Initialize Variables
        int sumTotal = 0;
        float avgVal = 0;
        int highest = 0;

        // Create List
        List<int> numbers = new List<int>();

        // Prompt User for a number
        string userInput;
        int parsedInput;
        
        do {
        Console.Write("Enter number: ");
        userInput = Console.ReadLine();
        parsedInput = int.Parse(userInput);

        // Parse the number-string as an int
        // Append it to the list
        if (parsedInput != 0)
            {
            numbers.Add(parsedInput);
            }
        }
        while (parsedInput != 0);

        // Print List
        for (int i=0; i<numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        // Sum List
        for (int i=0; i<numbers.Count; i++)
        {
            sumTotal += numbers[i];
        }
        Console.WriteLine($"The sum is: {sumTotal}");
        // Average List
        // NOTE: Make sure to case at least one of the variables as a float so that it knows to do Floating-Point Division!!
        int listLen = numbers.Count;
        avgVal = ((float)sumTotal)/listLen; 

        Console.WriteLine($"The average is: {avgVal}");

        // Find Max value
        for (int i=0; i<numbers.Count; i++)
        {
            if (numbers[i] > highest)
            {
                highest = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is: {highest}");
    }
}