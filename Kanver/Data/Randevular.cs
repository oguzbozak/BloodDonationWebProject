using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kanver.Data
{
    public class Randevular
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public int Telefon { get; set; }
        public string Konum { get; set; }
        public DateTime Tarih { get; set; }
    }
}
