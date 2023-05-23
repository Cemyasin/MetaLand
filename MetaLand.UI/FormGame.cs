using MetaLand.UI;
using MetaLand.UI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MetaLand.GUI
{
    public partial class FormGame : Form
    {
        private int x = -1;
        private Users user;
        private List<AreaButton> areaButtons = new List<AreaButton>();

        public FormGame(Users user)
        {
            this.user = user;
            InitializeComponent();
            drawMatrix(5);
            info();
        }

        private void info()
        {
            lblInfo.Text = $@"Kullanıcı Adı: {user.Kullanici_adi} Para: {user.Para} 
Esya: {user.Esya} Yiyecek:{user.Yemek}";
        }
        private async void drawMatrix(int n)
        {
            var query = from a   in Program .context.Alan
                        join i   in Program .context.Isletme     on a.id                equals i.alan_id      into iGroup
                        from i   in iGroup  .DefaultIfEmpty()
                        join u   in Program .context.Users       on i.isletme_sahibi_id equals u.id           into uGroup
                        from u   in uGroup  .DefaultIfEmpty()                                                 
                        join t   in Program .context.IsletmeTuru on i.isletme_turu      equals t.id           into tGroup
                        from t   in tGroup  .DefaultIfEmpty()
                        join mag in Program .context.Magaza      on i.id                equals mag.isletme_id into magGroup
                        from mag in magGroup.DefaultIfEmpty()
                        join mar in Program .context.Markets     on i.id                equals mar.isletme_id into marGroup
                        from mar in marGroup.DefaultIfEmpty()
                        join ur  in Program .context.Users       on a.alan_sahibi_id    equals ur.id          into urGroup
                        from ur  in urGroup .DefaultIfEmpty()
                        select new { a, i, t, u, mag, mar ,ur};

            var result  =   query   .ToList();
            var item    =   result  .ToList();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    AreaButton b = new AreaButton();

                    if (item[++x].i == null)
                    {
                        b.AlanAdi           = "Boş Arsa";
                        b.Back_color        = Color.YellowGreen;
                        b.IsletmeId         = item[x].a.id;
                        b.IsletmeSahibi     = item[x].ur.İsim;
                        b.SahipId           = item[x].ur.id;
                    }
                    else
                    {
                        b.SahipId           = item[x].u.id;
                        b.IsletmeId         = item[x].i.id;
                        b.AlanAdi           = item[x].t.isletme_adi;
                        b.IsletmeSahibi     = item[x].u.İsim + item[x].u.Soyisim;
                        b.SeviyeBaslangic   = item[x].i.seviye_baslangic_tarihi;
                        b.Calisan           = item[x].i.isletme_calisan_sayisi;
                        b.Kapasite          = item[x].i.isletme_kapasitesi;
                        
                        if (item[x].i.isletme_turu == 1)
                        {
                            b.Back_color    = Color.CadetBlue;
                            b.MalzemeParasi = item[x].mag.esya_ucreti;
                        }
                        else if (item[x].i.isletme_turu == 3)
                        {
                            b.Back_color    = Color.Goldenrod;
                            b.MalzemeParasi = item[x].mar.yiyecek_ucreti;
                        }
                        else
                        {
                            b.Back_color = Color.Salmon;
                        }
                    }
                    b.BackColor      =       b.Back_color;
                    b.Text           =       $"{b.AlanAdi} \n ID: {b.IsletmeId}";
                    b.ForeColor      =       Color.White;
                    b.Size           =       Theme.Size;
                    b.TextAlign      =       ContentAlignment.MiddleCenter;
                    b.Location       =       new Point(60 + j * (Theme.Size.Width + 25), 60 + i * (Theme.Size.Height + 25));
                    b.Click         +=       click!;
                    areaButtons.Add(b);
                    Controls.Add(b);
                }
            }
            if (user.Kullanici_adi.Equals("admin"))
            {
                Button bb        =      new Button();
                bb.Size          =      new Size(130, 49);
                bb.Location      =      new Point(893, 518);
                bb.Text          =      "Admin Panel";
                bb.Click        +=      bb_click!;
                Controls.Add(bb);
            }
        }
        private void click(object sender, EventArgs e)
        {

            if (sender is AreaButton button)
            {
                if (button.SahipId == user.id)
                {
                    FormBenimİsletmem formBenimİsletmem = new FormBenimİsletmem(button, user);
                    formBenimİsletmem.ShowDialog(this);
                }
                else
                {


                    if (button.Text.Contains("Emlak"))
                    {
                        FormEmlak formEmlak = new FormEmlak(button, user);
                        formEmlak.BackColor = button.BackColor;
                        formEmlak.ShowDialog(this);
                    }
                    else if (button.Text.StartsWith("Boş"))
                    {
                        if (button.IsletmeSahibi == "admin")
                        {
                            FormArsa formArsa = new FormArsa(button, user);
                            formArsa.BackColor = button.BackColor;
                            formArsa.ShowDialog(this);
                        }
                        else
                        {
                            var query = Program.context.EmlakIslem
                                                                   .Where(x => x.alan_id == button.IsletmeId)
                                                                   .Join(Program.context.Emlak,
                                                                        x => x.islemin_yapildigi_emlak_id,
                                                                        e => e.id,
                                                                        (x, e) => new
                                                                        {
                                                                            e.isletme_id,
                                                                            x.alan_id
                                                                        }).ToList();

                            if (query.Count <= 0)
                            {
                                if (button.SahipId == user.id)
                                {
                                    MessageBox.Show("işletme kurmak ister misin canim??!?");
                                }
                                else
                                {
                                    MessageBox.Show($"Bu Boş Arsa Satılık Değildir ,{button.IsletmeSahibi} bu alanın sahibidir. ");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Bu Boş Arsayı Satın Almak İçin {query[0].isletme_id} Numaralı Emlak " +
                                    $"Noktasına Gidiniz!!");
                            }

                        }

                    }
                    else
                    {


                        FormIsletme formIsletme = new FormIsletme(button, user);
                        formIsletme.ShowDialog(this);

                    }
                }
                Debug.WriteLine($"AreaBuuton tıklandi : {button.Text}");
            }
        }
        private void bb_click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog(this);
        }
        private void btnIsIlani_Click(object sender, EventArgs e)
        {
            FormIsIlani formIsIlani = new FormIsIlani(user);
            formIsIlani.ShowDialog(this);
        }

        private void btnIsletme_Click(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil(user, false);
            formProfil.ShowDialog(this);
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            List<GameSettings> list = Program.context.GameSettings.ToList();
            label2.Text = list[0].Oyun_Tarihi.ToShortDateString();
        }
    }
}