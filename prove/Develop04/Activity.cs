using System.ComponentModel.DataAnnotations;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    private DateTime _endTime;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nWell Done!\n You've completed {_duration} seconds of the {_name} Activity");
    }

    public void RunTimer(string message, int duration)
    {
        for (int count = duration; count > 0; count--)
        {
            Console.Write($"\r{message} {count,3}");    // Right-align in 3 spaces
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ObtainDurationFromUser()
    {
        Console.Write("How long do you want your session to be? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void SetEndTime()
    {
        // DateTime currentTime = DateTime.Now;    // Unnecessary??
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void DominoAnimation()
    {
        // Lasts about ~7s @ sleepTime = 200, count = 6
        int sleepTime = 250;
        int count = 6;

        // Simple "Domino" Loading Animation 2 dominos per count
        while (count > 0)
        {
            Console.Write("|");
            Thread.Sleep(sleepTime);  //in miliseconds
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("_");
            Thread.Sleep(sleepTime);
            Console.Write("\\");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("_");
            count--;
        }
    }

}