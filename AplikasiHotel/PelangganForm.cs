using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplikasiHotel
{
    public partial class PelangganForm : Form
    {
        private DataBookingForm formTabel;

        public PelangganForm(DataBookingForm indukTabel)
        {
            InitializeComponent();
            this.formTabel = indukTabel;

            SiapkanForm();
            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;
            this.FormClosed += (s, e) => formTabel.Show();
        }

        private void SiapkanForm()
        {
            cmbJenisKelamin.Items.Clear();
            cmbJenisKelamin.Items.Add("Pilih Jenis Kelamin");
            cmbJenisKelamin.Items.Add("Laki-laki");
            cmbJenisKelamin.Items.Add("Perempuan");
            cmbJenisKelamin.SelectedIndex = 0;

            PasangPlaceholder(txtNamaLengkap, "Nama sesuai KTP");
            PasangPlaceholder(txtAlamat, "Alamat lengkap pelanggan");
            PasangPlaceholder(txtTelepon, "Contoh: 081234567890");
            PasangPlaceholder(txtEmail, "Contoh: nama@email.com");
        }

        private void PasangPlaceholder(TextBox tb, string teksPlaceholder)
        {
            tb.Text = teksPlaceholder;
            tb.ForeColor = Color.Gray;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == teksPlaceholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = teksPlaceholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool namaKosong = string.IsNullOrWhiteSpace(txtNamaLengkap.Text) || txtNamaLengkap.ForeColor == Color.Gray;

            if (namaKosong || cmbJenisKelamin.SelectedIndex == 0)
            {
                MessageBox.Show("Harap lengkapi Nama Lengkap dan Jenis Kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BookingForm resepsionisForm = new BookingForm(formTabel, txtNamaLengkap.Text);
            resepsionisForm.Show();
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            formTabel.Show();
            this.Hide();
        }

        private void txtNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}