using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class IsletmeTuru
    {
        [Key]
        public byte         id                  { get; set; }
        public string       isletme_adi         { get; set; }
    }
}
