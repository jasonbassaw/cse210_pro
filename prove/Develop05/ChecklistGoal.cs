public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
        IsCompleted = false;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            CurrentCount++;
            if (CurrentCount >= TargetCount)
            {
                IsCompleted = true;
            }
        }
    }

    public override string GetStatus()
    {
        return IsCompleted ? $"[X] {Name} (Completed {CurrentCount}/{TargetCount} times)" : $"[ ] {Name} (Completed {CurrentCount}/{TargetCount} times)";
    }
}