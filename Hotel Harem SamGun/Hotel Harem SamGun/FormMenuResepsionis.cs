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
    public partial class FormMenuResepsionis : Form
    {
        public FormMenuResepsionis()
        {
            InitializeComponent();
        }

        private void FormMenuResepsionis_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = $"Welcome,\n{FormLogin.dtKaryawan.Rows[0][1]}!";
        }

        private void btReservasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReservasi form = new FormReservasi();
            form.ShowDialog();
            this.Show();
        }

        private void btPenambahanFasilitasKamar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPenambahanFasilitasDataTamu form = new FormPenambahanFasilitasDataTamu();
            form.ShowDialog();
            this.Show();
        }

        private void btPemesananMakanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPemesananMakanan form = new FormPemesananMakanan();
            form.ShowDialog();
            this.Show();
        }

        private void btCheckInCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCheckInOut form = new FormCheckInOut();
            form.ShowDialog();
            this.Show();
        }
    }
}