namespace MetaLand.UI
{
    partial class FormEmlak
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
            dataGridView1 = new DataGridView();
            lblIsletme = new Label();
            button1 = new Button();
            button2 = new Button();
            lblID = new Label();
            lblIsletmeAdi = new Label();
            lblIsletmeSahibi = new Label();
            lblEmlakci = new Label();
            lblEmlakci2 = new Label();
            lblIsletmeSahibi2 = new Label();
            lblIsletmeAdi2 = new Label();
            lblID2 = new Label();
            lblFiyat2 = new Label();
            lblFiyat = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(657, 244);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // lblIsletme
            // 
            lblIsletme.BackColor = Color.Transparent;
            lblIsletme.Font = new Font("Segoe Script", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblIsletme.ForeColor = SystemColors.ControlLightLight;
            lblIsletme.Location = new Point(12, 9);
            lblIsletme.Name = "lblIsletme";
            lblIsletme.Size = new Size(657, 78);
            lblIsletme.TabIndex = 1;
            lblIsletme.Text = "Emlak İşletmesine Hoşgeldiniz";
            lblIsletme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(503, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "SATILIK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReddet
            // 
            button2.Location = new Point(594, 115);
            button2.Name = "btnReddet";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "KIRALIK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblID
            // 
            lblID.Location = new Point(69, 97);
            lblID.Name = "lblID";
            lblID.Size = new Size(87, 23);
            lblID.TabIndex = 4;
            lblID.Text = "ID:";
            lblID.TextAlign = ContentAlignment.TopRight;
            // 
            // lblIsletmeAdi
            // 
            lblIsletmeAdi.Location = new Point(69, 138);
            lblIsletmeAdi.Name = "lblIsletmeAdi";
            lblIsletmeAdi.Size = new Size(87, 23);
            lblIsletmeAdi.TabIndex = 5;
            lblIsletmeAdi.Text = "İşletme Adı:";
            lblIsletmeAdi.TextAlign = ContentAlignment.TopRight;
            // 
            // lblIsletmeSahibi
            // 
            lblIsletmeSahibi.Location = new Point(69, 181);
            lblIsletmeSahibi.Name = "lblIsletmeSahibi";
            lblIsletmeSahibi.Size = new Size(87, 23);
            lblIsletmeSahibi.TabIndex = 6;
            lblIsletmeSahibi.Text = "İşletme Sahibi:";
            lblIsletmeSahibi.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEmlakci
            // 
            lblEmlakci.Location = new Point(69, 225);
            lblEmlakci.Name = "lblEmlakci";
            lblEmlakci.Size = new Size(87, 23);
            lblEmlakci.TabIndex = 7;
            lblEmlakci.Text = "Emlakçı:";
            lblEmlakci.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEmlakci2
            // 
            lblEmlakci2.Location = new Point(174, 225);
            lblEmlakci2.Name = "lblEmlakci2";
            lblEmlakci2.Size = new Size(87, 23);
            lblEmlakci2.TabIndex = 11;
            lblEmlakci2.Text = "Emlakçı:";
            // 
            // lblIsletmeSahibi2
            // 
            lblIsletmeSahibi2.Location = new Point(174, 181);
            lblIsletmeSahibi2.Name = "lblIsletmeSahibi2";
            lblIsletmeSahibi2.Size = new Size(87, 23);
            lblIsletmeSahibi2.TabIndex = 10;
            lblIsletmeSahibi2.Text = "İşletme Sahibi:";
            // 
            // lblIsletmeAdi2
            // 
            lblIsletmeAdi2.Location = new Point(174, 138);
            lblIsletmeAdi2.Name = "lblIsletmeAdi2";
            lblIsletmeAdi2.Size = new Size(87, 23);
            lblIsletmeAdi2.TabIndex = 9;
            lblIsletmeAdi2.Text = "İşletme Adı:";
            // 
            // lblID2
            // 
            lblID2.Location = new Point(174, 97);
            lblID2.Name = "lblID2";
            lblID2.Size = new Size(87, 23);
            lblID2.TabIndex = 8;
            lblID2.Text = "ID:";
            // 
            // lblFiyat2
            // 
            lblFiyat2.Location = new Point(174, 261);
            lblFiyat2.Name = "lblFiyat2";
            lblFiyat2.Size = new Size(87, 23);
            lblFiyat2.TabIndex = 13;
            lblFiyat2.Text = "Fiyat:";
            // 
            // lblFiyat
            // 
            lblFiyat.Location = new Point(69, 261);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(87, 23);
            lblFiyat.TabIndex = 12;
            lblFiyat.Text = "Fiyat:";
            lblFiyat.TextAlign = ContentAlignment.TopRight;
           
            // 
            // FormEmlak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 591);
            Controls.Add(lblFiyat2);
            Controls.Add(lblFiyat);
            Controls.Add(lblEmlakci2);
            Controls.Add(lblIsletmeSahibi2);
            Controls.Add(lblIsletmeAdi2);
            Controls.Add(lblID2);
            Controls.Add(lblEmlakci);
            Controls.Add(lblIsletmeSahibi);
            Controls.Add(lblIsletmeAdi);
            Controls.Add(lblID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblIsletme);
            Controls.Add(dataGridView1);
            Name = "FormEmlak";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmlak";
            Load += FormEmlak_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblIsletme;
        private Button button1;
        private Button button2;
        private Label lblID;
        private Label lblIsletmeAdi;
        private Label lblIsletmeSahibi;
        private Label lblEmlakci;
        private Label lblEmlakci2;
        private Label lblIsletmeSahibi2;
        private Label lblIsletmeAdi2;
        private Label lblID2;
        private Label lblFiyat2;
        private Label lblFiyat;
    }
}