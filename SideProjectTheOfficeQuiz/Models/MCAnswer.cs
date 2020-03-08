using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz.Models
{
    public class MCAnswer
    {
        public int AnswerId { get; set; }
        public string Choice { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
    }
}
