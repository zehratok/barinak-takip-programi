using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarinakTakip.Models
{
    class Barinak
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }

        public int Kapasite { get; set; }


    }
}
