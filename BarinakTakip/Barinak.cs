using System;
using System.ComponentModel.DataAnnotations;
namespace BarinakTakip.Models
{
    public class Barinak
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
    }
}