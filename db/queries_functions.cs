namespace Time_Table.db
{
    internal class queries_functions
    {
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>()//queries
        {
            { "adduser", "INSERT INTO Users (date_to_visit, name, date_to_born, tel, doxtr, tashxis, skidka, keldi, obshynarh) VALUES (@date_to_visit, @name, @date_to_born, @tel, @doxtr, @tashxis, @skidka, @keldi, @obshynarh)" },
            { "checkuser", "SELECT date_to_visit, name, date_to_born, tel, doxtr, tashxis, skidka, keldi, obshynarh FROM Users" },
            { "DeleteVisitById", "DELETE FROM YourTableName WHERE id = @id" },
            { "UpdateVisitDate", "UPDATE YourTableName SET date_of_visit = @dateOfVisit WHERE id = @id" }
        };
        public string search_queries(string zapros)
        {
            return queries.ContainsKey(zapros) ? queries[zapros] : @"¯\_(ツ)_/¯";
        }
    }
}
