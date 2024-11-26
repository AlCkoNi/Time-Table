using Time_Table.db;
using static Time_Table.db.db_finctions;

namespace Time_Table
{
    internal class Debug_test
    {
        public class Run_test_class
        {
            db_finctions dbf = new db_finctions();
            public async Task run_func()
            {
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
