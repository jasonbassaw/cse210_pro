using System;
using System.Collections.Generic;

public class Program
{
    public static List<Goal> Goals { get; private set; }
    public static int Score { get; private set; }

    static Program()
    {
        Goals = new List<Goal>();
        Score = 0;
    }

    public static void Main()
    {
        Menu.Display(Goals,ref Score);
    }
}
