public class Reflection : Activity
{
    private string _reflectionPrompt;
    private string _reflectionQuestion;

    public Reflection(string name, string description, int duration, string beginMessage, string endMessage, string reflectionPrompt, string reflectionQuestion)
        : base(name, description, duration, beginMessage, endMessage)
    {
        _reflectionPrompt = reflectionPrompt;
        _reflectionQuestion = reflectionQuestion;
    }
}