using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz.Models
{
   public class Question : QuestionMaster
    {
        // question id text
        public int QuestionId { get; set; }
        //public string Text { get; set; }

        // Added below to mimic MultipleChoiceQuestions-C
        public Dictionary<string, string> PossibleResponses { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public Question()
        {
            
        }

        public Question(string questionText, string correctResponse, Dictionary<string, string> possibleResponses) : base(questionText, correctResponse, false) // isCaseSensitive is false here due to it being a MC question
        {
            this.PossibleResponses = possibleResponses;
        }

        override public string QuestionToDisplay
        {
            get
            {
                string question = base.QuestionToDisplay + "\r\n";

                foreach (KeyValuePair<string, string> pr in PossibleResponses)
                {
                    question += $"\t{pr.Key} - {pr.Value}\r\n";
                }
                return question;
            }
        }

        override public string AnswerPrompt
        {
            get
            {
                return "Select One: ";
            }
        }

        override public bool ValidateAnswerAndSetResponse(string answer)
        {
            if (!this.PossibleResponses.ContainsKey(answer))
            {
                return false;
            }
            base.ValidateAnswerAndSetResponse(answer);
            return true;
        }
    }
}
