public class CreateGoal
{
    public static void Execute(List<Goal> goals)
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("Enter goal name: ");
                string simpleName = Console.ReadLine();
                Console.Write("Enter points: ");
                int simplePoints = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(simpleName, simplePoints));
                break;
            case "2":
                Console.Write("Enter goal name: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter points: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(eternalName, eternalPoints));
                break;
            case "3":
                Console.Write("Enter goal name: ");
                string checklistName = Console.ReadLine();
                Console.Write("Enter points: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(checklistName, checklistPoints, targetCount, bonusPoints));
                break;
        }
    }
}
