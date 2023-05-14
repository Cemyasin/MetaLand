using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class IsIlani
    {
        [Key]
        public int      id                  { get; set; }
        public int      isletme_id          { get; set; }
        public int      isveren_id          { get;set; }
        public int      maas                { get; set; }
        public byte     vardiya             { get;set; }
    }
}
