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
            this.lblJurusan = new System.Windows.Forms.Label();
            this.cmbJurusan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(29, 25);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(81, 13);
            this.lblJurusan.TabIndex = 0;
            this.lblJurusan.Text = "Nama Jurusan :";
            this.lblJurusan.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbJurusan
            // 
            this.cmbJurusan.FormattingEnabled = true;
            this.cmbJurusan.Items.AddRange(new object[] {
            "Rekayasa Perangkat Lunak",
            "TKKR",
            "Kimia",
            "ULW",
            "Hotel",
            "Akutansi"});
            this.cmbJurusan.Location = new System.Drawing.Point(116, 25);
            this.cmbJurusan.Name = "cmbJurusan";
            this.cmbJurusan.Size = new System.Drawing.Size(121, 21);
            this.cmbJurusan.TabIndex = 1;
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 332);
            this.Controls.Add(this.cmbJurusan);
            this.Controls.Add(this.lblJurusan);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.ComboBox cmbJurusan;
    }
}