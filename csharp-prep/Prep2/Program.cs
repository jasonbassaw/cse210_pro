using System;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
    
    
        Console.Write("What is your percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >=60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        
        Console.WriteLine($"Your grade is: {letter}");
        

    
        if (percent >= 70)
        {
            Console.WriteLine("You passed! Congratulations!");
        }
        
        else 
        {
            Console.WriteLine("Sorry, all the best next time");
        }

    }

}