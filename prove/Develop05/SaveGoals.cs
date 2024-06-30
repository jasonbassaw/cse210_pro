using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class SaveGoals
{
    public static void Execute(List<Goal> goals, int score)
    {
        var saveData = new
        {
            Goals = goals,
            Score = score
        };
        string json = JsonSerializer.Serialize(saveData);
        File.WriteAllText("goals.json", json);
    }
}
