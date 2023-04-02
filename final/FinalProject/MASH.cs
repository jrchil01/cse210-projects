public class MASH : Game
{
    private string _job;
    private string _love;
    private string _home;
    private string _vehicle;
    private string _kid;

    public MASH(string name) : base(name)
    {      
        
    }

    public void PlayMash()
    {
        string[] job = {"teacher", "chef", "musician", "landscaper", "zookeeper"};
        List<string> jobs = new List<string>(job);
        string[] love = {"Kermit", "Miss Piggy", "Animal", "Fozzi Bear", "Gonzo"};
        List<string> loves = new List<string>(love);
        string[] home = {"mansion", "apartment", "shack", "house", "garbage can"};
        List<string> homes = new List<string>(home);
        string[] vehicle = {"yacht", "tricycle", "motorbike", "truck", "Vespa"};
        List<string> vehicles = new List<string>(vehicle);
        string[] kid = {"1", "3", "0", "5", "14"};
        List<string> kids = new List<string>(kid);


        Console.WriteLine("Welcome to MASH! The dating game that predicts your future!");
        Console.WriteLine("Roll the dice for each category to see how your future ends up!");
        Console.Write("Let's see who your love is! Press Enter to roll the dice.");
        Console.ReadLine();
        int dice = Diceroll() % 5;
        _love = loves[dice];
        Console.Write("Next, let's see what job you will have.");
        Console.ReadLine();
        dice = Diceroll() % 5;
        _job = jobs[dice];
        Console.Write("Great! Now, let's see where you will end up living.");
        Console.ReadLine();
        dice = Diceroll() % 5;
        _home = homes[dice];
        Console.Write("Excellent. Next, let's determine what vehicle you will own.");
        Console.ReadLine();
        dice = Diceroll() % 5;
        _vehicle = vehicles[dice];
        Console.Write("Finally, let's see how many kids you will have.");
        Console.ReadLine();
        dice = Diceroll() % 5;
        _kid = kids[dice];
        Console.WriteLine("Let's put that all together!");
        Console.Clear();
        Console.WriteLine($"When you grow up, you will marry {_love} and live in a {_home} with your {_kid} kids.");
        Console.WriteLine($"Every morning, you will drive your {_vehicle} to work, where you work as a {_job}");
        Thread.Sleep(3000);
        Victory();
    }

    public int Diceroll()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, 12);
        Console.WriteLine(num);
        return num;
    }
}
