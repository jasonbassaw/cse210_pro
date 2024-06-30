using System;

public class DisplayScore
{
    public static void Execute(int score)
    {
        Console.WriteLine($"Current Score: {score}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
