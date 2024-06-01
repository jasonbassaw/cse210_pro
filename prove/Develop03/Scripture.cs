namespace ScriptureMemorizer
{
    public class Scripture
    {
        private readonly List<string> _words = new();
        private readonly List<bool> _hiddenWords = new();

        public string Text { get; }

        public bool AllWordsHidden => _hiddenWords.All(hidden => hidden);

        public Scripture(string text)
        {
            Text = text;
            InitializeWords(text);
        }

        private void InitializeWords(string text)
        {
            _words.AddRange(text.Split(' '));
            _hiddenWords.AddRange(Enumerable.Repeat(false, _words.Count));
        }

        public void Practice()
        {
            Console.WriteLine("Press enter to reveal the scripture. Type 'quit' to exit.");
            while (!AllWordsHidden)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    return;
                Console.Clear();
                HideRandomWord();
                Console.WriteLine(this);
            }
        }

        public void HideRandomWord()
        {
            Random random = new();
            int index = random.Next(0, _words.Count);
            while (_hiddenWords[index])
            {
                index = random.Next(0, _words.Count);
            }
            _hiddenWords[index] = true;
        }

        public override string ToString()
        {
            return string.Join(' ', _words.Select((word, index) => _hiddenWords[index] ? "____" : word));
        }
    }
}
