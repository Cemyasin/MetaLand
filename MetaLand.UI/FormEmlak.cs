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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MetaLand.UI
{
    public partial class FormEmlak : Form
    {
        private Users       user;
        private AreaButton  button;
        internal FormEmlak(AreaButton button, Users user)
        {
            this.user   = user;
            this.button = button;
            InitializeComponent();
        }
        private void FormEmlak_Load(object sender, EventArgs e)
        {
            if(user.id  ==  button.SahipId) {
            Button button3   = new Button();
            button3.Location = new Point (594, 261);
            button3.Size     = new Size  (75, 36);
            button3.TabIndex = 14;
            button3.Name     = "button3";
            button3.Text     = "Teklifler";
            button3.UseVisualStyleBackColor = true;
            button3.Click   += button3_Click;
            Controls.Add(button3);
                listeleSatilik();
            }


        }
        private void listeleKiralik()
        {
            var kiralikQuery = from  e in    Program .context.EmlakIslem
                               join  a in    Program .context.Alan        on e.alan_id                    equals a.id into aGroup
                               from  a in    aGroup  .DefaultIfEmpty()
                               join  i in    Program .context.Isletme     on e.isletme_id                 equals i.id into iGroup
                               from  i in    iGroup  .DefaultIfEmpty()
                               join  t in    Program .context.IsletmeTuru on i.isletme_turu               equals t.id into tGroup
                               from  t in    tGroup  .DefaultIfEmpty()
                               join  em in   Program .context.Emlak       on e.islemin_yapildigi_emlak_id equals em.id into emGroup
                               from  em in   emGroup .DefaultIfEmpty()
                               join  u in    Program .context.Users       on i.isletme_sahibi_id          equals u.id into uGroup
                               from  u in    uGroup  .DefaultIfEmpty()
                               where e.emlak_islemi  .StartsWith("K")
                               where e.ilanda_mi   == 1
                               where em.isletme_id == button.IsletmeId
                               select new
                               {
                                   ID               = i.id                      == null ? a.id       : i.id,
                                   isletme_adi      = t.isletme_adi             == null ? "Boş Arsa" : t.isletme_adi,
                                   Kira_Bedeli      = e.kiralik_isletme_fiyati,
                                   Kira_Suresi      = $"{e.kira_suresi} Gun",
                                   İşletmeSahibi    = u.İsim,
                                   Emlakçı          = button.IsletmeSahibi,
                                   Komisyon_Oranı   = em.emlak_komisyonu,
                               };
           
            var result  = kiralikQuery.ToList();
            var item    = result      .ToList();

            dataGridView1.DataSource = item;
        }

        private void listeleSatilik()
        {
            var satilikQuery = from  e  in Program   .context.EmlakIslem
                               join  a  in Program   .context.Alan         on e.alan_id                    equals a.id  into aGroup
                               from  a  in aGroup    .DefaultIfEmpty()
                               join  i  in Program   .context.Isletme      on e.isletme_id                 equals i.id  into iGroup
                               from  i  in iGroup    .DefaultIfEmpty()
                               join  t  in Program   .context.IsletmeTuru  on i.isletme_turu               equals t.id  into tGroup
                               from  t  in tGroup    .DefaultIfEmpty()
                               join  em in Program   .context.Emlak        on e.islemin_yapildigi_emlak_id equals em.id into emGroup
                               from  em in emGroup   .DefaultIfEmpty()
                               join  u  in Program   .context.Users        on i.isletme_sahibi_id          equals u.id  into uGroup
                               from  u  in uGroup    .DefaultIfEmpty()
                               join  ur in Program   .context.Users        on a.alan_sahibi_id             equals ur.id into urGroup
                               from  ur in urGroup   .DefaultIfEmpty()
                               where e .emlak_islemi .StartsWith("S")
                               where em.isletme_id   == button.IsletmeId
                               select new
                               {
                                   ID               = i.id                  == null ? a.id       : i.id,
                                   isletme_adi      = t.isletme_adi         == null ? "Boş Arsa" : t.isletme_adi,
                                   e.isletme_fiyati,
                                   İşletmeSahibi    = u.İsim                == null ? ur.İsim    : u.İsim,
                                   Emlakçı          = button.IsletmeSahibi,
                                   Komisyon_Oranı   = em.emlak_komisyonu,
                               };

            var result = satilikQuery.ToList();
            var item   = result      .ToList();

            dataGridView1.DataSource = item;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            listeleKiralik();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            listeleSatilik();
        }

        public void getBosArsa()
        {
            Debug.WriteLine(button.IsletmeSahibi);
        }

        private EmlakIslem emlak;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                
                /*foreach (EmlakIslem em in Program.context.EmlakIslem)
                {
                    if (selectedRow.Cells[0].Value.ToString() == (em.isletme_id == null ? em.alan_id.ToString() : em.isletme_id.ToString()))
                    // if (selectedRow.Cells[0].Value.ToString().Contains(u.id.ToString()))
                    {
                        emlak = em; break;
                    }

                }*/


                lblID2           .Text     = selectedRow.Cells[0].Value.ToString();
                lblIsletmeAdi2   .Text     = selectedRow.Cells[1].Value.ToString();
                lblFiyat2        .Text     = selectedRow.Cells[2].Value.ToString();
                lblIsletmeSahibi2.Text     = selectedRow.Cells[3].Value.ToString();
                lblEmlakci2      .Text     = selectedRow.Cells[4].Value.ToString();

                FormEmlakTeklif formEmlakTeklif = new FormEmlakTeklif(selectedRow, user, button.SahipId);
                formEmlakTeklif.ShowDialog(this);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTeklifler formTeklifler = new FormTeklifler(user);
            formTeklifler.ShowDialog(this);
        }

    }
}
