using System;
using System.ComponentModel.DataAnnotations;
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
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        public string Login { get; set; }
    }
}
