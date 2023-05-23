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
    public partial class FormBasvuruListe : Form
    {
        private Users user;
        private AreaButton button;
        private DataGridViewRow row;
        internal FormBasvuruListe(AreaButton button, Users user)
        {
            this.user = user;
            this.button = button;
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                row = selectedRow;
                FormBasvuruKabul formBasvuruKabul = new FormBasvuruKabul(row, user);
                formBasvuruKabul.ShowDialog(this);

            }
        }

        private void FormBasvuruKabul_Load(object sender, EventArgs e)
        {
            var list = Program.context.IsBasvurusu.Where(x => x.isletme_sahibi_id == user.id && x.isletme_id == button.IsletmeId).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
