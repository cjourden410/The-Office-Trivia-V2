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
@"select q.question_id, a.choice 
from question q
join MCAnswer a on q.question_id = a.question_id
where q.question_id = = @questionId";
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
