using System;
using System.Collections.Generic;
using System.Linq;

class Exam
{
    protected string Subject { get; set; }
    protected float Score { get; set; }

    public Exam(string subject, float score)
    {
        Subject = subject ?? throw new ArgumentNullException(nameof(subject));
        Score = score;
    }

    public Exam(float score)
    {
        Subject = "null"; 
        Score = score;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Subject: {Subject} \nScore: {Score}");
    }
    public virtual void ShowScore()
    {
        Console.WriteLine($"Score: {Score}");
    }

    public float GetScore()
    {
        return Score;
    }
}


class Test : Exam
{
    protected string TestType { get; set; }

    public Test(string subject, float score, string testType)
        : base(subject, score)
    {
        TestType = testType;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Test Type: {TestType}");
    }
}

class FinalExam : Exam
{
    protected string GraduateWork { get; set; } // bachelor or master diploma
    protected string GraduateWorkTopic { get; set; }

    public FinalExam(float score, string graduateWork, string graduateWorkTopic)
        : base(score)
    {
        GraduateWork = graduateWork;
        GraduateWorkTopic = graduateWorkTopic;
    }

    public override void Show()
    {
        base.ShowScore();
        Console.WriteLine($"Graduate work: {GraduateWork} \nGraduate work topic: <<{GraduateWorkTopic}>>");
    }

    protected float GetFinalExamScore()
    {
        return GetScore();
    }
}

class Program
{
    static void Main()
    {
        List<Exam> examsArray = new List<Exam>();

        examsArray.Add(new Test("English", 90.5f, "Multiple Choice"));
        examsArray.Add(new FinalExam(85, "bachelor", "CRM-system for growing business"));
        examsArray.Add(new Test("OOP_C#", 99f, "Test, Theory and practical task"));

        // Sort array elements by score 
        examsArray = examsArray.OrderByDescending(e => e.GetScore()).ToList();

        foreach (var exam in examsArray)
        {
            exam.Show();
            Console.WriteLine();
        }
    }
}
