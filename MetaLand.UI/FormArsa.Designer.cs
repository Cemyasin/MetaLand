namespace MetaLand.UI
{
    partial class FormArsa
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
            button1 = new Button();
            lblFiyat = new Label();
            lblTarih = new Label();
            lblId = new Label();
            lblFiyat2 = new Label();
            lblId2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(62, 199);
            button1.Name = "button1";
            button1.Size = new Size(163, 49);
            button1.TabIndex = 0;
            button1.Text = "SATIN AL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblFiyat
            // 
            lblFiyat.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFiyat.Location = new Point(62, 99);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(100, 23);
            lblFiyat.TabIndex = 1;
            lblFiyat.Text = "Fiyat:";
            lblFiyat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarih.Location = new Point(154, 19);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(71, 23);
            lblTarih.TabIndex = 1;
            lblTarih.Text = "Tarih:";
            // 
            // lblId
            // 
            lblId.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblId.Location = new Point(62, 155);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Alan ID:";
            lblId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFiyat2
            // 
            lblFiyat2.AutoSize = true;
            lblFiyat2.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFiyat2.Location = new Point(180, 97);
            lblFiyat2.Name = "lblFiyat2";
            lblFiyat2.Size = new Size(13, 18);
            lblFiyat2.TabIndex = 1;
            lblFiyat2.Text = ".";
            // 
            // lblId2
            // 
            lblId2.AutoSize = true;
            lblId2.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblId2.Location = new Point(180, 152);
            lblId2.Name = "lblId2";
            lblId2.Size = new Size(13, 18);
            lblId2.TabIndex = 1;
            lblId2.Text = ".";
            // 
            // FormArsa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 298);
            Controls.Add(lblId2);
            Controls.Add(lblId);
            Controls.Add(lblTarih);
            Controls.Add(lblFiyat2);
            Controls.Add(lblFiyat);
            Controls.Add(button1);
            Name = "FormArsa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormArsa";
            Load += FormArsa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblFiyat;
        private Label lblTarih;
        private Label lblId;
        private Label lblFiyat2;
        private Label lblId2;
    }
}