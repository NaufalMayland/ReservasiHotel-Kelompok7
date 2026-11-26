namespace AplikasiHotel
{
    partial class BookingForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPembayaran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTotalBayar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNomorKamar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipeKamar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaTamu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(278, -3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(323, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Resepsionis Form";
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtKembalian);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.txtPembayaran);
            this.pnlContainer.Controls.Add(this.label8);
            this.pnlContainer.Controls.Add(this.btnSubmit);
            this.pnlContainer.Controls.Add(this.txtTotalBayar);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.dtpCheckOut);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Controls.Add(this.dtpCheckIn);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.cmbNomorKamar);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.cmbTipeKamar);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.txtNamaTamu);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Location = new System.Drawing.Point(23, 54);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(756, 557);
            this.pnlContainer.TabIndex = 1;
            // 
            // txtKembalian
            // 
            this.txtKembalian.Location = new System.Drawing.Point(27, 429);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(712, 26);
            this.txtKembalian.TabIndex = 16;
            this.txtKembalian.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kembalian :";
            // 
            // txtPembayaran
            // 
            this.txtPembayaran.Location = new System.Drawing.Point(27, 367);
            this.txtPembayaran.Name = "txtPembayaran";
            this.txtPembayaran.Size = new System.Drawing.Size(712, 26);
            this.txtPembayaran.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pembayaran : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Olive;
            this.btnSubmit.Location = new System.Drawing.Point(27, 488);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(712, 54);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Selanjutnya";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.Location = new System.Drawing.Point(27, 315);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.Size = new System.Drawing.Size(712, 26);
            this.txtTotalBayar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Pembayaran:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(21, 253);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(718, 26);
            this.dtpCheckOut.TabIndex = 9;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tanggal Check-Out";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(21, 201);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(718, 26);
            this.dtpCheckIn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Check-In";
            // 
            // cmbNomorKamar
            // 
            this.cmbNomorKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomorKamar.FormattingEnabled = true;
            this.cmbNomorKamar.Location = new System.Drawing.Point(21, 147);
            this.cmbNomorKamar.Name = "cmbNomorKamar";
            this.cmbNomorKamar.Size = new System.Drawing.Size(718, 28);
            this.cmbNomorKamar.TabIndex = 5;
            this.cmbNomorKamar.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nomor Kamar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbTipeKamar
            // 
            this.cmbTipeKamar.FormattingEnabled = true;
            this.cmbTipeKamar.Location = new System.Drawing.Point(21, 93);
            this.cmbTipeKamar.Name = "cmbTipeKamar";
            this.cmbTipeKamar.Size = new System.Drawing.Size(718, 28);
            this.cmbTipeKamar.TabIndex = 3;
            this.cmbTipeKamar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipe  Kamar:";
            // 
            // txtNamaTamu
            // 
            this.txtNamaTamu.Location = new System.Drawing.Point(21, 41);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.Size = new System.Drawing.Size(718, 26);
            this.txtNamaTamu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Tamu:";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblHeader);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipeKamar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaTamu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPembayaran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbNomorKamar;
        private System.Windows.Forms.Panel pnlContainer;
    }
}