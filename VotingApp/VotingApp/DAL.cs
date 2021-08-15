using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    public class DAL
    {
        SQLiteConnection _connection = new SQLiteConnection("Data Source=database.db;");

        public SQLiteCommand Command(string query)
        {
            if (_connection.State == ConnectionState.Closed) _connection.Open();
            return new SQLiteCommand(query, _connection);
        }

        public DataTable Table(SQLiteCommand command)
        {
            if (_connection.State == ConnectionState.Closed) _connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public bool IsReadRow(SQLiteCommand command)
        {
            if (_connection.State == ConnectionState.Closed) _connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                reader.Close();
                _connection.Close();
                return true;
            }
            reader.Close();
            _connection.Close();
            return false;
        }

        public bool ExecNQ(SQLiteCommand command)
        {
            if (_connection.State == ConnectionState.Closed) _connection.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                _connection.Close();
                return true;
            }
            else
            {
                _connection.Close();
                return false;
            }


        }

    }
}
