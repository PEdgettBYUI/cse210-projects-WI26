using System.Dynamic;

class ReflectingActivity : Activity
{
    public string _prompt;
    public string _question;   // Stores the most recently retrieved question
    List<string> _reflectPrompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you did something spontaneous"
        ];

    List<string> _reflectQuestions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?,",
        "How can you keep this experience in mind in the future?"
        ];

    // Constructor
    public ReflectingActivity(string name, string description)
    : base(name, description)
    {
        SetRandPrompt();
        SetRandQuestion();
    }

    private void SetRandPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_reflectPrompts.Count);  // Makes sure rand is an index inside of _reflectPrompts
        _prompt = _reflectPrompts[randomIndex];
    }

    private void SetRandQuestion()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_reflectQuestions.Count);  // Makes sure rand is an index inside of _reflectQuestions
        _question = _reflectQuestions[randomIndex];
    }

    public void RunReflectingActivity()
    {
        // Intro & Set Duration
        DisplayWelcome();
        ObtainDurationFromUser();
        Console.Clear();

        // Display Prompt; wait for user input
        Console.WriteLine($"\nConsider the Following Prompt:\n");
        Console.WriteLine($"--- {_prompt} ---\n");
        Console.Write("When you have something in mind, press ENTER to continue.");
        Console.Read();

        // Begin Reflection
        Console.WriteLine("Now, Ponder on each of the following questions as they related to this experience.");
        RunTimer("Get Ready... ", 5);
        SetEndTime();
        Console.Clear();

        // Display random question 
        while (!HasTimerExpired())
        {
            Console.Write($"\n> {_question}");
            DominoAnimation();
            SetRandQuestion();
        }

        // End Activity
        DisplayEndMessage();
        DominoAnimation();
    }

}