using MetaLand.UI.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormEmlakTeklif : Form
    {
        private int                 id;
        private DataGridViewRow     row;
        private Users               user;
        public FormEmlakTeklif(DataGridViewRow row, Users user,int id)
        {
            InitializeComponent();
            this.id     = id;
            this.row    = row;
            this.user   = user;
        }

        private void FormEmlakTeklif_Load(object sender, EventArgs e)
        {
            txtTeklif.Text = row.Cells[2].Value.ToString();
        }

        private void txtTeklif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show($"{txtTeklif.Text} değerinde teklifiniz gönderildi.");
            if (row.Cells[1].Value.ToString().StartsWith("Boş"))
            {
                List<Alan> l = Program.context.Alan.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();

                Program.context.EmlakTeklif.Add(new EmlakTeklif
                {
                    teklif_alan_id = this.id,
                    teklif_veren_id =user.id,
                    isletme_id = l[0].id,
                    teklif = int.Parse( txtTeklif.Text)
                });;
            }
            else
            {
                List<Isletme> l = Program.context.Isletme.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();

                Program.context.EmlakTeklif.Add(new EmlakTeklif
                {
                    teklif_alan_id = this.id,
                    teklif_veren_id = user.id,
                    isletme_id = l[0].id,
                    teklif = int.Parse(txtTeklif.Text)
                }); ;
            }
            Program.context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (row.Cells[1].Value.ToString().StartsWith("Boş"))
            {
                List<Alan> l = Program.context.Alan.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();
                List<Users> users = Program.context.Users.ToList();
                int flag=0;
                foreach (Users u in users)
                {
                    if (flag == 3)
                        break;
                    if(u.id == user.id)
                    {
                        u.Para = u.Para - int.Parse(txtTeklif.Text);
                        flag++;
                    }
                    else if (u.id == l[0].alan_sahibi_id)
                    {
                        u.Para = u.Para + (int.Parse(txtTeklif.Text) * (100 - (int.Parse(row.Cells[5].Value.ToString()))) / 100);
                        flag++;
                    }
                    if (u.id == id)
                    {
                        u.Para = u.Para + (int.Parse(txtTeklif.Text) * (int.Parse(row.Cells[5].Value.ToString())) / 100);
                        flag++;
                    }
                    Program.context.Users.Update(u);
                }
                l[0].alan_sahibi_id = user.id;
                Program.context.Alan.Update(l[0]);
            }
            else
            {
                int flag = 0;
                List<Isletme> list = Program.context.Isletme.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();
                List<Users> users = Program.context.Users.ToList();
                foreach (Users u in users)
                {
                    if (flag == 3)
                        break;
                    if (u.id == user.id)
                    {
                        u.Para = u.Para - int.Parse(txtTeklif.Text);
                        flag++;
                    }
                    else if (u.id == list[0].isletme_sahibi_id)
                    {
                        u.Para = u.Para + (int.Parse(txtTeklif.Text) * (100 - (int.Parse(row.Cells[5].Value.ToString()))) / 100);
                        flag++;
                    }
                    if (u.id == id)
                    {
                        u.Para = u.Para + (int.Parse(txtTeklif.Text) * (int.Parse(row.Cells[5].Value.ToString())) / 100);
                        flag++;
                    }
                    Program.context.Users.Update(u);
                }
                list[0].isletme_sahibi_id = user.id;
                Program.context.Isletme.Update(list[0]);
            }

        }
    }
}
