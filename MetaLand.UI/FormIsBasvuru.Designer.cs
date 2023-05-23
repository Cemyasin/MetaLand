namespace MetaLand.UI
{
    partial class FormIsBasvuru
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
            btnTeklif = new Button();
            btnKbl = new Button();
            txtTeklif = new TextBox();
            SuspendLayout();
            // 
            // btnTeklif
            // 
            btnTeklif.Location = new Point(27, 98);
            btnTeklif.Name = "btnTeklif";
            btnTeklif.Size = new Size(90, 40);
            btnTeklif.TabIndex = 0;
            btnTeklif.Text = "Teklif Yap";
            btnTeklif.UseVisualStyleBackColor = true;
            btnTeklif.Click += btnTeklif_Click;
            // 
            // btnKbl
            // 
            btnKbl.Location = new Point(141, 98);
            btnKbl.Name = "btnKbl";
            btnKbl.Size = new Size(90, 40);
            btnKbl.TabIndex = 1;
            btnKbl.Text = "İşe Gir";
            btnKbl.UseVisualStyleBackColor = true;
            btnKbl.Click += btnKbl_Click;
            // 
            // txtTeklif
            // 
            txtTeklif.Location = new Point(80, 36);
            txtTeklif.Name = "txtTeklif";
            txtTeklif.Size = new Size(114, 23);
            txtTeklif.TabIndex = 2;
            // 
            // FormIsBasvuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 160);
            Controls.Add(txtTeklif);
            Controls.Add(btnKbl);
            Controls.Add(btnTeklif);
            Name = "FormIsBasvuru";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIsBasvuru";
            Load += FormIsBasvuru_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTeklif;
        private Button btnKbl;
        private TextBox txtTeklif;
    }
}