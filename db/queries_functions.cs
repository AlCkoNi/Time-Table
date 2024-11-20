namespace Time_Table.db
{
    internal class queries_functions
    {
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>()//queries
        {
            { "InsertVisitDate", "INSERT INTO YourTableName (date_of_visit) VALUES (@dateOfVisit)" },
            { "GetAllVisits", "SELECT * FROM YourTableName" },
            { "DeleteVisitById", "DELETE FROM YourTableName WHERE id = @id" },
            { "UpdateVisitDate", "UPDATE YourTableName SET date_of_visit = @dateOfVisit WHERE id = @id" }
        };
        public string search_queries(string zapros)
        {
            return queries.ContainsKey(zapros) ? queries[zapros] : @"¯\_(ツ)_/¯";
        }
    }
}
