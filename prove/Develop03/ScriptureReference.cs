namespace ScriptureMemorizer
{
    public class ScriptureReference
    {
        private string Book { get; }
        private int Chapter { get; }
        private int VerseStart { get; }
        private int VerseEnd { get; }

        public ScriptureReference(string book, int chapter, int verseStart)
        {
            Book = book;
            Chapter = chapter;
            VerseStart = verseStart;
            VerseEnd = verseStart;
        }

        public ScriptureReference(string book, int chapter, int verseStart, int verseEnd)
        {
            Book = book;
            Chapter = chapter;
            VerseStart = verseStart;
            VerseEnd = verseEnd;
        }

        public override string ToString()
        {
            if (VerseStart == VerseEnd)
                return $"{Book} {Chapter}:{VerseStart}";
            else
                return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
        }
    }
}
