using SideProjectTheOfficeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SideProjectTheOfficeQuiz.DAL
{
    public class QuestionSqlDAO : IQuestionSqlDAO
    {
        private string connectionString;

        public QuestionSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }


        // Get the list of questions based on trivia type the user chooses
        public IList<Question> FindQuestionsByTriviaType(string option)
        {
            List<Question> list = new List<Question>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
@"select q.text 
from question q
join Trivia_Question tq on q.question_id = tq.question_id
join trivia t on tq.trivia_id = t.trivia_id
where t.name = @option";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@option", option);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        list.Add(RowToObject(rdr));
                    }
                }

                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // Get the list of questions based on trivia type the user chooses as well as question choices & answers
        public IList<Question> QuestionChoicesAndAnswers(int questionId, string option)
        {
            List<Question> list = new List<Question>();
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
where q.question_id = @questionId and t.name = @option";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@questionId", questionId);
                    cmd.Parameters.AddWithValue("@option", option);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        list.Add(RowToObject(rdr));
                    }
                }

                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private Question RowToObject(SqlDataReader rdr)
        {
            Question question = new Question();
            question.QuestionId = Convert.ToInt32(rdr["question_id"]);
            List<string> answers = new List<string>();
            while (rdr.Read())
            {
                if (question.QuestionText == null)
                {
                    question.QuestionText = Convert.ToString("text");
                }
                answers.Add(Convert.ToString("choice"));
            }
            //question.Text = Convert.ToString(rdr["text"]);
            return question;
        }
    }
}
