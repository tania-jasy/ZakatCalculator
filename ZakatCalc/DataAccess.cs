using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormStart
{
    internal class DataAccess
    {
        //declaring some fields
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter sda;
        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }
        public SqlConnection Connection
        {
            set { this.connection = value; }
            get { return this.connection; }
        }

        public SqlCommand Command
        {
            get { return this.command; }
            set { this.command = value; }
        }

        public DataAccess()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;");
            connection.Open();
        }
        public string LoginOnUserRole(string username, string password)
        {
            string sql = "SELECT password, role FROM USERS where username = @Username;";
            SqlDataReader reader = null;

            try
            {
                
                Command = new SqlCommand(sql, connection);
                Command.Parameters.AddWithValue("@Username", username);
                reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    string dbPassword = reader["password"].ToString();
                    if (dbPassword == password)
                    {
                        return reader["role"].ToString();
                    }
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured: " + ex.Message);
                return null;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            Command = new SqlCommand(sql, connection);
            Sda = new SqlDataAdapter(Command);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds.Tables[0];
        }

        public DataSet ExecuteQuery(string sql, string tableName)
        {
            Command = new SqlCommand(sql, connection);
            this.Sda = new SqlDataAdapter(Command);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds, tableName);
            return Ds;
        }

        public int ExecuteQuery(string sql)
        {
            Command = new SqlCommand(sql, connection);
            int rowsAffected = Command.ExecuteNonQuery();
            return rowsAffected;
        }

        public Tuple<string, string> GetUserDetails(string username)
        {
            string sql = "SELECT FullName, ID FROM UserInfo WHERE Username = @Username";
            SqlDataReader reader = null;

            try
            {
                Command = new SqlCommand(sql, connection);
                Command.Parameters.AddWithValue("@Username", username);
                reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    string fullName = reader["FullName"].ToString();
                    string displayId = reader["ID"].ToString();

                    return Tuple.Create(fullName, displayId);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching user details: " + ex.Message);
                return null;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }
    }
}
