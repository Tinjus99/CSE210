public class Writing : Assignment
{
    private string _title;

    public Writing(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"Title: {_title} by {studentName}";
    }
}