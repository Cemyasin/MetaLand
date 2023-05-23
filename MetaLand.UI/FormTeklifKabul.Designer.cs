namespace MetaLand.UI
{
    partial class FormTeklifKabul
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
            btnReddet = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(60, 77);
            button1.Name = "button1";
            button1.Size = new Size(76, 28);
            button1.TabIndex = 0;
            button1.Text = "Kabul Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnKbl_Click;
            // 
            // btnReddet
            // 
            btnReddet.BackColor = Color.IndianRed;
            btnReddet.Location = new Point(184, 77);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(76, 28);
            btnReddet.TabIndex = 1;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = false;
            btnReddet.Click += btnReddet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 22);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 2;
            label1.Text = "Teklifi kabul etmek istiyor musunuz ?";
            // 
            // FormTeklifKabul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 127);
            Controls.Add(label1);
            Controls.Add(btnReddet);
            Controls.Add(button1);
            Name = "FormTeklifKabul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTeklifKabul";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnReddet;
        private Label label1;
    }
}