using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MojaApka.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surrname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Login { get; set; }
    }
}
