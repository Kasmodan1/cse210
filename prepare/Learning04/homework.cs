using System;

public class Homework
{
    private string _studentName;
    private string _topic;

    public Homework(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
        {
           return $"Student Name: {_studentName}\nTopic: {_topic}";
        }



}