using System.Runtime.InteropServices;
using Time_Table.db;
using static Time_Table.db.db_finctions;
namespace Time_Table
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        static async Task Main(string[] args)
		{
            AllocConsole();
            Run_test_class run = new Run_test_class();
            await run.run_func();
		}
    }
    public class Run_test_class
    {
        db_finctions dbf = new db_finctions();
        public async Task add()
        {
            user_info newUser = new user_info
            {
                id = 6,
                date_to_visit = "2024-12-01",
                name = "Иван Иванов",
                date_to_born = "2000-01-01",
                tel = 123456789,
                doxtr = 1,
                tashxis = "Примерный диагноз",
                skidka = 10,
                keldi = "Да",
                obshynarh = "Общая информация"
            };
            await dbf.add_user_to_db(newUser);
        }
        public async Task run_func()
        {
            await add();
            var allUsers = await dbf.SelectAllUsersAsync();

            foreach (var user in allUsers)
            {
                foreach (var column in user)
                {
                    Console.Write($" {column.Key}: " + "{" + $"{column.Value}" + "}");
                }
                Console.WriteLine("\n---------------");
            }
        }
    }
}
