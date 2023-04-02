class Battleship : Game
{
    List<string> first = new List<string>();
    List<string> second = new List<string>();
    List<string> third = new List<string>();
    List<string> fourth = new List<string>();
    List<string> fifth = new List<string>();

    private int _turns = 0;
    private string _answer;
    bool _sunk = false;

    public Battleship(string name) : base(name)
    {
        for(int i = 0; i < 5; i++){
            first.Add("*");
            second.Add("*");
            third.Add("*");
            fourth.Add("*");
            fifth.Add("*");
        }
    }

    public void PlayBattleship()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, 5);
        int num2 = rnd.Next(0, 5);

        if(num == 0){
            _answer = "A:" + num2.ToString();
        }else if(num == 1){
            _answer = "B:" + num2.ToString();
        }else if(num == 2){
            _answer = "C:" + num2.ToString();
        }else if(num == 3){
            _answer = "D:" + num2.ToString();
        }else if(num == 4){
            _answer = "E:" + num2.ToString();
        }

        Console.WriteLine("Welcome to Battleship! You have 10 turns to locate the enemy ship before time runs out!");
        Console.WriteLine("Simply input your coordinates as follows - B:4 - with capital letter and colon between.");
        Console.Write("Are you ready? Press enter to begin!");
        Console.ReadLine();

        while(!_sunk && _turns < 10){
            Display();
            Console.Write("Where do you want to launch?");
            string launch = Console.ReadLine();
            Launch(launch);
            Display();
            _turns++;
        }

        if(_sunk){
            Victory();
        }else{
            Loss();
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("  01234");
        Console.WriteLine($"A {first[0]}{first[1]}{first[2]}{first[3]}{first[4]}");
        Console.WriteLine($"B {second[0]}{second[1]}{second[2]}{second[3]}{second[4]}");
        Console.WriteLine($"C {third[0]}{third[1]}{third[2]}{third[3]}{third[4]}");
        Console.WriteLine($"D {fourth[0]}{fourth[1]}{fourth[2]}{fourth[3]}{fourth[4]}");
        Console.WriteLine($"E {fifth[0]}{fifth[1]}{fifth[2]}{fifth[3]}{fifth[4]}");
    }

    public void Launch(string coords){
        string[] parts = coords.Split(":");
        int part = -1;
        string marker = "X";
        if(coords == _answer){
            marker = "O";
            _sunk = true;
        }

        if(parts[0] == "A"){
            part = Int32.Parse(parts[1]);
            first[part] = marker;
        }else if(parts[0] == "B"){
            part = Int32.Parse(parts[1]);
            second[part] = marker;
        }else if(parts[0] == "C"){
            part = Int32.Parse(parts[1]);
            third[part] = marker;
        }else if(parts[0] == "D"){
            part = Int32.Parse(parts[1]);
            fourth[part] = marker;
        }else if(parts[0] == "E"){
            part = Int32.Parse(parts[1]);
            fifth[part] = marker;
        }
    }

    public override void Victory()
    {
        Console.WriteLine("You sunk my battleship!");
    }
}