using System;
using System.Collections.Generic;
using System.Text;

namespace Crud_SQLite.Data
{
    public interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
