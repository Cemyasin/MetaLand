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
    public partial class FormIsIlani : Form
    {
        private Users user;
        public FormIsIlani(Users user)
        {
            this.user = user;
            InitializeComponent();
            ilanListele();
        }

        private void ilanListele()
        {
            // List<IsIlani> list = Program.context.IsIlani.ToList();
            //Program.context.IsIlani.

            var query = from i in Program.context.IsIlani
                        join il in Program.context.Isletme on i.isletme_id equals il.id
                        join it in Program.context.IsletmeTuru on il.isletme_turu equals it.id
                        join v in Program.context.Vardiya on i.vardiya equals v.id
                        join u in Program.context.Users on i.isveren_id equals u.id
                        select new
                        {
                            i.id,
                            İşletme = it.isletme_adi,
                            Sahibi = u.İsim + " " + u.Soyisim,
                            Maaş = i.maas,
                            ÇalışmaSaati = v.calisma_saati,
                        };
            var result = query.ToList();
            dataGridView1.DataSource = result;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                FormIsBasvuru formIsBasvuru = new FormIsBasvuru(user,selectedRow);
                formIsBasvuru.ShowDialog(this);
            }
        }
    }
}
