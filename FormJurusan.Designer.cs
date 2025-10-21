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
            this.lblNamaJurusan = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.lblKodeJurusan = new System.Windows.Forms.Label();
            this.dgvJurusan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurusan)).BeginInit();
            this.SuspendLayout();
            // 
            // txbKodeJurusan
            // 
            this.txbKodeJurusan.Location = new System.Drawing.Point(142, 21);
            this.txbKodeJurusan.Name = "txbKodeJurusan";
            this.txbKodeJurusan.Size = new System.Drawing.Size(117, 20);
            this.txbKodeJurusan.TabIndex = 0;
            this.txbKodeJurusan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbJurusan
            // 
            this.txbJurusan.Location = new System.Drawing.Point(142, 52);
            this.txbJurusan.Name = "txbJurusan";
            this.txbJurusan.Size = new System.Drawing.Size(174, 20);
            this.txbJurusan.TabIndex = 1;
            // 
            // lblNamaJurusan
            // 
            this.lblNamaJurusan.AutoSize = true;
            this.lblNamaJurusan.Location = new System.Drawing.Point(32, 52);
            this.lblNamaJurusan.Name = "lblNamaJurusan";
            this.lblNamaJurusan.Size = new System.Drawing.Size(44, 13);
            this.lblNamaJurusan.TabIndex = 2;
            this.lblNamaJurusan.Text = "Jurusan";
            this.lblNamaJurusan.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(29, 93);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(29, 122);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // lblKodeJurusan
            // 
            this.lblKodeJurusan.AutoSize = true;
            this.lblKodeJurusan.Location = new System.Drawing.Point(32, 21);
            this.lblKodeJurusan.Name = "lblKodeJurusan";
            this.lblKodeJurusan.Size = new System.Drawing.Size(72, 13);
            this.lblKodeJurusan.TabIndex = 5;
            this.lblKodeJurusan.Text = "Kode Jurusan";
            // 
            // dgvJurusan
            // 
            this.dgvJurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJurusan.Location = new System.Drawing.Point(142, 105);
            this.dgvJurusan.Name = "dgvJurusan";
            this.dgvJurusan.Size = new System.Drawing.Size(251, 152);
            this.dgvJurusan.TabIndex = 6;
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 332);
            this.Controls.Add(this.dgvJurusan);
            this.Controls.Add(this.lblKodeJurusan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblNamaJurusan);
            this.Controls.Add(this.txbJurusan);
            this.Controls.Add(this.txbKodeJurusan);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            this.Load += new System.EventHandler(this.FormJurusan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurusan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbKodeJurusan;
        private System.Windows.Forms.TextBox txbJurusan;
        private System.Windows.Forms.Label lblNamaJurusan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label lblKodeJurusan;
        private System.Windows.Forms.DataGridView dgvJurusan;
    }
}