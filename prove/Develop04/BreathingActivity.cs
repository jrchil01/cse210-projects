public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string describe) : base(name, describe)
    {

    }

    public void Breath()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetSeconds());

        while(startTime < endTime)
        {
            Console.Write("Breathe in");
            for(int i = 0; i < 5; i++){
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Write("\nBreathe out");
            for(int i = 0; i < 5; i++){
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n");
            startTime = DateTime.Now;
        }
    }
}