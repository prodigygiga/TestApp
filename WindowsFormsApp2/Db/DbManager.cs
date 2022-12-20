using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Db
{
    public class DbManager
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString;
        public DbManager() { }

        //ado.net
        public List<Person> GetAllPersons()
        {
            List<Person> list = new List<Person>();
            SqlCommand cmd = new SqlCommand("select * from People");
            cmd.CommandType = System.Data.CommandType.Text;

            SqlConnection conn = new SqlConnection(connStr);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Person p = new Person();

                p.FirstName = reader["FirstName"].ToString();
                p.LastName = reader["LastName"].ToString();
                p.BirthDate = reader["BirthDate"] != System.DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : new DateTime();
                p.IsMarried = Convert.ToBoolean(reader["IsMarried"]);

                list.Add(p);
            }
            reader.Close();
            conn.Close();


            return list;
        }

        public void AddPerson(Person p)
        {
            SqlCommand cmd = new SqlCommand("insert into People (FirstName,LastName,IsMarried)\r\nvalues (@FirstName,@LastName,@IsMarried)");
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
            cmd.Parameters.AddWithValue("@LastName",p.LastName);
            cmd.Parameters.AddWithValue("@IsMarried", p.IsMarried);

            SqlConnection conn = new SqlConnection(connStr);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
