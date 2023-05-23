namespace MetaLand.UI
{
    partial class FormEmlakTeklif
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
            button2 = new Button();
            txtTeklif = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 100);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 0;
            button1.Text = "Teklif Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReddet
            // 
            button2.Location = new Point(170, 100);
            button2.Name = "btnReddet";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 1;
            button2.Text = "Satın Al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTeklif
            // 
            txtTeklif.Location = new Point(106, 47);
            txtTeklif.Name = "txtTeklif";
            txtTeklif.Size = new Size(100, 23);
            txtTeklif.TabIndex = 2;
            txtTeklif.KeyPress += txtTeklif_KeyPress;
            // 
            // FormEmlakTeklif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 162);
            Controls.Add(txtTeklif);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormEmlakTeklif";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmlakTeklif";
            Load += FormEmlakTeklif_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtTeklif;
    }
}