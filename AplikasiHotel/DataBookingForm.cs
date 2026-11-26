using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplikasiHotel
{
    public partial class DataBookingForm : Form
    {
        private int idBerikutnya = 50;

        public DataBookingForm()
        {
            InitializeComponent();
            SiapkanTabel();
            IsiDataAwal();

            btnTambah.Click += btnTambah_Click;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void SiapkanTabel()
        {
            dgvDataBooking.Columns.Clear();
            dgvDataBooking.Columns.Add("ID", "ID");
            dgvDataBooking.Columns.Add("NamaTamu", "Nama Tamu");
            dgvDataBooking.Columns.Add("TipeKamar", "Tipe Kamar");
            dgvDataBooking.Columns.Add("NomorKamar", "Nomor Kamar");
            dgvDataBooking.Columns.Add("CheckIn", "Check-in");
            dgvDataBooking.Columns.Add("CheckOut", "Check-out");
            dgvDataBooking.Columns.Add("TotalHarga", "Total Harga");
            dgvDataBooking.Columns.Add("Keterangan", "Keterangan");

            dgvDataBooking.Columns["ID"].FillWeight = 45;
            dgvDataBooking.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBooking.Columns["TipeKamar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBooking.Columns["NomorKamar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBooking.Columns["CheckIn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBooking.Columns["CheckOut"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBooking.Columns["TotalHarga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDataBooking.Columns["Keterangan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDataBooking.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 88, 88);
            dgvDataBooking.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDataBooking.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvDataBooking.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDataBooking.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvDataBooking.DefaultCellStyle.BackColor = Color.White;
            dgvDataBooking.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 244, 247);
        }

        private void IsiDataAwal()
        {
            dgvDataBooking.Rows.Add("40", "zaky", "2", "6", "2024-05-13", "2024-05-16", "2250000", "sudah reservasi");
            dgvDataBooking.Rows.Add("41", "zakym", "3", "9", "2024-05-13", "2024-05-21", "7200000", "sudah reservasi");
            dgvDataBooking.Rows.Add("42", "gus", "5", "1", "2024-05-13", "2024-05-15", "1000000", "sudah reservasi");
            dgvDataBooking.Rows.Add("43", "fadil", "5", "2", "2024-05-13", "2024-05-14", "500000", "sudah reservasi");
            dgvDataBooking.Rows.Add("44", "jen", "2", "5", "2024-05-14", "2024-05-15", "750000", "sudah reservasi");
            dgvDataBooking.Rows.Add("45", "qw", "2", "7", "2024-05-14", "2024-05-16", "1500000", "sudah reservasi");
            dgvDataBooking.Rows.Add("47", "anip", "4", "16", "2024-05-16", "2024-05-17", "1000000", "sudah reservasi");
            dgvDataBooking.Rows.Add("48", "poiii", "2", "8", "2024-05-15", "2024-05-16", "750000", "sudah reservasi");
            dgvDataBooking.Rows.Add("49", "ihhi", "3", "10", "2024-05-15", "2024-05-17", "1800000", "sudah reservasi");
        }

        public void TambahBarisBooking(string namaTamu, string tipeKamar, string nomorKamar, string checkIn, string checkOut, string totalHarga)
        {
            dgvDataBooking.Rows.Add(
                idBerikutnya.ToString(),
                namaTamu,
                tipeKamar,
                nomorKamar,
                checkIn,
                checkOut,
                totalHarga,
                "sudah reservasi"
            );
            idBerikutnya++;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Masuk ke Form Data Pelanggan terlebih dahulu
            PelangganForm formPelanggan = new PelangganForm(this);
            formPelanggan.Show();
            this.Hide();
        }

        private void DataBookingForm_Load_1(object sender, EventArgs e) { }
    }
}