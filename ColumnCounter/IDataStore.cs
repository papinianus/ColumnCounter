using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnCounter
{
    internal interface IDataStore
    {
        IEnumerable<string> LoadHeaders();
        int CountColumn(string columnName);
        IReadOnlyDictionary<string, int> CountColumns(IEnumerable<string> columnNames);
    }
}
