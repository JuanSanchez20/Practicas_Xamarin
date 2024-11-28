using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Crud_SQLite.Data;
using Crud_SQLite.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

// Esamblaje
[assembly: Dependency(typeof(SQLiteClient))]

namespace Crud_SQLite.Droid
{
    public class SQLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}