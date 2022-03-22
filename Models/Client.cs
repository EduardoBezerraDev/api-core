using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyClient.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }


        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime Birthdate { get; set; }


        [Required]
        [Column(TypeName = "varchar(9)")]
        public string Gender { get; set; }
    }
}