using System;
using System.Collections.Generic;

namespace Exam01
{
    internal class MCQQuestion : MainQuestion
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark)
        {
            //
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
