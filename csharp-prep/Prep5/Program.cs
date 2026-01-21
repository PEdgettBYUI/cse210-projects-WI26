using System;

// This program is a demonstration of Functions in C#

class Program
{
    static void Main(string[] args)
    {
        // Structure of a function reminder:
        // returnType FunctionName(dataType parameter1, dataType parameter2)
        // {
        //      // Function body
        // }

        Console.WriteLine("Hello Prep5 World!\n");
        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();


        int squaredNum = SquareNumber(userNumber);

        int birthYear;

        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNum, birthYear);

        Console.WriteLine();
        
}

static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string favNum = Console.ReadLine();

        return int.Parse(favNum);
    }

// Example of "Pass by Reference" function
// Sample Solution referenced;
// NOTE: Look into more later, what even is going on here????
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} this year.");
    }


    

}