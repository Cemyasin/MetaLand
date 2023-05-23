using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class EmlakTeklif
    {
            [Key]
        public int      id                  { get; set; }
        public int      teklif_alan_id      { get; set; }
        public int      teklif_veren_id     { get; set; }
        public int      isletme_id          { get; set; }
        public int      teklif              { get; set; }
    }
}
