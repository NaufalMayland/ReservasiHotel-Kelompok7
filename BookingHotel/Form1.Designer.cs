namespace BookingHotel
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPembayaran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.lblHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(285, -2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(177, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Booking Form";
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContainer.Controls.Add(this.btnSubmit);
            this.pnlContainer.Controls.Add(this.txtKembalian);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.txtPembayaran);
            this.pnlContainer.Controls.Add(this.label8);
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
            this.pnlContainer.Location = new System.Drawing.Point(12, 41);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(776, 541);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Olive;
            this.btnSubmit.Location = new System.Drawing.Point(18, 475);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(743, 38);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // txtKembalian
            // 
            this.txtKembalian.Location = new System.Drawing.Point(18, 424);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(743, 26);
            this.txtKembalian.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kembalian : ";
            // 
            // txtPembayaran
            // 
            this.txtPembayaran.Location = new System.Drawing.Point(14, 363);
            this.txtPembayaran.Name = "txtPembayaran";
            this.txtPembayaran.Size = new System.Drawing.Size(747, 26);
            this.txtPembayaran.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pembayaran : ";
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.Location = new System.Drawing.Point(18, 297);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.Size = new System.Drawing.Size(743, 26);
            this.txtTotalBayar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Pembayaran : ";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(14, 245);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(747, 26);
            this.dtpCheckOut.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tanggal Check-Out : ";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(14, 193);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(747, 26);
            this.dtpCheckIn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Check-in :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbNomorKamar
            // 
            this.cmbNomorKamar.FormattingEnabled = true;
            this.cmbNomorKamar.Location = new System.Drawing.Point(14, 139);
            this.cmbNomorKamar.Name = "cmbNomorKamar";
            this.cmbNomorKamar.Size = new System.Drawing.Size(747, 28);
            this.cmbNomorKamar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nomor Kamar :";
            // 
            // cmbTipeKamar
            // 
            this.cmbTipeKamar.FormattingEnabled = true;
            this.cmbTipeKamar.Location = new System.Drawing.Point(14, 85);
            this.cmbTipeKamar.Name = "cmbTipeKamar";
            this.cmbTipeKamar.Size = new System.Drawing.Size(747, 28);
            this.cmbTipeKamar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipe Kamar : ";
            // 
            // txtNamaTamu
            // 
            this.txtNamaTamu.Location = new System.Drawing.Point(14, 33);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.Size = new System.Drawing.Size(747, 26);
            this.txtNamaTamu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Tamu : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipeKamar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaTamu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNomorKamar;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPembayaran;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.Label label9;
    }
}

