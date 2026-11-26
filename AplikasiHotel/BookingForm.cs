using System;
using System.Windows.Forms;

namespace AplikasiHotel
{
    public partial class BookingForm : Form
    {
        private decimal hargaPerMalam = 0;
        private DataBookingForm formTabel;

        public BookingForm()
        {
            InitializeComponent();
            InisialisasiForm();
        }

        public BookingForm(DataBookingForm indukTabel, string namaPelanggan) : this()
        {
            this.formTabel = indukTabel;
            txtNamaTamu.Text = namaPelanggan;
        }

        private void InisialisasiForm()
        {
            cmbTipeKamar.Items.Clear();
            cmbTipeKamar.Items.Add("Pilih Tipe Kamar");
            cmbTipeKamar.Items.Add("Standard - Rp 300.000/malam");
            cmbTipeKamar.Items.Add("Deluxe - Rp 500.000/malam");
            cmbTipeKamar.Items.Add("Suite - Rp 850.000/malam");
            cmbTipeKamar.SelectedIndex = 0;

            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.CustomFormat = "yyyy-MM-dd";
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.CustomFormat = "yyyy-MM-dd";
            dtpCheckOut.Value = DateTime.Now.AddDays(1);

            cmbTipeKamar.SelectedIndexChanged += HitungTotalOtomatis;
            dtpCheckIn.ValueChanged += HitungTotalOtomatis;
            dtpCheckOut.ValueChanged += HitungTotalOtomatis;
            txtPembayaran.TextChanged += HitungKembalianOtomatis;
            btnSubmit.Click += btnSubmit_Click;
            this.FormClosed += BookingForm_FormClosed;
        }

        private void HitungTotalOtomatis(object sender, EventArgs e)
        {
            cmbNomorKamar.Items.Clear();

            if (cmbTipeKamar.SelectedIndex == 1)
            {
                hargaPerMalam = 300000;
                cmbNomorKamar.Items.AddRange(new string[] { "101", "102", "103" });
            }
            else if (cmbTipeKamar.SelectedIndex == 2)
            {
                hargaPerMalam = 500000;
                cmbNomorKamar.Items.AddRange(new string[] { "201", "202", "203" });
            }
            else if (cmbTipeKamar.SelectedIndex == 3)
            {
                hargaPerMalam = 850000;
                cmbNomorKamar.Items.AddRange(new string[] { "301", "302" });
            }
            else
            {
                hargaPerMalam = 0;
                txtTotalBayar.Text = "0";
                return;
            }

            if (cmbNomorKamar.Items.Count > 0)
                cmbNomorKamar.SelectedIndex = 0;

            int lamaMenginap = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
            if (lamaMenginap <= 0) lamaMenginap = 1;

            decimal total = hargaPerMalam * lamaMenginap;
            txtTotalBayar.Text = total.ToString("N0");
            HitungKembalianOtomatis(null, null);
        }

        private void HitungKembalianOtomatis(object sender, EventArgs e)
        {
            decimal.TryParse(txtTotalBayar.Text.Replace(".", "").Replace(",", ""), out decimal total);
            decimal.TryParse(txtPembayaran.Text.Replace(".", "").Replace(",", ""), out decimal bayar);

            if (bayar >= total && total > 0)
            {
                decimal kembalian = bayar - total;
                txtKembalian.Text = kembalian.ToString("N0");
            }
            else
            {
                txtKembalian.Text = "0";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtTotalBayar.Text.Replace(".", "").Replace(",", ""), out decimal total);
            decimal.TryParse(txtPembayaran.Text.Replace(".", "").Replace(",", ""), out decimal bayar);

            if (string.IsNullOrWhiteSpace(txtNamaTamu.Text) || cmbTipeKamar.SelectedIndex == 0)
            {
                MessageBox.Show("Harap lengkapi Nama Tamu dan Tipe Kamar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bayar < total)
            {
                MessageBox.Show("Nominal pembayaran kurang dari total tagihan!", "Pembayaran Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (formTabel != null)
            {
                string kodeTipe = cmbTipeKamar.SelectedIndex.ToString();
                string hargaPolos = total.ToString("0");
                formTabel.TambahBarisBooking(
                    txtNamaTamu.Text,
                    kodeTipe,
                    cmbNomorKamar.Text,
                    dtpCheckIn.Text,
                    dtpCheckOut.Text,
                    hargaPolos
                );
            }

            MessageBox.Show($"Reservasi selesai & tersimpan ke tabel!\nKembalian: Rp {txtKembalian.Text}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (formTabel != null)
            {
                formTabel.Show();
                this.Hide();
            }
        }

        private void BookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formTabel != null)
                formTabel.Show();
            else
                Application.Exit();
        }

        private void BookingForm_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}