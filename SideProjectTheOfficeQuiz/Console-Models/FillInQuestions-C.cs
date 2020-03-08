using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz.ConsoleModels
{
    public class FillInQuestionsC : QuestionC
    {
        public bool TrimResponse { get; set; }
        public FillInQuestionsC(string questionText, string correctResponse, bool isCaseSensitive, bool trimResponse) : base(questionText, correctResponse, isCaseSensitive)
        {
            this.TrimResponse = trimResponse;
        }

        override public bool ValidateAnswerAndSetResponse(string answer)
        {
            if (TrimResponse)
            {
                answer = answer.Trim();
            }
            return base.ValidateAnswerAndSetResponse(answer);
        }
    }
}
