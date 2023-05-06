public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic){
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList(){
        return $"{_studentName} - {_topic}\nSection {_textbookSection} Problems {_problems}";
    }
}