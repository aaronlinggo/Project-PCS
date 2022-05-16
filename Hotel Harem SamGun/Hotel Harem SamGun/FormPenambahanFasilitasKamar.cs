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
    public partial class FormPenambahanFasilitasKamar : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        DataTable dt;
        int id_reservasi;
        FormPenambahanFasilitasDataTamu formLama;
        public FormPenambahanFasilitasKamar(FormPenambahanFasilitasDataTamu formLama)
        {
            Koneksi.openConn();
            conn = Koneksi.conn;
            InitializeComponent();
            this.formLama = formLama;
            id_reservasi = formLama.id_reservasi;
            isiKodeReservasidanNamaTamu();
            refreshDGV();
        }


        public void isiKodeReservasidanNamaTamu()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT kode_reservasi FROM reservasi WHERE id_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblKodeReservasi.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = $"SELECT nama_tamu FROM reservasi r JOIN tamu t ON t.kode_tamu = r.kode_tamu WHERE id_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblNamaTamu.Text = cmd.ExecuteScalar().ToString();
        }

        public void refreshDGV()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id_extra_fasilitas, nama_extra_fasilitas, stok_extra_fasilitas, harga_extra_fasilitas FROM extra_fasilitas WHERE status_extra_fasilitas = 1";
            dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvFasilitas.DataSource = dt;
            dgvFasilitas.Columns[0].HeaderText = "ID";
            dgvFasilitas.Columns[1].HeaderText = "Nama Fasilitas";
            dgvFasilitas.Columns[2].HeaderText = "Stok";
            dgvFasilitas.Columns[3].HeaderText = "Harga";
            dgvFasilitas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFasilitas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            formLama.Show();
        }
    }
}
