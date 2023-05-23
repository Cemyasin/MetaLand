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
    public partial class FormTeklifler : Form
    {
        private Users user;
        private string row;
        public FormTeklifler(Users user)
        {
            InitializeComponent();
            this.user = user;
            
            showTeklifler();
        }

        private void showTeklifler()
        {
            var query = from t in Program.context.EmlakTeklif
                        join u in Program.context.Users on t.teklif_veren_id equals u.id into uGroup
                        from u in uGroup.DefaultIfEmpty()
                        join i in Program.context.Isletme on t.isletme_id equals i.id into iGroup
                        from i in iGroup.DefaultIfEmpty()
                        join a in Program.context.Isletme on t.isletme_id equals a.id into aGroup
                        from a in aGroup.DefaultIfEmpty()
                        join it in Program.context.IsletmeTuru on i.isletme_turu equals it.id into itGroup
                        from it in itGroup.DefaultIfEmpty()

                        where t.teklif_alan_id == 1
                        select new
                        {
                            t.id,
                            teklif_yapan = u.İsim,
                            teklif_yapılan_alan_adı = (it == null ? "Boş Arsa" : it.isletme_adi),
                            t.isletme_id,
                            t.teklif

                        };
            var list = query.ToList();
            dataGridView1.DataSource = list;
        }

        private EmlakTeklif emlakTeklif;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                row = selectedRow.Cells[2].Value.ToString();
                foreach (EmlakTeklif et in Program.context.EmlakTeklif)
                {
                    if (selectedRow.Cells[0].Value.ToString() == et.id.ToString())
                    // if (selectedRow.Cells[0].Value.ToString().Contains(u.id.ToString()))
                    {
                        emlakTeklif = et; break;
                    }

                }
            }
            if (emlakTeklif is not null)
            {
                FormTeklifKabul formTeklifKabul = new FormTeklifKabul(emlakTeklif,user,row);
                formTeklifKabul.ShowDialog(this);
                dataGridView1.DataSource = null;
                showTeklifler();

            }
        }
    }
}
