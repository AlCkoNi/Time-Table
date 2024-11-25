using Time_Table.db;
using static Time_Table.db.db_finctions;

namespace Time_Table
{
    internal class Debug_test
    {
        public class Run_test_class
        {
            db_finctions dbf = new db_finctions();
            public async Task add()
            {
                user_info newUser = new user_info
                {
                    id = 1,
                    date_to_visit = "2024-12-01",
                    name = "KALIVAN",
                    date_to_born = "2000-01-01",
                    tel = 123456789,
                    doxtr = 1,
                    tashxis = "Примерный диагноз",
                    skidka = 10,
                    keldi = "Да",
                    obshynarh = "Общая информация"
                };
                await dbf.add_user_to_db(newUser);
                await dbf.update_user_data(newUser);
                doctor_info newdoc = new doctor_info
                {
                    id = 3,
                    name = "BOBUR1",
                    info = "Farosh",
                };
                await dbf.add_doxtr_to_db(newdoc);
                await dbf.update_doxrt_data(newdoc);
            }
            public async Task run_func()
            {
                await add();
                await dbf.delate_doxtr(2);
                var allUsers = await dbf.doxtr_wive();
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
}
