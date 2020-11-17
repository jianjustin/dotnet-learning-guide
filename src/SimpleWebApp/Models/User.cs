using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Models
{
    [Table("user")]
    public class User
    {
        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string name { get; set; }

        [Column("password")]
        public string password { get; set; }
    }
}
