using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlLite
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
    }
}
