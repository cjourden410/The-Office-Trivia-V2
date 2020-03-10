using SideProjectTheOfficeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SideProjectTheOfficeQuiz.DAL
{
    public class MCAnswerSqlDAO : IMCAnswerSqlDAO
    {
        private string connectionString;

        public MCAnswerSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Get the list of possible answers for a specific question
        public IList<MCAnswer> MCAnswerOptions(int questionId)
        {
            List<MCAnswer> list = new List<MCAnswer>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql =
@"select q.question_id, q.text, a.choice, a.is_correct 
from question q
join MCAnswer a on q.question_id = a.question_id
where q.question_id = @questionId";
                    //                    string sql =
                    //@"select q.question_id, a.choice 
                    //from question q
                    //join MCAnswer a on q.question_id = a.question_id
                    //where q.question_id = = @questionId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@questionId", questionId);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    
                    //Question q = new Question(); // From convo with Craig
                    while (rdr.Read())
                    {
                        //list.Add(RowSetToObject(rdr, q); // From convo with Craig
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

        // Get the answer for a specific question
        public IList<MCAnswer> GetAnswerById(int questionId)
        {
            List<MCAnswer> list = new List<MCAnswer>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
@"select q.question_id, a.choice 
from question q
join MCAnswer a on q.question_id = a.question_id
where q.question_id = @questionId and a.is_correct = 1";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@questionId", questionId);
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

        //private Question RowSetToObject(SqlDataReader rdr) // From convo with Craig
        //{
        //    Question question = new Question();
        //    List<string> answers = new List<string>();
        //    while (rdr.Read())
        //    {
        //        if (question.Text == null)
        //        {
        //            question.Text = Convert.ToString("text");
        //        }
        //        answers.Add(Convert.ToString("choice"));
        //    }
        //    // question.Answer = answers; ADD ANSWER TO QUESTION CLASS
        //    return question;
        //}
        private MCAnswer RowToObject(SqlDataReader rdr)
        {
            return new MCAnswer()
            {
                AnswerId = Convert.ToInt32(rdr["answer_id"]),
                Choice = Convert.ToString(rdr["choice"]),
                QuestionId = Convert.ToInt32(rdr["question_id"]),
                IsCorrect = Convert.ToBoolean(rdr["is_corrrect"])
            };
        }
    }
}
