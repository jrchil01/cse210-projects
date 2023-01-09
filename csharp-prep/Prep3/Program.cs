using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int answer = 0;
        int turns = 0;

        while(answer != number){
            Console.Write("Guess the magic number: ");
            answer = int.Parse(Console.ReadLine());

            turns += 1;
            if(answer > number){
                Console.WriteLine("Lower");
            }else if(answer < number){
                Console.WriteLine("Higher");
            }else{
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine($"You got it in {turns} turns.");

    }
}