using System;

public class Math : Homework
{
    private string _textbookSection;
    private string _problems;

    public Math(string textbookSection, string problems, string studentName, string topic)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetMathInformation()
    {
        string studentName = GetStudentName();
        string topic = GetTopic();

        return $"Student Name: {studentName}\nTopic: {topic}\nTextbook Section: {_textbookSection}\nProblems: {_problems}";
    }

    public string GetHomeworkList()
    {
        return $"Textbook Section: {_textbookSection}\nProblems: {_problems}";
    }
}