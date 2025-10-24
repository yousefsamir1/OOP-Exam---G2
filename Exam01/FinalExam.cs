using System;
using System.Collections.Generic;

namespace Exam01
{
    internal class FinalExam : MainExam
    {
        public FinalExam(int time) : base(time) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Final Exam ===");
            Console.WriteLine($"Time: {TimeInMinutes} minutes\n");

            int totalMarks = 0;
            int studentScore = 0;

            for (int i = 0; i < Questions.Count; i++)
            {
                var q = Questions[i];
                q.DisplayQuestion();
                totalMarks += q.Mark;

                Console.Write("Your Answer ID: ");
                int.TryParse(Console.ReadLine(), out int ansId);

                if (ansId == q.RightAnswer)
                    studentScore += q.Mark;

                Console.WriteLine();
            }

            Console.WriteLine("=== Exam Finished ===");
            Console.WriteLine($"Your Score: {studentScore}/{totalMarks}\n");

            Console.WriteLine("Correct Answers:");
            foreach (var q in Questions)
            {
                Console.WriteLine($"{q.Header} → Correct Answer ID = {q.RightAnswer}");
            }
        }
    }
}
