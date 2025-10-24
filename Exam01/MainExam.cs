using System;
using System.Collections.Generic;

namespace Exam01
{
    abstract internal class MainExam
    {
        public int TimeInMinutes { get; set; }
        public List<MainQuestion> Questions { get; set; } = new List<MainQuestion>();

        protected MainExam(int time)
        {
            TimeInMinutes = time;
        }

        public void AddQuestion(MainQuestion question)
        {
            Questions.Add(question);
        }

        public abstract void ShowExam();
    }
}
