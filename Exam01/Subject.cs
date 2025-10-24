using System;
using System.Collections.Generic;

namespace Exam01
{
    internal class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public MainExam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam(string type, int time)
        {
            if (type.ToLower() == "final")
                Exam = new FinalExam(time);
            else if (type.ToLower() == "practical")
                Exam = new PracticalExam(time);
            else
                Console.WriteLine("Invalid Exam Type");
        }
    }
}
