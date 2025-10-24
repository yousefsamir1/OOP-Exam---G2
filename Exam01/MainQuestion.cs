using System;
using System.Collections.Generic;

namespace Exam01
{
    abstract internal class MainQuestion
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();

        public int RightAnswer { get; set; }

        public abstract void DisplayQuestion();

        protected MainQuestion(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
    }
}
