public class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string describe) : base(name, describe)
    {

    }

    public void Reflect()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"---{PromptGenerate()}---");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: 3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetSeconds());

        while(startTime < endTime)
        {
            Console.Write($"> {Generate2()}  ");
            Spinner();
            Spinner();
            Console.Write("\n");
            startTime = DateTime.Now;
        }
    }

    public string PromptGenerate()
    {   
        List<string> prompts = new List<string>();
        prompts.Add("Think about a time you stood up for your beliefs");
        prompts.Add("Think about a time that you overcame something difficult");
        prompts.Add("Think about a time you helped someone in need");
        prompts.Add("Think about a time you accomplished something you're proud of");

        Random rnd = new Random();
        int num = rnd.Next(0, 4);

        return prompts[num];
    }

    public string Generate2()
    {   
        List<string> prompts = new List<string>();
        prompts.Add("Why was this experience meaningful to you?");
        prompts.Add("Had you ever done anything like this before?");
        prompts.Add("How did you feel when it was complete?");
        prompts.Add("What was your favorite thing about this experience?");
        prompts.Add("What can you learn from this experience for the future?");
        prompts.Add("What did you learn about yourself from this experience?");
        prompts.Add("How will you take these lessons to help you in the future?");

        Random rnd = new Random();
        int num = rnd.Next(0, 7);

        return prompts[num];
    }
}