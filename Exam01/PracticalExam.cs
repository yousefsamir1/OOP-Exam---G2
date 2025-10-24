using System;
using System.Collections.Generic;

namespace Exam01
{
    internal class PracticalExam : MainExam
    {
        public PracticalExam(int time) : base(time) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Practical Exam ===");
            Console.WriteLine($"Time: {TimeInMinutes} minutes\n");

            int totalMarks = 0;
            int studentScore = 0;

            foreach (var q in Questions)
            {
                q.DisplayQuestion();
                totalMarks += q.Mark;

                Console.Write("Your Answer ID: ");
                int.TryParse(Console.ReadLine(), out int ansId);

                if (ansId == q.RightAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    studentScore += q.Mark;
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct Answer ID: {q.RightAnswer}\n");
                }
            }

            Console.WriteLine($"Total Score: {studentScore}/{totalMarks}");
        }
    }
}
