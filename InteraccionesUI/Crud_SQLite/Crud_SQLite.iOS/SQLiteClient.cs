using Crud_SQLite.Data;
using Crud_SQLite.iOS;
using Foundation;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

// Esamblaje
[assembly: Dependency(typeof(SQLiteClient))]

namespace Crud_SQLite.iOS
{
    public class SQLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}