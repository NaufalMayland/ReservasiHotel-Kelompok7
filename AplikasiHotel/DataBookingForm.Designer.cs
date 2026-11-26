namespace AplikasiHotel
{
    partial class DataBookingForm
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.dgvDataBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBooking)).BeginInit();
            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(25, 22);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(172, 30);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "DATA BOOKING";

            // btnTambah
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(845, 20);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(110, 34);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;

            // dgvDataBooking
            this.dgvDataBooking.AllowUserToAddRows = false;
            this.dgvDataBooking.AllowUserToDeleteRows = false;
            this.dgvDataBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataBooking.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataBooking.ColumnHeadersHeight = 42;
            this.dgvDataBooking.EnableHeadersVisualStyles = false;
            this.dgvDataBooking.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvDataBooking.Location = new System.Drawing.Point(25, 70);
            this.dgvDataBooking.Name = "dgvDataBooking";
            this.dgvDataBooking.ReadOnly = true;
            this.dgvDataBooking.RowHeadersVisible = false;
            this.dgvDataBooking.RowTemplate.Height = 36;
            this.dgvDataBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataBooking.Size = new System.Drawing.Size(930, 420);
            this.dgvDataBooking.TabIndex = 2;

            // DataBookingForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 248);
            this.ClientSize = new System.Drawing.Size(980, 520);
            this.Controls.Add(this.dgvDataBooking);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblJudul);
            this.Name = "DataBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Booking Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgvDataBooking;
    }
}