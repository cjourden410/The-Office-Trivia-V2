using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideProjectTheOfficeQuiz.ConsoleModels
{
    public class TriviaC
    {
        public List<QuestionC> Questions { get; set; }

        public string Name { get; set; }

        public double Score
        {
            get
            {
                int numQuestions = 0;
                double total = 0.0;
                foreach (QuestionC qs in Questions)
                {
                    if (qs.IsComplete)
                    {
                        numQuestions++;
                        total += qs.Correctness;
                    }
                }
                return (numQuestions > 0) ? total * 100 / numQuestions : 0.0;
            }
        }
        public bool IsComplete
        {
            get
            {
                return Questions.Where(qs => !qs.IsComplete).Count() == 0;
            }
        }
    }
}
