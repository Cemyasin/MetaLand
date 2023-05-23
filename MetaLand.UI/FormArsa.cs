using MetaLand.UI.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormArsa : Form
    {
        private AreaButton button;
        private Users user;
        internal FormArsa(AreaButton button, Users user)
        {
            this.button = button;
            this.user = user;
            InitializeComponent();
        }

        private void FormArsa_Load(object sender, EventArgs e)
        {
            var result = Program.context.GameSettings.ToList();
            lblTarih.Text = result[0].Oyun_Tarihi.ToShortDateString();

            var query = Program.context.EmlakIslem
                                                .Where(x => x.alan_id == button.IsletmeId)
                                                .Select(x => new
                                                {
                                                    x.isletme_fiyati
                                                }).ToList();

            lblFiyat2.Text = query[0].isletme_fiyati.ToString();
            lblId2.Text = button.IsletmeId.ToString();

        }

        private EmlakIslem emm;
        private void button1_Click(object sender, EventArgs e)
        {
            //  List <EmlakIslem> list = Program.context.EmlakIslem.Where(x => x.alan_id == button.IsletmeId).ToList();
            //  list[0].ilanda_mi = 0;
            //  Program.context.EmlakIslem.Update(list[0]);
            //  
            //  List<Alan> l = Program.context.Alan.Where(x => x.id == button.IsletmeId).ToList();
            //  l[0].alan_sahibi_id = user.id;
            //  Program.context.Alan.Update(l[0]);
            //
            //  Debug.WriteLine($" alan sahibi : {l[0].alan_sahibi_id} ilanda mi{list[0].ilanda_mi}");
            //Program.context.SaveChanges();

           



            //var entity = Program.context.EmlakIslem.Find(list.id);

            Program.context.SaveChanges();
        }
    }
}
