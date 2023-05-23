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
    public partial class FormAdmin : Form
    {
        private DateTime date;
        public FormAdmin()
        {
            InitializeComponent();
            getDate();
            listele();

        }

        private void getDate()
        {
            List<GameSettings> settings = Program.context.GameSettings.ToList();
            date = settings[0].Oyun_Tarihi;
            labelDate.Text = $"{date}";
        }
        private void listele()
        {
            List<Users> list = Program.context.Users.ToList();
            dataGridView1.DataSource = list;
        }



        private void btnZaman_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtDate.Text);
            DateTime time = DateTime.Parse(labelDate.Text);
            string text = time.AddDays(a).ToString();
            Debug.WriteLine(text);
            labelDate.Text = $"{text}";
            List<GameSettings> settings = Program.context.GameSettings.ToList();
            settings[0].Oyun_Tarihi = DateTime.Parse(text);
            Program.context.GameSettings.Update(settings[0]);

            foreach (Users u in Program.context.Users)
            {
                if (u.id != 1)
                {
                    u.Para = u.Para - settings[0].Gunluk_Para_Gideri * int.Parse(txtDate.Text);
                    u.Esya = u.Esya - settings[0].Gunluk_Esya_Gideri * int.Parse(txtDate.Text);
                    u.Yemek = u.Yemek - settings[0].Gunluk_Yiyecek_Gideri * int.Parse(txtDate.Text);
                    Program.context.Users.Update(u);
                }
            }
            Program.context.SaveChanges();
            listView1.Items.Clear();
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = false;
            List<Users> l = Program.context.Users.ToList();
            foreach (Users u in l)
            {
                if (u.Kullanici_adi.ToLower().Equals(txtNickName.Text.ToLower()))
                {
                    MessageBox.Show("Böyle bir kullanıcı adı mevcuttur!!");
                    b = true;
                }
            }
            if (!b)
            {
                Program.context.Users.Add(new Users
                {
                    Kullanici_adi = txtNickName.Text,
                    İsim = txtName.Text,
                    Soyisim = txtLastName.Text,
                    Para = int.Parse(txtMoney.Text),
                    Esya = int.Parse(txtItem.Text),
                    Yemek = int.Parse(txtFood.Text),
                    Sifre = txtPassword.Text,
                    Kayit_tarihi = DateTime.Parse(labelDate.Text),
                });
                Program.context.SaveChanges();
                listView1.Items.Clear();
                listele();
            }
        }





        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
        private Users user;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                foreach (Users u in Program.context.Users)
                {
                    if (selectedRow.Cells[0].Value.ToString() == u.id.ToString())
                    // if (selectedRow.Cells[0].Value.ToString().Contains(u.id.ToString()))
                    {
                        user = u; break;
                    }

                }
            }
            if (user is not null)
            {
                FormProfil formProfil = new FormProfil(user, true);
                formProfil.ShowDialog(this);
                listele();

            }
        }
    }
}
