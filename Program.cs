namespace Time_Table
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StartPage());
        }
        /*static void Main(string[] args)
        {
            db_finctions db = new db_finctions();
            user_info newUser = new user_info()
            {
                id = 1,
                date_to_visit = "12,12,1002",
                name = "Иван Иванов",
                date_to_born = "12,12,12",
                tel = 1212,
                doxtr = 1,
                tashxis = "Примерный диагноз",
                skidka = 10,
                keldi = "a",
                obshynarh = "a"
            };
            Task task = db.add_user_to_db(newUser);
        }*/
    }
}