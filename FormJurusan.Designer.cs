namespace LatihanGithub
{
    partial class FormJurusan
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
            this.txbKodeJurusan = new System.Windows.Forms.TextBox();
            this.txbJurusan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbKodeJurusan
            // 
            this.txbKodeJurusan.Location = new System.Drawing.Point(269, 49);
            this.txbKodeJurusan.Name = "txbKodeJurusan";
            this.txbKodeJurusan.Size = new System.Drawing.Size(163, 20);
            this.txbKodeJurusan.TabIndex = 0;
            this.txbKodeJurusan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbJurusan
            // 
            this.txbJurusan.Location = new System.Drawing.Point(32, 49);
            this.txbJurusan.Name = "txbJurusan";
            this.txbJurusan.Size = new System.Drawing.Size(117, 20);
            this.txbJurusan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(42, 116);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(42, 145);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kode Jurusan";
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbJurusan);
            this.Controls.Add(this.txbKodeJurusan);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            this.Load += new System.EventHandler(this.FormJurusan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbKodeJurusan;
        private System.Windows.Forms.TextBox txbJurusan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label2;
    }
}