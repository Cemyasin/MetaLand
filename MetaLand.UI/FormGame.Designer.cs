namespace MetaLand.GUI
{
    partial class FormGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIsIlani = new Button();
            lblInfo = new Label();
            label2 = new Label();
            btnIsletme = new Button();
            SuspendLayout();
            // 
            // btnIsIlani
            // 
            btnIsIlani.Location = new Point(893, 135);
            btnIsIlani.Name = "btnIsIlani";
            btnIsIlani.Size = new Size(130, 49);
            btnIsIlani.TabIndex = 0;
            btnIsIlani.Text = "İş İlanları";
            btnIsIlani.UseVisualStyleBackColor = true;
            btnIsIlani.Click += btnIsIlani_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.Location = new Point(707, 71);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(439, 27);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Kullanıcı Adı: x  Para: xx Esya: xx Yiyecek:xx";
            lblInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(905, 20);
            label2.Name = "label2";
            label2.Size = new Size(165, 34);
            label2.TabIndex = 2;
            label2.Text = "10.05.2023";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // btnIsletme
            // 
            btnIsletme.Location = new Point(893, 232);
            btnIsletme.Name = "btnIsletme";
            btnIsletme.Size = new Size(130, 49);
            btnIsletme.TabIndex = 3;
            btnIsletme.Text = "İşletme ";
            btnIsletme.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 610);
            Controls.Add(btnIsletme);
            Controls.Add(label2);
            Controls.Add(lblInfo);
            Controls.Add(btnIsIlani);
            Name = "FormGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIsIlani;
        private Label lblInfo;
        private Label label2;
        private Button btnIsletme;
    }
}