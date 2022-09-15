using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pin_p.Models
{
    public class Ispit
    {
        public int Id { get; set; }
        public string predmet { get; set; }

        [DataType(DataType.Date)]
        public DateTime datum{ get; set; }
    }
}

