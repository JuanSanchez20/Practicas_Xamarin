using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlLite.Tables
{
    public class T_Registro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string User { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
    }
}
