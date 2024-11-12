using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CRMStom;

namespace Time_Table
{
    internal class db_finctions
    {
        private string db_connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\AlCkoNi\\source\\repos\\Time-Table\\db.mdf;Integrated Security=True";

        /*public void chekemploy(string login, string paswd)
        {
            string sql = "INSERT INTO users (user_id, login, passwd, role, sysin) VALUES (@user_id, @login, @passwd, @role, @sysin)";
            using (SqlConnection connection = new SqlConnection(db_connect))
            {
                connection.Open();
                using (SqlCommand getMaxIdCommand = new SqlCommand("SELECT MAX(user_id) FROM users", connection))
                {
                    object result = getMaxIdCommand.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        id = Convert.ToInt32(result) + 1;
                    }
                }
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@user_id", id);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@passwd", passw);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@sysin", b);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void purpose2(string name, string pass)//log-in
        {
            string sqlSelect = @"SELECT role FROM users WHERE login = @login AND passwd = @passwd;";
            using (SqlConnection connection = new SqlConnection(db_connect))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@passwd", passw);
                    string role = (string)(command.ExecuteScalar());
                    choise(role);
                    switch (role)
                    {
                        case "admin": admin_Menu.menu(); break;
                        case "employ": employ_Menu.menu(); break;
                        case "user": user_Menu.menu(); break;
                    }
                }
            }
        }*/
    }
}
