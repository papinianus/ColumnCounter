namespace ColumnCounter
{
    internal interface IDataStore
    {
        IEnumerable<string> GetTables();
        IEnumerable<string> LoadHeaders(string tableName);
        int CountColumn(string tableName, string columnName);
        IReadOnlyDictionary<string, int> CountColumns(string tableName, IEnumerable<string> columnNames);
    }
}
