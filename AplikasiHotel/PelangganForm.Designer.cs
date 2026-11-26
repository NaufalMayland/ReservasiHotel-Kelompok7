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

            // lblJudul
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular);
            this.lblJudul.Location = new System.Drawing.Point(40, 28);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(440, 32);
            this.lblJudul.Text = "Form Data Pelanggan";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNama & txtNamaLengkap
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNama.Location = new System.Drawing.Point(40, 75);
            this.lblNama.Text = "Nama Lengkap :";

            this.txtNamaLengkap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaLengkap.Location = new System.Drawing.Point(40, 96);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(440, 25);

            // lblJenisKelamin & cmbJenisKelamin
            this.lblJenisKelamin.AutoSize = true;
            this.lblJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblJenisKelamin.Location = new System.Drawing.Point(40, 138);
            this.lblJenisKelamin.Text = "Jenis Kelamin :";

            this.cmbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJenisKelamin.Location = new System.Drawing.Point(40, 159);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(440, 25);

            // lblAlamat & txtAlamat
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAlamat.Location = new System.Drawing.Point(40, 201);
            this.lblAlamat.Text = "Alamat :";

            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAlamat.Location = new System.Drawing.Point(40, 222);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(440, 25);

            // lblTelepon & txtTelepon
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTelepon.Location = new System.Drawing.Point(40, 264);
            this.lblTelepon.Text = "No. Telepon :";

            this.txtTelepon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelepon.Location = new System.Drawing.Point(40, 285);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(440, 25);

            // lblEmail & txtEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.Location = new System.Drawing.Point(40, 327);
            this.lblEmail.Text = "Email :";

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(40, 348);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 25);

            // btnSimpan
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(128, 128, 0);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(40, 400);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(210, 38);
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;

            // btnBatal
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(270, 400);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(210, 38);
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;

            // PelangganForm
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 248);
            this.ClientSize = new System.Drawing.Size(520, 470);
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
            this.Controls.Add(this.lblJudul);
            this.Name = "PelangganForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Entri Pelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblJudul;
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