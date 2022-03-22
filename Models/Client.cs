using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyClient.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Birthdate { get; set; }

        [Column(TypeName = "varchar(9)")]
        public string Gender { get; set; }
    }
}