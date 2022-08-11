using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaLengkap_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ini akan menyebabkan formulir yang anda isi tidak tersimpan ", "Yakin Ingin Keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ini akan menyebabkan formulir yang anda isi tidak tersimpan ", "Yakin Ingin MeReset?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                txtNoPendaftaran.Text = "";
                txtNamaLengkap.Text = "";
                txtAlamatLengkap.Text = "";
                txtNoHPWA.Text = "";
                checkBoxLaki2.Checked = false;
                checkBoxPerempuan.Checked = false;
                txtTempatLahir.Text = "";
                bxTgl.Text = "";
                bxBln.Text = "";
                bxThn.Text = "";
                txtAlamatEmail.Text = "";
                txtTglDaftar.Text = "";
                lblData.Text = "";
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string check = "";
            if (checkBoxLaki2.Checked == true)
                check = checkBoxLaki2.Text;
            else if (checkBoxPerempuan.Checked == true)
                check = checkBoxPerempuan.Text;
            else
                check = "";

            lblData.Text =
                "No Pendaftaran    : " + txtNoPendaftaran.Text + "\n" +
                "Nama Lengkap      : " + txtNamaLengkap.Text + "\n" +
                "Alamat Lengkap    : " + txtAlamatLengkap.Text + "\n" +
                "Nomor Telepon     : " + txtNoHPWA.Text + "\n" +
                "Jenis Kelamin     : " + check + "\n" +
                "Tempat Lahir      : " + txtTempatLahir.Text + "\n" +
                "Tanggal Lahir     : " + bxTgl.Text + bxBln.Text + bxThn.Text + "\n" +
                "Alamat Email      : " + txtAlamatEmail.Text + "\n" +
                "Tanggal Pendaftaran     : " + txtTglDaftar.Text;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            monthCalendar1.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtTglDaftar.Text = monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy");
            monthCalendar1.Show();
        }
    }
}
