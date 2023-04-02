public class Hangman : Game
{
    private string _word;
    private string _guess = "";
    private bool _isHanged = false;
    private int parts = 0;

    public Hangman(string name) : base(name)
    {

    }

    public void PlayHangman()
    {
        GenerateWord();
        List<string> letters = new List<string>();
        for(int i = 0; i < _word.Length; i++){
            letters.Add(_word[i].ToString());
            _guess += "_";
        }

        while(!_isHanged){
            Console.WriteLine("Guess a letter");
            Console.WriteLine(_guess);
            string guessLetter = Console.ReadLine();

            bool isGuessed = false;
            for(int i = 0; i < letters.Count; i++)
            {
                if(guessLetter == letters[i])
                {
                    _guess = _guess.Remove(i, 1).Insert(i, guessLetter);
                    isGuessed = true;
                }
            }

            if(!isGuessed)
            {  
                Console.Clear();
                parts++;
                Doodle();
            }else{
                isGuessed = false;
            }

            if(_guess == _word){
                Victory();
                break;
            }
        }
        
    }

    public void GenerateWord()
    {
        List<string> words = new List<string>();
        words.Add("giraffe");
        words.Add("jinx");
        words.Add("mercy");
        words.Add("laugh");
        words.Add("empty");
        words.Add("teacher");
        words.Add("playful");

        Random rnd = new Random();
        int num = rnd.Next(0, 7);
        _word = words[num];
    }

    public void Doodle()
    {
        if(parts == 1){
            Console.WriteLine(" O");
        }else if(parts == 2){
            Console.WriteLine(" O\n |");
        }else if(parts == 3){
            Console.WriteLine(" O\n/|");
        }else if(parts == 4){
            Console.WriteLine(" O\n/|\\");
        }else if(parts == 5){
            Console.WriteLine(" O\n/|\\\n/");
        }else if(parts == 6){
            Console.WriteLine(" O\n/|\\\n/ \\");
            _isHanged = true;
            Loss();
        }else{
            Console.WriteLine("");
        }
    }

    public override void Victory()
    {
        Console.WriteLine($"Congratulations! You won hangman with only {parts} mistakes!");
        Thread.Sleep(5000);
    }
}