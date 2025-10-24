using System;
using System.Collections.Generic;

namespace Exam01
{
    internal class Answer
    {
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }
    }
}
