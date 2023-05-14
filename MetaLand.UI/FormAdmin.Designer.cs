namespace MetaLand.UI
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            kullanici_adi = new ColumnHeader();
            isim = new ColumnHeader();
            soyisim = new ColumnHeader();
            yiyecek = new ColumnHeader();
            para = new ColumnHeader();
            esya = new ColumnHeader();
            sifre = new ColumnHeader();
            kayit_tarihi = new ColumnHeader();
            txtNickName = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtMoney = new TextBox();
            txtItem = new TextBox();
            txtFood = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            labelDate = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { kullanici_adi, isim, soyisim, yiyecek, para, esya, sifre, kayit_tarihi });
            listView1.GridLines = true;
            listView1.Location = new Point(43, 270);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 272);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // kullanici_adi
            // 
            kullanici_adi.Text = "Kullanıcı Adı";
            kullanici_adi.Width = 80;
            // 
            // isim
            // 
            isim.Text = "İsim";
            isim.Width = 80;
            // 
            // soyisim
            // 
            soyisim.Text = "Soyisim";
            soyisim.Width = 80;
            // 
            // yiyecek
            // 
            yiyecek.Text = "Yiyecek";
            // 
            // para
            // 
            para.Text = "Para";
            // 
            // esya
            // 
            esya.Text = "Eşya";
            // 
            // sifre
            // 
            sifre.Text = "Şifre";
            sifre.Width = 80;
            // 
            // kayit_tarihi
            // 
            kayit_tarihi.Text = "Kayıt Tarihi";
            kayit_tarihi.Width = 140;
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(43, 44);
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "Kullanıcı Adı";
            txtNickName.Size = new Size(151, 23);
            txtNickName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 73);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "İsim";
            txtName.Size = new Size(151, 23);
            txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(43, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyisim";
            txtLastName.Size = new Size(151, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(228, 44);
            txtMoney.Name = "txtMoney";
            txtMoney.PlaceholderText = "Para";
            txtMoney.Size = new Size(151, 23);
            txtMoney.TabIndex = 4;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(228, 73);
            txtItem.Name = "txtItem";
            txtItem.PlaceholderText = "Eşya";
            txtItem.Size = new Size(151, 23);
            txtItem.TabIndex = 5;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(228, 102);
            txtFood.Name = "txtFood";
            txtFood.PlaceholderText = "Yiyecek";
            txtFood.Size = new Size(151, 23);
            txtFood.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new Size(151, 23);
            txtPassword.TabIndex = 7;
            // 
            // btnIsIlani
            // 
            button1.Location = new Point(228, 131);
            button1.Name = "btnIsIlani";
            button1.Size = new Size(151, 32);
            button1.TabIndex = 8;
            button1.Text = "Ekle/Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnIsletme
            // 
            button2.Location = new Point(1024, 95);
            button2.Name = "btnIsletme";
            button2.Size = new Size(155, 30);
            button2.TabIndex = 9;
            button2.Text = "Zamanı İleri Al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1024, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 10;
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(1024, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(155, 34);
            labelDate.TabIndex = 11;
            labelDate.Text = "Date:";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 640);
            Controls.Add(labelDate);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtFood);
            Controls.Add(txtItem);
            Controls.Add(txtMoney);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtNickName);
            Controls.Add(listView1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox txtNickName;
        private TextBox txtName;
        private TextBox txtLastName;
        private ColumnHeader kullanici_adi;
        private ColumnHeader isim;
        private ColumnHeader soyisim;
        private ColumnHeader yiyecek;
        private ColumnHeader para;
        private ColumnHeader esya;
        private ColumnHeader sifre;
        private ColumnHeader kayit_tarihi;
        private TextBox txtMoney;
        private TextBox txtItem;
        private TextBox txtFood;
        private TextBox txtPassword;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label labelDate;
    }
}