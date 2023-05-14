using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class Alan
    {
        [Key]
        public int  id                      {  get; set; }
        public int alan_sahibi_id           { get; set;  }
    }
}
