namespace Time_Table.db
{
    internal class queries_functions
    {
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>()//queries
        {
            { "adduser", "INSERT INTO Table_users (Id, date_of_visit, name, year_of_birth, tel_number, employes, tashxis, discount, info, total_amount) VALUES (@id, @date_to_visit, @name, @date_to_born, @tel, @doxtr, @tashxis, @skidka, @keldi, @obshynarh)"},
            { "checkuser", "SELECT * FROM Table_users" },
            { "DeleteVisitById", "DELETE FROM YourTableName WHERE id = @id" },
            { "UpdateVisitDate", "UPDATE YourTableName SET date_of_visit = @dateOfVisit WHERE id = @id" }
        };
        public string search_queries(string zapros)
        {
            return queries.ContainsKey(zapros) ? queries[zapros] : @"¯\_(ツ)_/¯";
        }
    }
}
