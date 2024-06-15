class BreathingActivity: Activity
{
    public override void Run()
    {
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Loading(5); // Display the loading spinner for 5 seconds

        int breathCount = 0;
        while (breathCount < duration)
        {
            Console.WriteLine("Breathe in...");
            Sleep(4); // Pause for 4 seconds
            Console.WriteLine("Breathe out...");
            Sleep(6); // Pause for 6 seconds
            breathCount += 10; // Increment the breathCount by 10 seconds
        }

        Console.WriteLine("Well done! You have completed the Breathing Activity.");
    }
}