using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CRMStom;
using Microsoft.VisualBasic.Logging;

namespace Time_Table
{
    internal class db_finctions
    {
        private readonly string db_connect = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\AlCkoNi\\source\\repos\\Time-Table\\db.mdf;Integrated Security=True";

       /* public void chekemploy(string login, string paswd)//Loginchek
        {
            string sql = "";
            using (SqlConnection connection = new SqlConnection(db_connect))
            {
                connection.Open();
                using (SqlCommand getMaxIdCommand = new SqlCommand("", connection))
                {
                    object result = getMaxIdCommand.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@passwd", paswd);
                }
            }
        }
        public void add_to_bd_users(string name, string date_of_birth, int tel_number, string tashxis, decimal discount, string info, string total_amount)
        {

        }
   */ }
    /*
    ExecuteScalar: возвращает один результат (например, MAX(ID)).
    ExecuteNonQuery: используется для вставки, обновления или удаления данных и возвращает количество затронутых строк.
    ExecuteReader: используется для выборки данных и возвращает список строк, где каждая строка представлена словарем с ключами-именами полей и значениями данных.
    */
    /*public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    return command.ExecuteScalar();
                }
            }
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public List<Dictionary<string, object>> ExecuteReader(string query, Dictionary<string, object> parameters = null)
        {
            var results = new List<Dictionary<string, object>>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            results.Add(row);
                        }
                    }
                }
            }
            return results;
        }

        private void AddParameters(SqlCommand command, Dictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }
        }
    }
    //Вставка данных:
    var dbHelper = new DatabaseHelper(connectionString);
    string insertQuery = "INSERT INTO Users (login, passwd) VALUES (@login, @passwd)";
    var parameters = new Dictionary<string, object> { { "@login", login }, { "@passwd", passwd } };
    dbHelper.ExecuteNonQuery(insertQuery, parameters);
    //Обновление данных: 
    string updateQuery = "UPDATE Users SET passwd = @newPasswd WHERE login = @login";
    var updateParams = new Dictionary<string, object> { { "@newPasswd", newPasswd }, { "@login", login } };
    dbHelper.ExecuteNonQuery(updateQuery, updateParams);
    //Удаление данных:
    string deleteQuery = "DELETE FROM Users WHERE login = @login";
    var deleteParams = new Dictionary<string, object> { { "@login", login } };
    dbHelper.ExecuteNonQuery(deleteQuery, deleteParams);
    //Получение данных:
    string selectQuery = "SELECT * FROM Users WHERE login = @login";
    var selectParams = new Dictionary<string, object> { { "@login", login } };
    var users = dbHelper.ExecuteReader(selectQuery, selectParams);
    foreach (var user in users)
    {
        Console.WriteLine($"Login: {user["login"]}, Password: {user["passwd"]}");
    }
*/

}
