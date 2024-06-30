using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class LoadGoals
{
    public static void Execute(ref List<Goal> goals, ref int score)
    {
        if (File.Exists("goals.json"))
        {
            string json = File.ReadAllText("goals.json");
            var loadData = JsonSerializer.Deserialize<LoadData>(json);
            goals = loadData.Goals;
            score = loadData.Score;
        }
    }

    private class LoadData
    {
        public List<Goal> Goals { get; set; }
        public int Score { get; set; }
    }
}
