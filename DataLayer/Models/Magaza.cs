using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.DataLayer.Models
{
    internal class Magaza
    {
        [Key]
        public int      isletme_id          { get; set; }
        public int      esya_ucreti         { get; set; }
    }
}
