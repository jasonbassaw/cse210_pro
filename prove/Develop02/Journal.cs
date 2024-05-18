using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    class JournalManager
    {
        public List<Entry> journal = new List<Entry>();
        public List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        public Random random = new Random();

        public void Write()
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Write your response: ");
            string response = Console.ReadLine();
            Entry entry = new Entry(prompt, response);
            journal.Add(entry);
            Console.WriteLine("Entry saved successfully.");
        }

        public void Display()
        {
            if (journal.Count == 0)
            {
                Console.WriteLine("Your journal is empty.");
            }
            else
            {
                Console.WriteLine("Your journal entries:");
                foreach (Entry entry in journal)
                {
                    Console.WriteLine(entry);
                }
            }
        }

        public void Save()
        {
            Console.Write("Enter a filename to save your journal: ");
            string filename = Console.ReadLine();
            List<string> entries = new List<string>();
            foreach (Entry entry in journal)
            {
                entries.Add(entry.ToString());
            }
            File.WriteAllLines(filename, entries);
            Console.WriteLine($"Journal saved to {filename}");
        }

        public void Load()
        {
            Console.Write("Enter the filename to load your journal: ");
            string filename = Console.ReadLine();
            journal.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { " - " }, 2, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = lines[Array.IndexOf(lines, line) + 1];
                    Entry entry = new Entry(prompt, response)
                    {
                        Date = date
                    };
                    journal.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        } 
    }
}

    