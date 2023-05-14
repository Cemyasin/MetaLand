using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.DataLayer.Models
{
    internal class Users
    {
        [Key]
        public int            id                { get; set; }
        public string         İsim              { get; set; }
        public string         Kullanici_adi     { get; set; }
        public string         Soyisim           { get; set; }
        public string         Sifre             { get; set; }
        public int            Yemek             { get; set; }
        public int            Esya              { get; set; }
        public int            Para              { get; set; }
        public DateTime       Kayit_tarihi      { get; set; }

    }
}
