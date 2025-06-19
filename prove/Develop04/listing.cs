public class Listing : Activity
{
    private string _listingPrompt;

    public Listing(string name, string description, int duration, string beginMessage, string endMessage, string listingPrompt)
        : base(name, description, duration, beginMessage, endMessage)
    {
        _listingPrompt = listingPrompt;
    }
}