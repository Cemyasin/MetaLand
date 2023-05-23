namespace MetaLand.UI
{
    partial class FormProfil
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNickName = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtFood = new TextBox();
            txtItem = new TextBox();
            txtMoney = new TextBox();
            textBox7 = new TextBox();
            lblKayit_tarihi = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(34, 59);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Kulanıcı Adı :";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Location = new Point(34, 91);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "İsim :";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Location = new Point(34, 124);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Soyisim :";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Location = new Point(34, 160);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Yemek :";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.Location = new Point(34, 195);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Eşya :";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Location = new Point(34, 230);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "Para :";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Location = new Point(2, 261);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 6;
            label7.Text = "Mevcut İşletme Sayısı :";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Location = new Point(34, 294);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 7;
            label8.Text = "Kayıt Tarihi :";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(140, 56);
            txtNickName.Name = "txtNickName";
            txtNickName.Size = new Size(100, 23);
            txtNickName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 124);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(140, 157);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(100, 23);
            txtFood.TabIndex = 11;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(140, 195);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(100, 23);
            txtItem.TabIndex = 12;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(140, 227);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(100, 23);
            txtMoney.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(140, 258);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // lblKayit_tarihi
            // 
            lblKayit_tarihi.Location = new Point(140, 294);
            lblKayit_tarihi.Name = "lblKayit_tarihi";
            lblKayit_tarihi.Size = new Size(100, 23);
            lblKayit_tarihi.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(106, 337);
            button1.Name = "button1";
            button1.Size = new Size(134, 36);
            button1.TabIndex = 16;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReddet
            // 
            button2.Location = new Point(106, 399);
            button2.Name = "btnReddet";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 17;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 474);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblKayit_tarihi);
            Controls.Add(textBox7);
            Controls.Add(txtMoney);
            Controls.Add(txtItem);
            Controls.Add(txtFood);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtNickName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNickName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtFood;
        private TextBox txtItem;
        private TextBox txtMoney;
        private TextBox textBox7;
        private Label lblKayit_tarihi;
        private Button button1;
        private Button button2;
    }
}