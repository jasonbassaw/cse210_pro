using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator  = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 9;
        while (guess != magicNumber)
        {
            Console.Write("what is your guess: ");
            guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}