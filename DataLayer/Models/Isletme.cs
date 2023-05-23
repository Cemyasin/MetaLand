using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.DataLayer.Models
{
    internal class Isletme
    {
        [Key]
        public int          id                                  { get; set; }
        public int          alan_id                             { get; set; }
        public int          isletme_sahibi_id                    { get; set; }         
        public byte         isletme_turu                        { get; set; }               //tinyint 
        public int          kullanici_isletme_ucreti            { get; set; }
        public int          yonetici_isletme_ucreti             { get; set; }
        public byte         isletme_seviyesi                    { get; set; }               //tinyint
        public int          isletme_kapasitesi                  { get; set; }
        public int          isletme_calisan_sayisi              { get; set; }
        public DateTime     seviye_baslangic_tarihi             { get; set; }

    }
}
