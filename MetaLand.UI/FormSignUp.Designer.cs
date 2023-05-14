namespace MetaLand.UI
{
    partial class FormSignUp
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
            txtNickName = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(100, 86);
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "Kullanıcı Adı";
            txtNickName.Size = new Size(204, 23);
            txtNickName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(100, 131);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "İsim";
            txtFirstName.Size = new Size(204, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(100, 175);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyisim";
            txtLastName.Size = new Size(204, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new Size(204, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(147, 281);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(92, 40);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Kayıt Ol";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 370);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtNickName);
            Name = "FormSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNickName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private Button btnSignUp;
    }


}