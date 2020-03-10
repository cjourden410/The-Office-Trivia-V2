using System;
using System.Collections.Generic;
using System.Text;
using SideProjectTheOfficeQuiz.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SideProjectTheOfficeQuiz.DAL
{
    public class TriviaSqlDAO : ITriviaSqlDAO
    {
        private string connectionString;

        public TriviaSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<string> GetAllTriviaTypes()
        {
            List<string> list = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
@"SELECT name from trivia";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        list.Add(Convert.ToString(rdr[0]));
                    }
                }

                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Trivia GetTrivia(string name)
        {
            Trivia trivia = new Trivia();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
@"select q.question_id, q.text, a.choice, a.is_correct 
from question q
join Trivia_Question tq on q.question_id = tq.question_id
join trivia t on tq.trivia_id = t.trivia_id
join MCAnswer a on q.question_id = a.question_id
where t.name = @name
order by q.question_id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    
                    trivia.Name = name;
                    trivia.Questions = new List<QuestionMaster>();
                    int lastQuestionID = 0;
                    int responseOption = 0;
                    Question question = null;
                    while (rdr.Read())
                    {
                        int questionID = Convert.ToInt32(rdr["question_id"]);
                        if (questionID != lastQuestionID)
                        {
                            question = new Question();
                            question.QuestionId = questionID;
                            question.QuestionText = Convert.ToString(rdr["text"]);
                            trivia.Questions.Add(question);
                            responseOption = 0;
                            lastQuestionID = questionID;
                        }
                        string responseLetter = ((char)('A' + responseOption)).ToString();
                        responseOption += 1;
                        string choice = Convert.ToString(rdr["choice"]);
                        bool isCorrect = Convert.ToBoolean(rdr["is_correct"]);
                        question.PossibleResponses.Add(responseLetter, choice);
                        if(isCorrect)
                        {
                            question.CorrectResponse = responseLetter;
                        }
                        //new Question("What color t-shirt did the Scranton branch wear at the company picnic?", "D",
                        //new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                        //    {"A", "Green" },
                        //    {"B", "Orange" },
                        //    {"C", "Dark Blue" },
                        //    {"D", "Red" },
                        //    {"E", "Dark Purple" },
                        //}),
                        
                        //list.Add(RowToObject(rdr));
                    }
                }

                return trivia;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private Trivia RowToObject(SqlDataReader rdr)
        {
            return new Trivia()
            {
                TriviaId = Convert.ToInt32(rdr["trivia_id"]),
                Name = Convert.ToString(rdr["name"]),
            };
        }
    }
}
