// verse has list of words
public class Verse
{
    private List<Word> _words;
    public Verse(string text)
    {
        string[] parts = text.Split();
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
}