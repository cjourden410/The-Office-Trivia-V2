using SideProjectTheOfficeQuiz.Models;
using System.Collections.Generic;

namespace SideProjectTheOfficeQuiz.DAL
{
    public interface IQuestionSqlDAO
    {
        IList<Question> FindQuestionsByTriviaType(string option);
        IList<Question> QuestionChoicesAndAnswers(int questionId, string option);
    }
}