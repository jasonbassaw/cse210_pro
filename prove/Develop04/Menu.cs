class Menu
{
    private List<string> options = new List<string>
    {
        "Breathing Activity",
        "Reflection Activity",
        "Listing Activity",
        "Exit"
    };

    public int ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an activity:");

        for (int i = 0; i < options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }

        Console.Write("Enter your choice: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > options.Count)
        {
            Console.Write("Invalid choice. Please try again: ");
        }

        return choice - 1;
    }
}