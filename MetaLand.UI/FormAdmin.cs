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
        public FormAdmin()
        {
            InitializeComponent();
            labelDate.Text = $"{DateTime.Now}";
            listele();

        }

        private void listele()
        {
            List<Users> list = Program.context.Users.ToList();
            foreach (Users u in list)
            {
                if (u.id == 1)
                    continue;
                string[] items =
               {
                    u.Kullanici_adi,
                    u.İsim,
                    u.Soyisim,
                    u.Para.ToString(),
                    u.Esya.ToString(),
                    u.Sifre,
                    u.Yemek.ToString(),
                    u.Kayit_tarihi.ToString()
                };
                ListViewItem listItem = new ListViewItem(items);
                listView1.Items.Add(listItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            DateTime time = DateTime.Parse(labelDate.Text);
            string text = time.AddDays(a).ToString();
            Debug.WriteLine(text);
            labelDate.Text = $"{text}";
        }
    }
}
