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
    public partial class FormBenimİsletmem : Form
    {
        private Users user;
        private AreaButton button;
        internal FormBenimİsletmem(AreaButton button, Users user)
        {
            this.user = user;
            this.button = button;
            InitializeComponent();
        }

        private void btnBasvuru_Click(object sender, EventArgs e)
        {
            FormBasvuruListe formBasvuruListe = new FormBasvuruListe(button, user);
            formBasvuruListe.ShowDialog(this);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (e.RowIndex >= 0)
            // {
            //     DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            //     
            // }

        }

        private void FormBenimİsletmem_Load(object sender, EventArgs e)
        {
            var list = Program.context.Employee.Where(x => x.isletme_id == button.IsletmeId).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
