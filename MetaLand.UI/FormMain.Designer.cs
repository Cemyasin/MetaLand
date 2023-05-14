namespace MetaLand.UI
{
    partial class FormMain
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
            label1 = new Label();
            btnGiris = new Button();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(267, 63);
            label1.Name = "lblInfo";
            label1.Size = new Size(315, 30);
            label1.TabIndex = 0;
            label1.Text = "METALAND OYUNUNA HG";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(208, 197);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(117, 44);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(447, 197);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(117, 44);
            btnKayit.TabIndex = 2;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 485);
            Controls.Add(btnKayit);
            Controls.Add(btnGiris);
            Controls.Add(label1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGiris;
        private Button btnKayit;
    }
}