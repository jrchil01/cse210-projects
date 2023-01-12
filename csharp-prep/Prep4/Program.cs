using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int answer = 1;
        int sum = 0;
        decimal average;
        int maximum = 0;

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        while(answer != 0){
            Console.Write("Enter: ");
            answer = int.Parse(Console.ReadLine());
            if(answer != 0){
                numbers.Add(answer);
                sum += answer;
            }

            if(answer > maximum){
                maximum = answer;
            }
        }

        average = ((decimal)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum is: {maximum}");
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}