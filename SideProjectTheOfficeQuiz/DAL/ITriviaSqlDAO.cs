using SideProjectTheOfficeQuiz.Models;
using System.Collections.Generic;

namespace SideProjectTheOfficeQuiz.DAL
{
    public interface ITriviaSqlDAO
    {
        IList<string> GetAllTriviaTypes();

        Trivia GetTrivia(string name);
    }
}