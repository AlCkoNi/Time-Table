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
    }
}
