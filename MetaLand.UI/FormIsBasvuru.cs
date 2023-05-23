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
    public partial class FormIsBasvuru : Form
    {
        private Users               user;
        private DataGridViewRow     row;
        public FormIsBasvuru(Users user,DataGridViewRow row)
        {
            this.row = row;
            this.user = user;
            InitializeComponent();
        }

        private void FormIsBasvuru_Load(object sender, EventArgs e)
        {
            txtTeklif.Text = row.Cells[3].Value.ToString();
        }

        private void btnTeklif_Click(object sender, EventArgs e)
        {
            var ilan = Program.context.IsIlani.Where(x => x.id == int.Parse(row.Cells[0].Value.ToString())).ToList();
            Program.context.IsBasvurusu.Add(new IsBasvurusu
            {
                basvuran_id = user.id,
                isletme_sahibi_id = ilan[0].isveren_id,
                isletme_id = ilan[0].isletme_id,
                ilan_id = ilan[0].isletme_id,
                teklif = int.Parse(txtTeklif.Text),
            });
            Program.context.SaveChanges();
        }

        private void btnKbl_Click(object sender, EventArgs e)
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
    }
}
