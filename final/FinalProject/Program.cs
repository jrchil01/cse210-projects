using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        while(input != "7"){
            Console.Clear();
            Console.WriteLine("Game Select:");
            Console.WriteLine("1. Hangman");
            Console.WriteLine("2. M.A.S.H.");
            Console.WriteLine("3. Tic Tac Toe");
            Console.WriteLine("4. Personality Quiz");
            Console.WriteLine("5. Battleship");
            Console.WriteLine("6. MadLibs");
            Console.WriteLine("7. Quit");
            input = Console.ReadLine();

            if(input == "1")
            {
                Hangman hangman = new Hangman("hangman");
                hangman.PlayHangman();
            }
            else if(input == "2")
            {
                MASH mash = new MASH("M.A.S.H.");
                mash.PlayMash();
            }
            else if(input == "3")
            {
                TicTacToe tic = new TicTacToe("Tic-Tac-Toe");
                tic.PlayTicTacToe();
            }
            else if(input == "4")
            {
                Quiz quiz = new Quiz("personality quiz");
                quiz.PlayQuiz();
            }
            else if(input == "5")
            {
                Battleship battleship = new Battleship("Battleship");
                battleship.PlayBattleship();
            }
            else if(input == "6")
            {
                MadLibs madlibs = new MadLibs("MadLibs");
                madlibs.PlayMadLibs();
            }
        }
    }
}