using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud_SQLite.Models
{
    [Table("Dogs")]
    public class Race
    {
        [PrimaryKey]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
