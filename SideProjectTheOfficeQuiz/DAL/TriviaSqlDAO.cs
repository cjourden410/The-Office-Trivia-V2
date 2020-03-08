using System;
using System.Collections.Generic;
using System.Text;
using SideProjectTheOfficeQuiz.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SideProjectTheOfficeTrivia.DAL
{
    public class TriviaSqlDAO : ITriviaSqlDAO
    {
        private string connectionString;

        public TriviaSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Trivia> GetAllTriviaTypes()
        {
            List<Trivia> list = new List<Trivia>();
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
