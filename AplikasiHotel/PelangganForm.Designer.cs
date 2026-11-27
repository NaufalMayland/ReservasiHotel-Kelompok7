namespace AplikasiHotel
{
    partial class PelangganForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblNIK = new System.Windows.Forms.Label();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.lblJenisKelamin = new System.Windows.Forms.Label();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblJudul.Location = new System.Drawing.Point(40, 28);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(440, 32);
            this.lblJudul.TabIndex = 14;
            this.lblJudul.Text = "Form Data Pelanggan";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNIK
            // 
            this.lblNIK.AutoSize = true;
            this.lblNIK.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNIK.Location = new System.Drawing.Point(40, 75);
            this.lblNIK.Name = "lblNIK";
            this.lblNIK.Size = new System.Drawing.Size(42, 21);
            this.lblNIK.TabIndex = 13;
            this.lblNIK.Text = "NIK :";
            // 
            // txtNIK
            // 
            this.txtNIK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNIK.Location = new System.Drawing.Point(40, 96);
            this.txtNIK.MaxLength = 16;
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(440, 30);
            this.txtNIK.TabIndex = 0;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNama.Location = new System.Drawing.Point(40, 138);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(122, 21);
            this.lblNama.TabIndex = 12;
            this.lblNama.Text = "Nama Lengkap :";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaLengkap.Location = new System.Drawing.Point(40, 159);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(440, 30);
            this.txtNamaLengkap.TabIndex = 1;
            // 
            // lblJenisKelamin
            // 
            this.lblJenisKelamin.AutoSize = true;
            this.lblJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblJenisKelamin.Location = new System.Drawing.Point(40, 201);
            this.lblJenisKelamin.Name = "lblJenisKelamin";
            this.lblJenisKelamin.Size = new System.Drawing.Size(111, 21);
            this.lblJenisKelamin.TabIndex = 11;
            this.lblJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJenisKelamin.Location = new System.Drawing.Point(40, 222);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(440, 31);
            this.cmbJenisKelamin.TabIndex = 2;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAlamat.Location = new System.Drawing.Point(40, 264);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(66, 21);
            this.lblAlamat.TabIndex = 10;
            this.lblAlamat.Text = "Alamat :";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAlamat.Location = new System.Drawing.Point(40, 285);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(440, 30);
            this.txtAlamat.TabIndex = 3;
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTelepon.Location = new System.Drawing.Point(40, 327);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(98, 21);
            this.lblTelepon.TabIndex = 9;
            this.lblTelepon.Text = "No. Telepon :";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelepon.Location = new System.Drawing.Point(40, 348);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(440, 30);
            this.txtTelepon.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.Location = new System.Drawing.Point(40, 390);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(40, 411);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(40, 463);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(210, 38);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(270, 463);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(210, 38);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // PelangganForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(520, 533);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.lblTelepon);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.lblJenisKelamin);
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNIK);
            this.Controls.Add(this.lblNIK);
            this.Controls.Add(this.lblJudul);
            this.Name = "PelangganForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Entri Pelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNIK;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label lblJenisKelamin;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}