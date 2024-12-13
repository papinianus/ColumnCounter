namespace ColumnCounter
{
    internal interface IDataStore
    {
        IEnumerable<string> LoadHeaders();
        int CountColumn(string columnName);
        IReadOnlyDictionary<string, int> CountColumns(IEnumerable<string> columnNames);
    }
}
