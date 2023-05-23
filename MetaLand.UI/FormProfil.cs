using MetaLand.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaLand.UI
{
    public partial class FormProfil : Form
    {
        private Users user;
        private bool isEnabled;

        public FormProfil(Users user, bool isEnabled)
        {
            InitializeComponent();
            this.user = user;
            this.isEnabled = isEnabled;
            ShowProfile();
        }

        void ShowProfile()
        {
            if (user != null)
            {
                if (!isEnabled)
                {
                    txtNickName.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtFood.Enabled = false;
                    txtItem.Enabled = false;
                    txtMoney.Enabled = false;
                    textBox7.Enabled = false;
                    lblKayit_tarihi.Enabled = false;
                }
                txtNickName.Text = user.Kullanici_adi;
                txtFirstName.Text = user.İsim;
                txtLastName.Text = user.Soyisim;
                txtFood.Text = user.Yemek.ToString();
                txtItem.Text = user.Esya.ToString();
                txtMoney.Text = user.Para.ToString();
                lblKayit_tarihi.Text = user.Kayit_tarihi.ToString();

                //var query = from i in Program.context.Isletme
                //            join e in Program.context.Employee on i.id equals e.isletme_id
                //            join eu in Program.context.Users on e.user_id equals eu.id
                //            where i.isletme_sahibi_id == user.id
                //            select new
                //            {
                //                i.id,
                //                i.alan_id,
                //                i.isletme_seviyesi,
                //                i.isletme_calisan_sayisi,
                //                i.seviye_baslangic_tarihi,
                //                eu.İsim,
                //                eu.Soyisim,
                //            };
                //var results = query.ToList();

                var getIsletmeNumberQuery = from i in Program.context.Isletme
                                            where i.isletme_sahibi_id == user.id
                                            group i by i.isletme_sahibi_id into g
                                            select new
                                            {
                                                adet = g.Count()
                                            };

                var IsletmeNumber = getIsletmeNumberQuery.ToList();
                if (IsletmeNumber.Count > 0)
                    textBox7.Text = IsletmeNumber[0].adet.ToString();
                else
                    textBox7.Text = "0";

                //foreach (var item in results)
                //{
                //    Debug.WriteLine($"işletme id: {item.id} alan id: {item.alan_id} isletme seviyesi: {item.isletme_seviyesi}" +
                //        $"  işletme calısan sayisi: {item.isletme_calisan_sayisi} seviye baslangic tarihi: {item.seviye_baslangic_tarihi}" +
                //        $"  çalışan adı:{item.İsim} {item.Soyisim}");
                //
                //}

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Kullanici_adi = txtNickName.Text;
            user.İsim = txtFirstName.Text;
            user.Soyisim = txtLastName.Text;
            user.Yemek = int.Parse(txtFood.Text);
            user.Esya = int.Parse(txtItem.Text);
            user.Para = int.Parse(txtMoney.Text);
            Program.context.Users.Update(user);
            Program.context.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.context.Users.RemoveRange(user);
            Program.context.SaveChanges();
        }
    }
}
