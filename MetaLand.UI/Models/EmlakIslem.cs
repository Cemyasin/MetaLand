using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class EmlakIslem
    {
        [Key]
        public int          id                              { get; set; }
        public int          isletme_id                      { get; set; }
        public int          alan_id                         { get; set; }        
        public int          isletme_fiyati                  { get; set;}
        public int          kiralik_isletme_fiyati          { get; set; }
        public int          islemin_yapildigi_emlak_id      { get; set; }
        public int          isletme_sabit_gelir_orani       { get; set; }
        public int          isletme_sabit_gelir_miktari     { get; set; }
        public int          kira_suresi                     { get; set; }
        public string       emlak_islemi                    { get; set; }      //tintint
        public byte         ilanda_mi                       { get; set; }
        public DateTime     satis_tarihi                    { get; set; }
        public DateTime     kiralama_tarihi                 { get; set; }
        public DateTime     kira_bitis_tarihi               { get;set; }
    }
}
