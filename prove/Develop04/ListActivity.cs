public class ListActivity : Activity
{
    public ListActivity(string name, string describe) : base(name, describe)
    {

    }

    public void Listing()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
        Console.WriteLine("List as many responses you can to the prompt:");
        Console.WriteLine($"---{PromptGenerate()}---");
        Console.Write("You may begin in: 3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Clear();

        List<string> answers = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetSeconds());

        while(startTime < endTime)
        {
            answers.Add(Console.ReadLine());
            startTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {answers.Count} items!");
    }

    public string PromptGenerate()
    {   
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        prompts.Add("What are some good things that happened to you this week?");

        Random rnd = new Random();
        int num = rnd.Next(0, 5);

        return prompts[num];
    }
}