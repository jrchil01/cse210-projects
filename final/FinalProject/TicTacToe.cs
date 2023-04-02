public class TicTacToe : Game
{
    List<string> first = new List<string>();
    List<string> second = new List<string>();
    List<string> third = new List<string>();
    private bool _IsWon = false;
    public TicTacToe(string name) : base(name)
    {
        for(int i = 0; i < 3; i++){
            first.Add("_");
            second.Add("_");
            third.Add("_");
        }
    }

    public void PlayTicTacToe()
    {
        Console.WriteLine("You are x's; I shall play o's. You start.");
        while(!_IsWon)
        {
            Display();
            Console.WriteLine("Choose an empty space to place. Ex) B:2 (make sure to capitalize and use the colon).");
            string choice = Console.ReadLine();
            Place(choice);
            Display();
            Check();
            if(_IsWon){
                break;
            }
            Thread.Sleep(3000);
            Console.WriteLine("Opponent's turn!");
            Other();
            Console.Clear();
            Display();
            Check();
            Console.Clear();
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        Console.WriteLine($"A {first[0]}|{first[1]}|{first[2]}");
        Console.WriteLine($"B {second[0]}|{second[1]}|{second[2]}");
        Console.WriteLine($"C {third[0]}|{third[1]}|{third[2]}");
    }

    public void Place(string placement){
        string[] parts = placement.Split(":");
        int part = -1;
        if(parts[0] == "A"){
            part = Int32.Parse(parts[1]);
            first[part] = "X";
        }else if(parts[0] == "B"){
            part = Int32.Parse(parts[1]);
            second[part] = "X";
        }else if(parts[0] == "C"){
            part = Int32.Parse(parts[1]);
            third[part] = "X";
        }
    }

    public void Other()
    {
        bool placed = false;
        while(!placed){
            Random rnd = new Random();
            int num = rnd.Next(0, 3);
            int num2 = rnd.Next(0, 3);
            if(num == 0){
                if(first[num2] == "_"){
                    first[num2] = "O";
                    placed = true;
                }
            }else if(num == 1){
                if(second[num2]=="_"){
                    second[num2] = "O";
                    placed = true;
                }
            }else if(num == 2){
                if(third[num2] == "_"){
                    third[num2] = "O";
                    placed = true;
                }
            }
        }
    }

    public void Check(){
        if(first[0] == first[1] && first[0] == first[2]){
            if(first[0] == "X"){
                Victory();
                _IsWon = true;
            }else if(first[0] == "O"){
                Loss();
                _IsWon = true;
            }
        }else if(second[0] == second[1] && second[0] == second[2]){
            if(second[0] == "X"){
                Victory();
                _IsWon = true;
            }else if(second[0] == "O"){
                Loss();
                _IsWon = true;
            }
        }else if(third[0] == third[1] && third[0] == third[2]){
            if(third[0] == "X"){
                Victory();
                _IsWon = true;
            }else if(third[0] == "O"){
                Loss();
                _IsWon = true;
            }
        }else if(first[1] == third[1] && first[1] == second[1]){
            if(first[1] == "X"){
                Victory();
                _IsWon = true;
            }else if(first[1] == "O"){
                Loss();
                _IsWon = true;
            }
        }else if(first[2] == third[2] && first[2] == second[2]){
            if(first[2] == "X"){
                Victory();
                _IsWon = true;
            }else if(first[2] == "O"){
                Loss();
                _IsWon = true;
            }
        }else if(first[0] == third[0] && first[0] == second[0]){
            if(first[0] == "X"){
                Victory();
                _IsWon = true;
            }else if(first[0] == "O"){
                Loss();
                _IsWon = true;
            }  
        }else if(first[0] == third[2] && first[0] == second[1]){
            if(first[0] == "X"){
                Victory();
                _IsWon = true;
            }else if(first[0] == "O"){
                Loss();
                _IsWon = true;
            }
        }else if(first[2] == third[0] && first[2] == second[1]){
            if(first[2] == "X"){
                Victory();
                _IsWon = true;
            }else if(first[2] == "O"){
                Loss();
                _IsWon = true;
            }
        }
    }

}