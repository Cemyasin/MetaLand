using MetaLand.UI.Models;
using MetaLand.GUI;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool onay = false;
        private Users user;

        private void button1_Click(object sender, EventArgs e)
        {
         //   Debug.WriteLine($"kullanıcı adı: {txtNickName.Text } password: {txtPassword.Text}");
            Program.context = new MetaLandContext();
            List<Users> l=  Program.context.Users.ToList();
            foreach (Users u in l)
            {
                if (u.Kullanici_adi.ToLower().ToString().Equals(txtNickName.Text.ToString()))
                    if (u.Sifre.Equals(txtPassword.Text))
                    {
                        user=u;
                       // Debug.WriteLine($"{u.Kullanici_adi} giriş yaptii..");
                        onay = true;
                        break;
                    }
            }
            if (onay)
            {
                FormGame formGame = new FormGame(user);
                formGame.ShowDialog(this);
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!!!");
            
        }
    }
}
//FormSignUp formSignUp =new FormSignUp();
//formSignUp.ShowDialog(this);