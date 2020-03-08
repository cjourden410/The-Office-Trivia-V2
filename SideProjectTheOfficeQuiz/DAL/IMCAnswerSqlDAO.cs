using SideProjectTheOfficeQuiz.Models;
using System.Collections.Generic;

namespace SideProjectTheOfficeQuiz.DAL
{
    public interface IMCAnswerSqlDAO
    {
        IList<MCAnswer> GetAnswerById(int questionId);
        IList<MCAnswer> MCAnswerOptions(int questionId);
    }
}