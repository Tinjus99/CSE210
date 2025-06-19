public class Breathing : Activity
{
    private string _breatheIn;
    private string _breatheOut;
    private string _holdBreath;
    public Breathing(string name, string description, int duration, string beginMessage, string endMessage, string holdbreath, string breatheIn, string breatheOut)
        : base(name, description, duration, beginMessage, endMessage)
    {
        _breatheIn = breatheIn;
        _breatheOut = breatheOut;
        _holdBreath = holdbreath;
    }

    // public string GetBreathingInstructions()
    // {
    //     return $"{name}";
    // }
}