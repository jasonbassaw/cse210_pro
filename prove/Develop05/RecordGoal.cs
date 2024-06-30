using System;
using System.Collections.Generic;

public class RecordGoal
{
    public static void Execute(List<Goal> goals, ref int score)
    {
        Console.WriteLine("Choose a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;
        goals[choice].RecordEvent();
        score += goals[choice].Points;
        if (goals[choice] is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
        {
            score += checklistGoal.BonusPoints;
        }
    }
}
