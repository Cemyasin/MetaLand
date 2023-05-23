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
    public partial class FormBasvuruKabul : Form
    {
        private Users user;
        private DataGridViewRow row;
        internal FormBasvuruKabul(DataGridViewRow row, Users user)
        {
            this.user = user;
            this.row = row;
            InitializeComponent();
        }

        private void FormBasvuruKabul_Load(object sender, EventArgs e)
        {
            var ilan = Program.context.IsBasvurusu.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();
            label1.Text = $"Teklif : {ilan[0].teklif}";
        }

        private void btnKabul_Click(object sender, EventArgs e)
        {
            var game = Program.context.GameSettings.ToList();
            var ilan = Program.context.IsIlani.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();
            Program.context.Employee.Add(new Employee
            {
                user_id = user.id,
                isletme_id = ilan[0].isletme_id,
                baslangic_tarihi = game[0].Oyun_Tarihi,
                cikis_tarihi = game[0].Oyun_Tarihi.AddDays(ilan[0].sure),
                calisma_saatleri = ilan[0].vardiya,
                calisma_gun_sayisi = ilan[0].sure,

            });
            Program.context.IsIlani.RemoveRange(ilan[0]);
            Program.context.SaveChanges();
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            var ilan = Program.context.IsBasvurusu.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();
            Program.context.IsBasvurusu.RemoveRange(ilan[0]);
            Program.context.SaveChanges();
        }
    }
}
