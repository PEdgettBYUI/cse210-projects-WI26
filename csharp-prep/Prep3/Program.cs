using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Game Start Initialized
        string replay = "y";
        do {
            // Greeter & Instructions
            Console.WriteLine("Hello Prep3 World!");
            Console.WriteLine("This is the Guess My Number Game!");
            Console.WriteLine("In this game, you will give us the \"Magic Number\", and we will choose a number from 1 to the \"Magic Number\" that you have to guess!\n");


            // // Request "Magic number" from user
            // string userInput = " ";
            int maxNum = 100;

            // Console.Write("What is the Magic Number: ");
            // userInput = Console.ReadLine();
            // maxNum = int.Parse(userInput);

            // Initialize Magic Number
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, maxNum);
            Console.WriteLine($"Game Difficulty: 1 to {maxNum}\n\n");

            Console.WriteLine(magicNum); //TESTING ONLY

            
            string guess;   // UserInput of Guess
            int n_guess;    // Converted Guess to int
            int tries = 0;      // Count of guesses
            // Start game

            do {
                tries++;
                Console.Write("What's your guess? ");
                guess = Console.ReadLine();
                n_guess = int.Parse(guess);

                if (n_guess > magicNum)
                {
                    Console.WriteLine("Too High.");
                }
                else if (n_guess < magicNum)
                {
                    Console.WriteLine("Too Low.");
                }
            }
            while (n_guess != magicNum);

            Console.WriteLine("YOU'VE WON!!!!!!");
            Console.WriteLine($"It took you {tries} tries!\n\n");

            // Ask to continue or not; if not, then exit
            Console.WriteLine("Do you want to play again? \nType 'y' to replay, or press ENTER to EXIT. ");
            replay = Console.ReadLine();
        }
        while (replay == "y");
    }

}