using MetaLand.UI.Models;
using MetaLand.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaLand.UI
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
   

        private void btnSignUp_Click(object sender, EventArgs e)
        {
        Users user = new Users
            {
                Kullanici_adi   = txtNickName.Text,
                İsim            = txtFirstName.Text,
                Soyisim         = txtLastName.Text ,
                Sifre           = txtPassword.Text ,
                Yemek           = 250 ,
                Esya            = 250 ,
                Para            = 500 ,
                Kayit_tarihi    = DateTime.Now ,
            };
            Debug.WriteLine($"kullanıcı adı: {txtNickName.Text} password: {txtPassword.Text}");
            Program.context.Users.Add(user);
            Program.context.SaveChanges();
            FormGame formGame = new FormGame(user);
            formGame.ShowDialog(this);
        }
    }
}
