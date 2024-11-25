using Microsoft.Data.SqlClient;
using static System.Console;
namespace Time_Table.db
{
    internal class db_finctions : queries_functions
    {
        private readonly string db_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\AlCkoNi\Documents\Work\Visual Studio Prajact-C#\Time-Table\Tolibjon_db\dbs\db.mdf"";Integrated Security=True;MultipleActiveResultSets=True";
        public class user_info//переменые user
        {
            public required int id { get; set; }
            public required string date_to_visit { get; set; }
            public required string name { get; set; }
            public required string date_to_born { get; set; }
            public int tel { get; set; }
            public byte doxtr { get; set; } // primary key
            public required string tashxis { get; set; }
            public byte skidka { get; set; }
            public required string keldi { get; set; }
            public required string obshynarh { get; set; }
        }
        public class doctor_info//переменые рабочих
        {
            public required int id { get; set; }
            public required string name { get; set; }
            public required string info { get; set; }
        }
        public async Task add_user_to_db(user_info user)//добавляет нового пользователя в таблицу Users.
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("adduser"), connection))
                    {
                        command.Parameters.AddWithValue("@id", user.id);
                        command.Parameters.AddWithValue("@date_to_visit", user.date_to_visit);
                        command.Parameters.AddWithValue("@name", user.name);
                        command.Parameters.AddWithValue("@date_to_born", user.date_to_born);
                        command.Parameters.AddWithValue("@tel", user.tel);
                        command.Parameters.AddWithValue("@doxtr", user.doxtr);
                        command.Parameters.AddWithValue("@tashxis", user.tashxis);
                        command.Parameters.AddWithValue("@skidka", user.skidka);
                        command.Parameters.AddWithValue("@keldi", user.keldi);
                        command.Parameters.AddWithValue("@obshynarh", user.obshynarh);
                        WriteLine("Opening connection...");
                        await connection.OpenAsync();
                        WriteLine("Connection opened.");
                        WriteLine("Executing query...");
                        await command.ExecuteNonQueryAsync();
                        WriteLine("Query executed successfully.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
        }
        public async Task<List<Dictionary<string, object>>> SelectAllUsersAsync()//вывод данных из базы данных
        {
            var result = new List<Dictionary<string, object>>();
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("checkuser"), connection))
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var row = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                                }
                                result.Add(row);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
            return result;
        }
        public async Task update_user_data(user_info user)//обновляет данные пользователя.
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("updateuser"), connection))
                    {
                        command.Parameters.AddWithValue("@id", user.id);
                        command.Parameters.AddWithValue("@date_to_visit", user.date_to_visit);
                        command.Parameters.AddWithValue("@name", user.name);
                        command.Parameters.AddWithValue("@date_to_born", user.date_to_born);
                        command.Parameters.AddWithValue("@tel", user.tel);
                        command.Parameters.AddWithValue("@doxtr", user.doxtr);
                        command.Parameters.AddWithValue("@tashxis", user.tashxis);
                        command.Parameters.AddWithValue("@skidka", user.skidka);
                        command.Parameters.AddWithValue("@keldi", user.keldi);
                        command.Parameters.AddWithValue("@obshynarh", user.obshynarh);
                        WriteLine("Opening connection...");
                        await connection.OpenAsync();
                        WriteLine("Connection opened...");
                        WriteLine("Updating date...");
                        await command.ExecuteNonQueryAsync();
                        WriteLine("Updating data successfully!");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
        }
        public async Task delate_users(int id)//удаляет пользователя по его id.
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("delateuser"), connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        WriteLine("Opening connection...");
                        await connection.OpenAsync();
                        WriteLine("Connection opened...");
                        WriteLine("Delating date...");
                        await command.ExecuteNonQueryAsync();
                        WriteLine("Deleating data successfully!");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
        }
        public async Task add_doxtr_to_db(doctor_info doxtr)//добавляет нового пользователя в таблицу Employ.
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("adddoxtr"), connection))
                    {
                        command.Parameters.AddWithValue("@id", doxtr.id);
                        command.Parameters.AddWithValue("@name", doxtr.name);
                        command.Parameters.AddWithValue("@info", doxtr.info);
                        WriteLine("Opening connection...");
                        await connection.OpenAsync();
                        WriteLine("Connection opened.");
                        WriteLine("Executing query...");
                        await command.ExecuteNonQueryAsync();
                        WriteLine("Query executed successfully.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
        }
        public async Task<List<Dictionary<string, object>>> doxtr_wive()//вывод данных из базы данных
        {
            var result = new List<Dictionary<string, object>>();
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("checkdoxtr"), connection))
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var row = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                                }
                                result.Add(row);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
            return result;
        }
        public async Task update_doxrt_data(doctor_info doxtr)//обновляет данные пользователя.
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("updatedoxtir"), connection))
                    {
                        command.Parameters.AddWithValue("@id", doxtr.id);
                        command.Parameters.AddWithValue("@name", doxtr.name);
                        command.Parameters.AddWithValue("@info", doxtr.info);
                        WriteLine("Opening connection...");
                        await connection.OpenAsync();
                        WriteLine("Connection opened...");
                        WriteLine("Updating date...");
                        await command.ExecuteNonQueryAsync();
                        WriteLine("Updating data successfully!");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
        }
        public async Task delate_doxtr(int id)//удаляет пользователя по его id.
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db_connect))
                {
                    using (SqlCommand command = new SqlCommand(search_queries("delatedoxtr"), connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        WriteLine("Opening connection...");
                        await connection.OpenAsync();
                        WriteLine("Connection opened...");
                        WriteLine("Delating date...");
                        await command.ExecuteNonQueryAsync();
                        WriteLine("Deleating data successfully!");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                WriteLine(ex.Message); throw;
            }
        }
    }
}
