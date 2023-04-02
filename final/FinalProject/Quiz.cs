public class Quiz : Game
{   
    private int _beetle = 0;
    private int _worm = 0;
    private int _butterfly = 0;
    public Quiz(string name) : base(name)
    {

    }

    public void PlayQuiz()
    {
        Console.WriteLine("This activity is a fun personality quiz. Make sure to answer with capital letters!");
        string vote = "";

        Console.WriteLine("Would you rather:\nA: Flit about in the air\nB: Crawl around in the dirt\nC: Chill under a log");
        vote = Console.ReadLine();
        CountVote(vote);
        Console.Clear();

        Console.WriteLine("Is your skin:\nA: Silky and soft\nB: Slimy and wet\nC: Tough and chitonous");
        vote = Console.ReadLine();
        CountVote(vote);
        Console.Clear();

        Console.WriteLine("Is you diet comprised of:\nA: Nectar\nB: Decomposing rot\n C: Weevils and leaves");
        vote = Console.ReadLine();
        CountVote(vote);
        Console.Clear();

        Console.WriteLine("How many subspecies of you are there?\nA: 17,500\nB: 2,700\nC: 350,000");
        vote = Console.ReadLine();
        CountVote(vote);
        Console.Clear();

        Console.WriteLine("What is general societies first reaction to you?\nA: Ooh, pretty!\nB: Ugh, yuck!\nC: Whoa, cool!");
        vote = Console.ReadLine();
        CountVote(vote);
        Console.Clear();

        if(_beetle > _butterfly && _beetle > _worm){
            Console.WriteLine("Congrats! You are a majestic beetle! Hardshelled and dependable, you really can tough out even the most perilous situations.");
        }else if(_butterfly > _beetle && _butterfly > _worm){
            Console.WriteLine("Congrats! You are a beautiful butterfly! Lovely and graceful, you are often seen as the life of the party.");
        }else if(_worm > _butterfly && _worm > _beetle){
            Console.WriteLine("Congrats! You are a squicky worm! Lots of people think you're gross, but you are the backbone of society as we know it.");
        }
    }

    public void CountVote(string vote)
    {
        if(vote == "A"){
            _beetle++;
        }else if(vote == "B"){
            _worm++;
        }else if(vote == "C"){
            _butterfly++;
        }
    }

    public override void Victory()
    {
        Console.WriteLine("You completed the personality quiz!");
    }
}