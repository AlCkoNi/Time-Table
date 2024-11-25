namespace Time_Table.db
{
    internal class queries_functions
    {
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>()//queries
        {
            { "adduser", @"INSERT INTO Table_users (Id, date_of_visit, name, year_of_birth, tel_number, employes, tashxis, discount, info, total_amount) VALUES (@id, @date_to_visit, @name, @date_to_born, @tel, @doxtr, @tashxis, @skidka, @keldi, @obshynarh)"},
            { "checkuser", @"SELECT * FROM Table_users" },
            { "updateuser", @"UPDATE Table_users SET date_of_visit = @date_to_visit, name = @name, year_of_birth = @date_to_born, tel_number = @tel, employes = @doxtr, tashxis = @tashxis, discount = @skidka, info = @keldi, total_amount = @obshynarh WHERE Id = @id"},
            { "delateuser", @"DELETE FROM Table_users WHERE id = @Id"},
            { "adddoxtr", @"INSERT INTO Table_employes (Id, name, status) VALUES (@id, @name, @info)"},
            { "checkdoxtr", @"SELECT * FROM Table_employes" },
            { "updatedoxtir", @"UPDATE Table_employes SET name = @name, status = @info WHERE Id = @id"},
            { "delatedoxtr", @"DELETE FROM Table_employes WHERE id = @id"},
        };
        public string search_queries(string zapros)
        {
            return queries.ContainsKey(zapros) ? queries[zapros] : @"¯\_(ツ)_/¯";
        }
    }
}
