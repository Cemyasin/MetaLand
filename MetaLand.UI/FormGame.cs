using MetaLand.UI;
using MetaLand.UI.Models;
using System.Diagnostics;

namespace MetaLand.GUI
{
    public partial class FormGame : Form
    {
        private int x = 0;
        private Users user;
        private List<AreaButton> areaButtons = new List<AreaButton>();

        public FormGame(Users user)
        {
            InitializeComponent();
            this.user = user;
            drawMatrix(5);
            info();
        }

        private void info()
        {
            lblInfo.Text = $@"Kullanıcı Adı: {user.Kullanici_adi} Para: {user.Para} 
Esya: {user.Esya} Yiyecek:{user.Yemek}";
        }
        private void drawMatrix(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    AreaButton b = new AreaButton();
                    b.Size = Theme.Size;
                    b.Location = new Point(60 + j * (Theme.Size.Width + 25), 60 + i * (Theme.Size.Height + 25));
                    b.Text = (++x).ToString();
                    b.Click += click!;
                    areaButtons.Add(b);
                    Controls.Add(b);
                }
            }
            if (user.Kullanici_adi.Equals("admin"))
            {
                Button bb = new Button();
                bb.Size = new Size(130, 49);
                bb.Location = new Point(893, 518);
                bb.Text = "Admin Panel";
                bb.Click += bb_click!;
                Controls.Add(bb);
            }
        }
        private void click(object sender, EventArgs e)
        {

            if (sender is AreaButton button)
            {
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
            FormIsIlani formIsIlani = new FormIsIlani();
            formIsIlani.ShowDialog(this);
        }
    }
}