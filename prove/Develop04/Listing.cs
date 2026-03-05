using System.Dynamic;

class ListingActivity : Activity
{
    public string _question;   // Stores the most recently retrieved question
    private int _count;

    List<string> _listingQuestions = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are some chores you recently did?"
        ];

    // Constructor
    public ListingActivity(string name, string description)
    : base(name, description)
    {
        SetRandQuestion();
        _count = 0;
    }

    private void SetRandQuestion()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_listingQuestions.Count);  // Makes sure rand is an index inside of _listingQuestions
        _question = _listingQuestions[randomIndex];
    }

    public void RunListingActivity()
    {
        // Intro & Set Duration
        DisplayWelcome();
        ObtainDurationFromUser();
        Console.Clear();

        // Display question
        Console.WriteLine("Get Ready...");
        DominoAnimation();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_question} ---");

        // Begin Listing Activity
        RunTimer("You may begin in: ", 5);
        SetEndTime();
        Console.Clear();
        Console.WriteLine($" --- {_question} ---");


        // Checks if the timer has expired after listing an item
        while (!HasTimerExpired())
        {
            string input = "";
            while (string.IsNullOrWhiteSpace(input) && !HasTimerExpired())
            {
                Console.Write("> ");
                input = Console.ReadLine();
            }
            if (!HasTimerExpired()) // Only increment if time remains
                _count++;
        }

        // End Activity
        Console.WriteLine($"You listed {_count} Items!\n");
        DisplayEndMessage();
        DominoAnimation();
    }

}