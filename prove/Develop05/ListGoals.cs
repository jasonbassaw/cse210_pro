public class ListGoals
{
    public static void Execute(List<Goal> goals)
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
