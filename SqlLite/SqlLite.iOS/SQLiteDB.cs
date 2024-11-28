using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using System.IO;
// Herencias
using SqlLite.iOS;
using Xamarin.Forms;
using SQLite;
[assembly: Dependency(typeof(SQLiteDB))]

namespace SqlLite.iOS
{
    public class SQLiteDB : ISQLite
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            //Se crea la Base de datos
            var path = Path.Combine(documentsPath, "MySQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}