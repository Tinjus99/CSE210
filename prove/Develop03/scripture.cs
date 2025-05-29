// scripture has reverence and list of verses
public class Scripture
{
    private string _reference;
    private List<Verse> _verses;

    public Scripture(string reference)
    {
        _reference = reference;

        _verses = new List<Verse>();
        foreach (string verse in _verses)
        {
            _verses.Add(new Verse(verse));
        }
    }

    public Scripture(StreamReader reader)
    {
        _reference = reader.ReadLine();

        while (!reader.EndOfStream)
        {
            string text = reader.ReadLine().Trim();
            _verses.Add(new Verse(text));
        }
    }
}