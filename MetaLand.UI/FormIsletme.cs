using MetaLand.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaLand.UI
{

    public partial class FormIsletme : Form
    {
        private AreaButton button;
        private Users user;

        internal FormIsletme(AreaButton button, Users user)
        {
            this.button = button;
            this.user = user;
            InitializeComponent();
        }


        private void FormIsletme_Load(object sender, EventArgs e)
        {
            this.BackColor = button.BackColor;
            lblIsletmeAdi.Text = $"{button.Text.ToString()} Isletmesine Hosgeldiniz!!";
            lblSahip2.Text = button.IsletmeSahibi.ToString();
            /*SEVİYE BAŞLANGIÇ TARİHİNİN SANİYE SALİSELERİ YAZMAMASI İÇİN FORMATLAMA GEREKİYOR!!!*/
            lblTarih2.Text = button.SeviyeBaslangic.ToShortDateString();
            lblKapasite2.Text = button.Kapasite.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.id != 1)
            {

                if (button.Text.Contains("Mağaza"))
                {
                    user.Esya = user.Esya + int.Parse(textBox1.Text);
                }
                else
                {
                    user.Yemek = user.Yemek + int.Parse(textBox1.Text);
                }
                user.Para = user.Para - (int.Parse(textBox1.Text) * button.MalzemeParasi);
                Program.context.Users.Update(user);
                Program.context.SaveChanges();


            }

        }
    }
}
