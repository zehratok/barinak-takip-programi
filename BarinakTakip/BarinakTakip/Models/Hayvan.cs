using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarinakTakip.Models
{
    class Hayvan
    {
        [Key]
        public int Id { get; set; }

        public int BarinakId { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public string Yas { get; set; }
        public string Saglik { get; set; }

       

    }
}
