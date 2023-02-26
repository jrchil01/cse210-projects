public class Activity
{
    private string _activityName;
    private string _description;
    private int _seconds;

    public Activity(string name, string describe)
    {
        _activityName = name;
        _description = describe;
        _seconds = 0;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long do you want to do this activity for? ");
        _seconds = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        Spinner();
        Console.WriteLine($"\nYou did the {_activityName} for {_seconds} seconds.");
        Spinner();
    }
    
    public void Spinner()
    {
        for(int i = 0; i < 3; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public int GetSeconds()
    {
        return _seconds;
    }
}