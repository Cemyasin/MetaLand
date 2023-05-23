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
    public partial class FormTeklifKabul : Form
    {
        private Users           user;
        private EmlakTeklif     emlakTeklif;
        private string row;
        internal FormTeklifKabul(EmlakTeklif emlakTeklif,Users user, string row)
        {
            InitializeComponent();
            this.user = user;
            this.row = row;
            this.emlakTeklif = emlakTeklif;
        }

        private void btnKbl_Click(object sender, EventArgs e)
        {

            int flag = 0;
            int sahip_id;
            List<Users>     users   = Program.context.Users  .ToList();
            List<Isletme>   isletme = Program.context.Isletme.Where(x => x.isletme_sahibi_id ==     user      .id && x.isletme_turu==2).ToList();
            List<Emlak>     emlakci = Program.context.Emlak  .Where(x => x.isletme_id        ==     isletme[0].id).ToList();
            if (row.StartsWith("Boş"))
            {
                List<Alan> list         = Program    .context.Alan.Where(x => x.id == emlakTeklif.isletme_id).ToList();
                sahip_id                = list[0]    .alan_sahibi_id;
                list[0].alan_sahibi_id = emlakTeklif.teklif_veren_id;
                Program.context.Alan.Update(list[0]);
            }
            else
            {
                List<Isletme> list        = Program    .context.Isletme.Where(x => x.id == emlakTeklif.isletme_id).ToList();
                sahip_id                  = list[0]    .isletme_sahibi_id;
                list[0].isletme_sahibi_id = emlakTeklif.teklif_veren_id;
                Program.context.Isletme.Update(list[0]);
            }
            foreach (Users u in users)
            {
                if (flag   == 3)
                    break;
                if (u.id   == emlakTeklif.teklif_veren_id)
                {
                    u.Para = u.Para - int.Parse(emlakTeklif.teklif.ToString());
                    flag++;
                }
                else if (u.id == sahip_id)
                {
                    u.Para  = u.Para + emlakTeklif.teklif * (100 - int.Parse(emlakci[0].emlak_komisyonu.ToString()) / 100);
                    flag++;
                }
                if (u.id    == user.id )
                {
                    u.Para  = u.Para + (emlakTeklif.teklif * int.Parse(emlakci[0].emlak_komisyonu.ToString()) / 100);
                    flag++;
                }
                Program.context.Users.Update(u);
            }
            var teklif = Program.context.EmlakTeklif.Find(emlakTeklif.id);
            Program.context.EmlakTeklif             .RemoveRange(teklif);
            Program.context                         .SaveChanges();
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            var teklif = Program.context.EmlakTeklif.Find(emlakTeklif);
            Program.context.EmlakTeklif             .RemoveRange(teklif);
            Program.context                         .SaveChanges();
        }
    }
}
