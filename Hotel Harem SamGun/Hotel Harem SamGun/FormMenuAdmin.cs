using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Harem_SamGun
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = $"Welcome,\n{FormLogin.dtKaryawan.Rows[0][1]}!";
            btnLogout.BackColor = System.Drawing.ColorTranslator.FromHtml("#f7a13e");
            btnLogout.ForeColor = Color.White;
        }

        private void btDataResepsionis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataResepsionis form = new FormDataResepsionis();
            form.ShowDialog();
            this.Show();
        }

        private void btDataMenuMakanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataMenuMakanan form = new FormDataMenuMakanan();
            form.ShowDialog();
            this.Show();
        }

        private void btDataKamar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataKamar form = new FormDataKamar();
            form.ShowDialog();
            this.Show();
        }

        private void btDataFasilitasTambahanKamar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataTambahanFasilitasKamar form = new FormDataTambahanFasilitasKamar();
            form.ShowDialog();
            this.Show();
        }

        private void btLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaporan form = new FormLaporan();
            form.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJenisMakanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataJenisMakanan form = new FormDataJenisMakanan();
            form.ShowDialog();
            this.Show();
        }

        private void btnJenisKamar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataJenisKamar form = new FormDataJenisKamar();
            form.ShowDialog();
            this.Show();
        }
    }
}
