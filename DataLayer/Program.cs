using MetaLand.DataLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace DataLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
           MetaLandContext context = new MetaLandContext();

           List<Users> l= context.Users.ToList();
          //  l[0].Kullanici_adi = "admin";
          //  context.Update(l[0]);
          //  context.SaveChanges();
          //  l[1].Kullanici_adi = "cem20";
          //  context.Update(l[1]);
          //  context.SaveChanges();
          //  l[2].Kullanici_adi = "umut14";
          //  context.Update(l[2]);
          //  context.SaveChanges();
          //  l[3].Kullanici_adi = "player1";
          //  context.Update(l[3]);
          //  context.SaveChanges();
          //  l[4].Kullanici_adi = "player2";
          //  context.Update(l[4]);
          //  context.SaveChanges();
          //  l[5].Kullanici_adi = "player3";
          //  context.Update(l[5]);
          //  context.SaveChanges();

            foreach (Users u in l)
            {
                Console.WriteLine($"{u.Kullanici_adi}-");
            }

          // MetaLand.GUI.Program.Main();
          //  context.Emlak.Add(new Emlak
          //  {
          //      emlak_komisyon_orani=1,
          //      isletme_id=2,
          //  });
          //  context.SaveChanges();

          //   context.Markets.Add(new Markets()
          //   {
          //       isletme_id = 3,
          //       yiycecek_ucreti=50,
          //   }); 
          //   context.SaveChanges();



          // List<Magaza> magazas= context.Magaza.ToList();
          // magazas[0].esya_ucreti = 100;
          // context.Update(magazas[0]);
          // context.SaveChanges();

          // List<Users> users = context.Users.ToList();
          // foreach (var item in users)
          // {
          //     Console.WriteLine($"{item.id} - {item.İsim} - {item.Kayit_tarihi} - {item.Para}");
          // }


          //context.Users.Add(new Users
          //{
          //     İsim        ="a",
          //     Kullanici_adi= "b",
          //     Soyisim     ="a",
          //     Sifre       ="a",
          //     Yemek       =2,
          //     Esya        =2,
          //     Para        =2,
          //     Kayit_tarihi=DateTime.Now,

          //});

          //  context.Isletme.Add(new Isletme
          //  {
          //
          //     alan_id = 1,
          //     isletme_sahibi             =1,
          //     isletme_turu               =3,
          //     kullanici_isletme_ucreti   =0,
          //     yonetici_isletme_ucreti    =0,
          //     isletme_seviyesi           =4,
          //     isletme_kapasitesi         =999,
          //     isletme_calisan_sayisi     =0,
          //     seviye_baslangic_tarihi    =DateTime.Now,
          //
          //  });
          //  context.SaveChanges();

               // TestDbContext context = new TestDbContext();
               //  context.TestTable.Add(new TestTable() 
               //  {
               //    Name = "Seref",
               //    Age = 35,
               //  });
               //  context.SaveChanges();
            
               // List<TestTable> l = context.TestTable.Where(x => x.Age > 18).OrderBy(x => x.Name).ToList();
               //
               //
               // foreach (var item in l)
               // {
               //     Console.WriteLine($"{item.id} - {item.Name} - {item.Age}");
               // }
            
               //l[0].Number = 111;
               //context.Update(l[0]);
               //context.SaveChanges();

        }
    }


    class MetaLandContext : DbContext
    {
        public DbSet<Alan>          Alan                    { get; set; }
        public DbSet<Users>         Users                   { get; set; }
        public DbSet<Emlak>         Emlak                   { get; set; }
        public DbSet<Magaza>        Magaza                  { get; set; }
        public DbSet<Markets>       Markets                 { get; set; }
        public DbSet<Isletme>       Isletme                 { get; set; }
        public DbSet<IsIlani>       IsIlani                 { get; set; }
        public DbSet<Employee>      Employee                { get; set; }
        public DbSet<EmlakIslem>    EmlakIslemTable         { get; set; }
        public DbSet<GameSettings>  GameSettingsTable       { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= ASUSX550V\\SQLEXPRESS;Database=metaLand;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }


    // class TestTable
    // {
    //     public int id { get; set; }
    //     public string Name { get; set; }
    //     public int Age { get; set; }
    // }


    // class TestDbContext : DbContext 
    // {
    //     public DbSet<TestTable>     TestTable           { get; set;}
    // 
    //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     {
    //         optionsBuilder.UseSqlServer("Server= ASUSX550V\\SQLEXPRESS;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True;");
    //     }
    // }
}