using System;
using System.Collections.Generic;

public class Menu
{
    public static void Display(List<Goal> goals, ref int score)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    CreateGoal.Execute(goals);
                    break;
                case "2":
                    ListGoals.Execute(goals);
                    break;
                case "3":
                    RecordGoal.Execute(goals, ref score);
                    break;
                case "4":
                    DisplayScore.Execute(score);
                    break;
                case "5":
                    SaveGoals.Execute(goals, score);
                    break;
                case "6":
                    LoadGoals.Execute(ref goals, ref score);
                    break;
                case "7":
                    exit = true;
                    break;
            }
        }
    }
}
