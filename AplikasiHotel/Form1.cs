using System;
using System.Windows.Forms;

namespace AplikasiHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
            lnkRegistrasi.LinkClicked += lnkRegistrasi_LinkClicked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
            {
                DataBookingForm halamanTabel = new DataBookingForm();
                halamanTabel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!\n(Gunakan: admin / 12345)", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegistrasi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Silakan hubungi admin untuk pendaftaran akun resepsionis.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}