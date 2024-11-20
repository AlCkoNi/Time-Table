using System.Data.SqlClient;
namespace Time_Table.db
{
    internal class db_finctions : queries_functions
    {
        private readonly string db_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AlCkoNi\Source\Repos\Time-Table\db\dbs\db.mdf;Integrated Security=True";
        public class user_info
        {
            public required string date_to_visit { get; set; }
            public required string name { get; set; }
            public required string date_to_born { get; set; }
            public int tel { get; set; }
            public byte doxtr{ get; set; }//primary key
            public required string tashxis { get; set; }
            public byte skidka { get; set; }
            public required string keldi { get; set; }
            public required string obshynarh { get; set; }
        }
        public class doctor_info
        {
            public required string name { get; set;}
            public required string info { get; set;}
        }
        public List<user_info> users = new();
        public async Task AddUserAsync(user_info user)//добавляет нового пользователя в таблицу Users.
        {
            using (SqlConnection connection = new SqlConnection(db_connect))
            {
                using (SqlCommand command = new SqlCommand(search_queries("adduser"), connection))
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
        }
        public async Task<List<user_info>> GetUsersAsync()//получает список всех пользователей из таблицы Users.
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
                            users.Add(new user_info
                            {
                                date_to_visit = reader.GetString(0),
                                name = reader.GetString(1),
                                date_to_born = reader.GetString(2),
                                tel = reader.GetInt32(3),
                                doxtr = (byte)reader.GetByte(4),
                                tashxis = reader.GetString(5),
                                skidka = (byte)reader.GetByte(6),
                                keldi = reader.GetString(7),
                                obshynarh = reader.GetString(8),
                            });
                        }
                    }
                }
            }

            return users;
        }

        public async Task UpdateUserAsync(user_info user)//UpdateUserAsync – обновляет данные пользователя.
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
        }

        public async Task DeleteUserAsync(byte doxtr)//DeleteUserAsync – удаляет пользователя по его doxtr.
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
        }

        public async Task AddDoctorAsync(doctor_info doctor)//AddDoctorAsync – добавляет нового врача в таблицу Doctors.
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
        }

        public async Task<List<doctor_info>> GetDoctorsAsync()//GetDoctorsAsync – возвращает список врачей.
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
        }
        public void fhkjsa()
        {
            //shdgkajh
        }
    }
}
