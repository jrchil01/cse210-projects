public class Game
{
    private string _gameName;

    public Game(string name)
    {
        _gameName = name;
    }

    public virtual void Victory(){
        Console.WriteLine($"Congratulations! You won {_gameName}.");
        Thread.Sleep(5000);
    }

    public void Loss(){
        Console.WriteLine("Sorry! Better luck next time.");
        Thread.Sleep(5000);
    }
}