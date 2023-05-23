namespace MetaLand.UI
{
    partial class FormIsletme
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
            lblIsletmeAdi = new Label();
            textBox1 = new TextBox();
            lblSahip1 = new Label();
            lblTarih1 = new Label();
            lblCalisan1 = new Label();
            lblKapasite1 = new Label();
            lblKapasite2 = new Label();
            lblCalisan2 = new Label();
            lblTarih2 = new Label();
            lblSahip2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblIsletmeAdi
            // 
            lblIsletmeAdi.BackColor = Color.Transparent;
            lblIsletmeAdi.Font = new Font("Segoe Script", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblIsletmeAdi.ForeColor = SystemColors.ControlLightLight;
            lblIsletmeAdi.Location = new Point(3, 9);
            lblIsletmeAdi.Name = "lblIsletmeAdi";
            lblIsletmeAdi.Size = new Size(310, 88);
            lblIsletmeAdi.TabIndex = 0;
            lblIsletmeAdi.Text = "label1";
            lblIsletmeAdi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 129);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Adet Giriniz";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // lblSahip1
            // 
            lblSahip1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSahip1.Location = new Point(3, 244);
            lblSahip1.Name = "lblSahip1";
            lblSahip1.Size = new Size(177, 20);
            lblSahip1.TabIndex = 3;
            lblSahip1.Text = "İşletme Sahibi: ";
            lblSahip1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTarih1
            // 
            lblTarih1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarih1.Location = new Point(3, 295);
            lblTarih1.Name = "lblTarih1";
            lblTarih1.Size = new Size(177, 20);
            lblTarih1.TabIndex = 4;
            lblTarih1.Text = "Seviye Başlangıç Tarihi: ";
            lblTarih1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCalisan1
            // 
            lblCalisan1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalisan1.Location = new Point(3, 344);
            lblCalisan1.Name = "lblCalisan1";
            lblCalisan1.Size = new Size(177, 20);
            lblCalisan1.TabIndex = 5;
            lblCalisan1.Text = "Çalışan Sayısı: ";
            lblCalisan1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblKapasite1
            // 
            lblKapasite1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblKapasite1.Location = new Point(3, 395);
            lblKapasite1.Name = "lblKapasite1";
            lblKapasite1.Size = new Size(177, 20);
            lblKapasite1.TabIndex = 6;
            lblKapasite1.Text = "Maksimum Kapasite: ";
            lblKapasite1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblKapasite2
            // 
            lblKapasite2.Location = new Point(173, 395);
            lblKapasite2.Name = "lblKapasite2";
            lblKapasite2.Size = new Size(138, 20);
            lblKapasite2.TabIndex = 10;
            lblKapasite2.Text = " .";
            // 
            // lblCalisan2
            // 
            lblCalisan2.Location = new Point(173, 344);
            lblCalisan2.Name = "lblCalisan2";
            lblCalisan2.Size = new Size(138, 20);
            lblCalisan2.TabIndex = 9;
            lblCalisan2.Text = " .";
            // 
            // lblTarih2
            // 
            lblTarih2.Location = new Point(173, 295);
            lblTarih2.Name = "lblTarih2";
            lblTarih2.Size = new Size(138, 20);
            lblTarih2.TabIndex = 8;
            lblTarih2.Text = " .";
            // 
            // lblSahip2
            // 
            lblSahip2.Location = new Point(173, 244);
            lblSahip2.Name = "lblSahip2";
            lblSahip2.Size = new Size(138, 20);
            lblSahip2.TabIndex = 7;
            lblSahip2.Text = " .";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(103, 184);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 11;
            button1.Text = "Ürün SatınAl";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormIsletme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 481);
            Controls.Add(button1);
            Controls.Add(lblKapasite2);
            Controls.Add(lblCalisan2);
            Controls.Add(lblTarih2);
            Controls.Add(lblSahip2);
            Controls.Add(lblKapasite1);
            Controls.Add(lblCalisan1);
            Controls.Add(lblTarih1);
            Controls.Add(lblSahip1);
            Controls.Add(textBox1);
            Controls.Add(lblIsletmeAdi);
            Name = "FormIsletme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIsletme";
            Load += FormIsletme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIsletmeAdi;
        private TextBox textBox1;
        private Label lblSahip1;
        private Label lblTarih1;
        private Label lblCalisan1;
        private Label lblKapasite1;
        private Label lblKapasite2;
        private Label lblCalisan2;
        private Label lblTarih2;
        private Label lblSahip2;
        private Button button1;
    }
}