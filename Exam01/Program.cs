using System;
using System.Collections.Generic;

namespace Exam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subj = new Subject(1, "Programming");
            subj.CreateExam("final", 60);

            var q1 = new MCQQuestion("Q1", "What is the output of 2 + 2?", 5);
            q1.Answers.Add(new Answer(1, "3"));
            q1.Answers.Add(new Answer(2, "4"));
            q1.Answers.Add(new Answer(3, "22"));
            q1.RightAnswer = 2;

            var q2 = new TrueFalseQuestion("Q2", "C# is a programming language.", 3);
            q2.RightAnswer = 1;

            subj.Exam.AddQuestion(q1);
            subj.Exam.AddQuestion(q2);

            subj.Exam.ShowExam();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
