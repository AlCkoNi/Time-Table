using Microsoft.Data.SqlClient;
using System.Diagnostics;
namespace Time_Table.db
{
    internal class db_finctions : queries_functions
    {
        private readonly string db_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AlCkoNi\source\repos\Time-Table\Tolibjon_db\dbs\db.mdf;Integrated Security=True;MultipleActiveResultSets=True";
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
                        Console.WriteLine("Opening connection...");
                        await connection.OpenAsync();
                        Console.WriteLine("Connection opened.");
                        Console.WriteLine("Executing query...");
                        await command.ExecuteNonQueryAsync();
                        Console.WriteLine("Query executed successfully.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                foreach (SqlError error in sqlEx.Errors)
                {
                    Console.WriteLine($"Error {error.Number}: {error.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                Debug.WriteLine(ex.Message); throw;
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
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении данных: {ex.Message}");
            }

            return result;
        }
        /*public async Task UpdateUserAsync(user_info user)//UpdateUserAsync – обновляет данные пользователя.
        {
            string query = "UPDATE Users SET date_to_visit = @date_to_visit, name = @name, date_to_born = @date_to_born, " +
                           "tel = @tel, tashxis = @tashxis, skidka = @skidka, keldi = @keldi, obshynarh = @obshynarh " +
                           "WHERE doxtr = @doxtr";

            using (SqlConnection connection = new SqlConnection(db_connect))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date_to_visit", user.date_to_visit);
                    command.Parameters.AddWithValue("@name", user.name);
                    command.Parameters.AddWithValue("@date_to_born", user.date_to_born);
                    command.Parameters.AddWithValue("@tel", user.tel);
                    command.Parameters.AddWithValue("@doxtr", user.doxtr);
                    command.Parameters.AddWithValue("@tashxis", user.tashxis);
                    command.Parameters.AddWithValue("@skidka", user.skidka);
                    command.Parameters.AddWithValue("@keldi", user.keldi);
                    command.Parameters.AddWithValue("@obshynarh", user.obshynarh);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }*/
        /*public async Task DeleteUserAsync(byte doxtr)//DeleteUserAsync – удаляет пользователя по его doxtr.
        {
            string query = "DELETE FROM Users WHERE doxtr = @doxtr";

            using (SqlConnection connection = new SqlConnection(db_connect))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@doxtr", doxtr);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }*/
        /*public async Task AddDoctorAsync(doctor_info doctor)//AddDoctorAsync – добавляет нового врача в таблицу Doctors.
        {
            string query = "INSERT INTO Doctors (name, info) VALUES (@name, @info)";

            using (SqlConnection connection = new SqlConnection(db_connect))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", doctor.name);
                    command.Parameters.AddWithValue("@info", doctor.info);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }*/
        /* public async Task<List<doctor_info>> GetDoctorsAsync()//GetDoctorsAsync – возвращает список врачей.
         {
             string query = "SELECT name, info FROM Doctors";
             List<doctor_info> doctors = new();

             using (SqlConnection connection = new SqlConnection(db_connect))
             {
                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     await connection.OpenAsync();
                     using (SqlDataReader reader = await command.ExecuteReaderAsync())
                     {
                         while (await reader.ReadAsync())
                         {
                             doctors.Add(new doctor_info
                             {
                                 name = reader.GetString(0),
                                 info = reader.GetString(1),
                             });
                         }
                     }
                 }
             }

             return doctors;
         }*/
    }

}
