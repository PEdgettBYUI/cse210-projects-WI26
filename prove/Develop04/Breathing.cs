class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity(string name, string description)
    : base(name, description) { }


    public void RunBreathingActivity()
    {
        // Intro & set Duration
        DisplayWelcome();
        ObtainDurationFromUser();
        Console.Clear();
        RunTimer("Get Ready... ", 3);
        Console.WriteLine();
        SetEndTime();

        // Breath in/out
        while (!HasTimerExpired())
        {
            RunTimer("> Breath in...", 4);
            RunTimer("> Breath out...", 6);
        }
        DisplayEndMessage();
        DominoAnimation();
    }
}