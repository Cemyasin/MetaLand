using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class IsBasvurusu
    {
        [Key]
        public int          id                      { get; set; }
        public int          teklif                  { get; set; }
        public int          ilan_id                 { get; set; }
        public int          basvuran_id             { get; set; }
        public int          isletme_id              { get; set; }
        public int          isletme_sahibi_id       { get; set; }
    }
}
