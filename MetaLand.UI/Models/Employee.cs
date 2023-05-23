using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class Employee
    {
        [Key]
        public int          user_id                     { get; set; }
        public int          isletme_id                  { get; set;}
        public int          calisma_gun_sayisi          { get; set; }
        public byte         calisma_saatleri            { get; set; }
        public DateTime     baslangic_tarihi            { get; set; }
        public DateTime     cikis_tarihi                { get;set; }
    }
}
