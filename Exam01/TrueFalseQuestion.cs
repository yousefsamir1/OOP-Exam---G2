using System;
using System.Collections.Generic;

namespace Exam01
{
    internal class TrueFalseQuestion : MainQuestion
    {
        public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark)
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine(ToString());
            foreach (var ans in Answers)
            {
                Console.WriteLine(ans);
            }
        }
    }
}
