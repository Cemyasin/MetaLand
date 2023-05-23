using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.UI
{
    internal class AreaButton : Button
    {
        public int          SahipId                 { get; set; }
        public string       AlanAdi                 { get; set; }
      //public Size         buttonSize              { get;} = new Size(75, 75);
        public Color        Back_color              { get; set; }
        public string       IsletmeSahibi           { get; set; }
        public DateTime     SeviyeBaslangic         { get; set; }
        public int          Calisan                 { get; set; }   
        public int          Kapasite                { get; set; }
        public int          MalzemeParasi           { get; set; }
        public int          IsletmeId               { get; set; }  

    }

}
