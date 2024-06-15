class ListingActivity : Activity
{
    private readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Run()
    {
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Loading(5); // Display the loading spinner for 5 seconds

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        Console.WriteLine("Start listing items:");
        Loading(3); // Display the loading spinner for 3 seconds

        List<string> items = new List<string>();
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
            elapsedTime += 5; // Assume each item takes 5 seconds to enter
        }

        Console.WriteLine();
        Console.WriteLine("You listed the following items:");
        foreach (string item in items)
        {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine($"You listed {items.Count} items in total.");
        Console.WriteLine("Well done! You have completed the Listing Activity.");
    }
}