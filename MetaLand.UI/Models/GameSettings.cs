using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI.Models
{
    internal class GameSettings
    {
        [Key]
        public int      id                          { get; set; }
        public int      Oyun_Alan_Boyutu            { get; set; }
        public int      Gunluk_Yiyecek_Gideri       { get; set; }
        public int      Gunluk_Esya_Gideri          { get;set; }
        public int      Gunluk_Para_Gideri          { get; set; }
        public int      Baslangic_Yemek             { get; set; }
        public int      Baslangic_Esya              { get; set; }
        public int      Baslangic_Para              { get;set; }
        public DateTime Oyun_Tarihi                 { get; set; }
    }
}
