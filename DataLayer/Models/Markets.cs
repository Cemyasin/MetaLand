using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.DataLayer.Models
{
    internal class Markets
    {
        [Key]
        public int      isletme_id              { get; set; }
        public int      yiycecek_ucreti         { get; set; }
    }
}
