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
            btnZaman = new Button();
            txtDate = new TextBox();
            labelDate = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txtNickName.Location = new Point(43, 14);
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "Kullanıcı Adı";
            txtNickName.Size = new Size(151, 23);
            txtNickName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 43);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "İsim";
            txtName.Size = new Size(151, 23);
            txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(43, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyisim";
            txtLastName.Size = new Size(151, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(228, 14);
            txtMoney.Name = "txtMoney";
            txtMoney.PlaceholderText = "Para";
            txtMoney.Size = new Size(151, 23);
            txtMoney.TabIndex = 4;
            txtMoney.KeyPress += txtMoney_KeyPress;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(228, 43);
            txtItem.Name = "txtItem";
            txtItem.PlaceholderText = "Eşya";
            txtItem.Size = new Size(151, 23);
            txtItem.TabIndex = 5;
            txtItem.KeyPress += txtItem_KeyPress;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(228, 72);
            txtFood.Name = "txtFood";
            txtFood.PlaceholderText = "Yiyecek";
            txtFood.Size = new Size(151, 23);
            txtFood.TabIndex = 6;
            txtFood.KeyPress += txtFood_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 101);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new Size(151, 23);
            txtPassword.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(228, 101);
            button1.Name = "button1";
            button1.Size = new Size(151, 24);
            button1.TabIndex = 8;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnZaman
            // 
            btnZaman.Location = new Point(670, 95);
            btnZaman.Name = "btnZaman";
            btnZaman.Size = new Size(155, 30);
            btnZaman.TabIndex = 9;
            btnZaman.Text = "Zamanı İleri Al";
            btnZaman.UseVisualStyleBackColor = true;
            btnZaman.Click += btnZaman_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(670, 59);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(155, 23);
            txtDate.TabIndex = 10;
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(670, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(155, 34);
            labelDate.TabIndex = 11;
            labelDate.Text = "Date:";
            labelDate.TextAlign = ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(721, 345);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 586);
            Controls.Add(dataGridView1);
            Controls.Add(labelDate);
            Controls.Add(txtDate);
            Controls.Add(btnZaman);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnZaman;
        private TextBox txtDate;
        private Label labelDate;
        private DataGridView dataGridView1;
    }
}