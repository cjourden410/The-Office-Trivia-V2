using SideProjectTheOfficeQuiz.Models;
using System.Collections.Generic;

namespace SideProjectTheOfficeTrivia.DAL
{
    public interface ITriviaSqlDAO
    {
        IList<Trivia> GetAllTriviaTypes();
    }
}