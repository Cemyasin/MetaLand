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
        public FormIsIlani()
        {
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
                            it.isletme_adi,
                            u.İsim,
                            u.Soyisim,
                            i.maas,
                            v.calisma_saati,
                        };
            var result = query.ToList();
            foreach (var item in result)
            {
                Debug.WriteLine($"id: {item.id} işletme adı: {item.isletme_adi} işveren adı:{item.İsim} {item.Soyisim} maas: {item.maas} vardiya: {item.calisma_saati}");
                string[] items =
                {
                    item.isletme_adi.ToString(),
                    item.İsim.ToString()+" "+item.Soyisim.ToString(),
                    item.maas.ToString(),
                    item.calisma_saati,
                };
                ListViewItem listItem = new ListViewItem(items);
                listView1.Items.Add(listItem);
            }

        }
    }
}
