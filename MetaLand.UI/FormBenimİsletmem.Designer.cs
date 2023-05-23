namespace MetaLand.UI
{
    partial class FormBenimİsletmem
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
            label1 = new Label();
            btnBasvuru = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(371, 213);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 86);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "ÇALIŞANLAR";
            // 
            // btnBasvuru
            // 
            btnBasvuru.Location = new Point(591, 345);
            btnBasvuru.Name = "btnBasvuru";
            btnBasvuru.Size = new Size(100, 43);
            btnBasvuru.TabIndex = 2;
            btnBasvuru.Text = "İş Başvuruları";
            btnBasvuru.UseVisualStyleBackColor = true;
            btnBasvuru.Click += btnBasvuru_Click;
            // 
            // FormBenimİsletmem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 419);
            Controls.Add(btnBasvuru);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormBenimİsletmem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBenimİsletmem";
            Load += FormBenimİsletmem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnBasvuru;
    }
}