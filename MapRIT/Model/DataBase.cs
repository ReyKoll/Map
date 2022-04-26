using System.Data.SqlClient;

namespace MapRIT.Model
{
    public class DataBase
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-1A77ELJ\SQLEXPRESS;Initial Catalog=vehicles;Integrated Security=true");

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public void InitConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}