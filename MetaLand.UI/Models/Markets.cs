using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class Markets
    {
        [Key]
        public int      isletme_id              { get; set; }
        public int      yiyecek_ucreti         { get; set; }
    }
}
