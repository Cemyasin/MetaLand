using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.DataLayer.Models
{
    internal class Emlak
    {
        [Key]
        public int      id                          { get; set; }
        public int      isletme_id                  { get; set; } 
        public double   emlak_komisyon_orani        { get; set; }
    }
}
