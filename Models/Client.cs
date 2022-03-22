using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClient.Models
{
    public class Client 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
    }
}