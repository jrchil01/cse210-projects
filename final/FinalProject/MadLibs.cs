class MadLibs : Game
{
    private string _noun;
    private string _noun2;
    private string _noun3;
    private string _noun4;
    private string _noun5;
    private string _adjective;
    private string _adjective2;
    private string _adjective3;
    private string _verb;
    private string _verb2;
    private string _verb3;
    private string _location;
    private string _name;


    public MadLibs(string name) : base(name)
    {

    }

    public void PlayMadLibs()
    {
        Console.WriteLine("Welcome to MadLibs! You will be prompted for various words and at the end they will come together in a story.");
        Thread.Sleep(3000);
        Console.Clear();

        Console.Write("Noun: ");
        _noun = Console.ReadLine();
        Console.Write("Noun: ");
        _noun2 = Console.ReadLine();
        Console.Write("Noun: ");
        _noun3 = Console.ReadLine();
        Console.Write("Noun: ");
        _noun4 = Console.ReadLine();
        Console.Write("Verb: ");
        _verb = Console.ReadLine();
        Console.Write("Verb: ");
        _verb2 = Console.ReadLine();
        Console.Write("Verb: ");
        _verb3 = Console.ReadLine();
        Console.Write("Location: ");
        _location = Console.ReadLine();
        Console.Write("Adjective: ");
        _adjective = Console.ReadLine();
        Console.Write("Adjective: ");
        _adjective2 = Console.ReadLine();
        Console.Write("Adjective: ");
        _adjective3 = Console.ReadLine();
        Console.Write("Name: ");
        _name = Console.ReadLine();

        Console.Clear();
        Thread.Sleep(1500);

        Console.WriteLine($"\"{_noun}!\" said I, \"thing of{_adjective}!-{_noun} still if {_noun2} or {_noun3}!");
        Console.WriteLine($"By that Heaven that {_verb} above us-by that God we both {_verb2}-");
        Console.WriteLine($"{_verb3} this soul with sorrow laden if, within the distant {_location},");
        Console.WriteLine($"It shall clasp a {_adjective2} {_noun4} whom the angels name {_name}-");
        Console.WriteLine($"Clasp a {_adjective3} and radiant {_noun4} whom the angels name {_name}.\"");
        Console.WriteLine($"Quoth the {_noun5} \"Nevermore\"");
        Thread.Sleep(6000);
    }
}