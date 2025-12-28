using MySql.Data.MySqlClient;
using System.Data;

namespace P11_714240039.constroller
{
    internal class Koneksi
    {
        string connectionString = "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=;";
        MySqlConnection kon;

        public Koneksi()
        {
            kon = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return kon;
        }

        public void OpenConnection()
        {
            if (kon.State == ConnectionState.Closed)
            {
                kon.Open();
            }
        }

        public void CloseConnection()
        {
            if (kon.State == ConnectionState.Open)
            {
                kon.Close();
            }
        }

        public object ShowData(string query)
        {
            OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CloseConnection();
            return table;
        }

        public void ExecuteQuery(MySqlCommand command)
        {
            command.Connection = kon;
            command.ExecuteNonQuery();
        }

        public object ShowDataParam(string query, params MySqlParameter[] parameters)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, kon);
            cmd.Parameters.AddRange(parameters);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            CloseConnection();
            return table;
        }
        public MySqlDataReader reader(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }


    }
}
