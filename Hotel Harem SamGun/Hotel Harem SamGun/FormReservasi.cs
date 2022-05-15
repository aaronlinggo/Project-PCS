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
    public partial class FormReservasi : Form
    {
        int selected;
        DataTable dtReservasi;

        public FormReservasi()
        {
            InitializeComponent();
        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            refreshDGVReservasi();
            changeMode(1);
        }

        private void loadReservasi()
        {
            try
            {
                dtReservasi = new DataTable();
                string query = @"
                    SELECT id_reservasi, kode_reservasi, t.nama_tamu, jk.nama_jenis_kamar, km.nomor_kamar, down_payment, deposito, tanggal_check_in, tanggal_check_out, total_biaya, kr.nama_karyawan
                    FROM reservasi r
                    JOIN tamu t ON t.kode_tamu = r.kode_tamu
                    JOIN kamar km ON km.kode_kamar = r.kode_kamar
                    JOIN jenis_kamar jk ON jk.id_jenis_kamar = km.id_jenis_kamar
                    JOIN karyawan kr ON kr.kode_karyawan = r.kode_karyawan
                    WHERE r.status_reservasi = 1;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, Koneksi.conn);
                da.Fill(dtReservasi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshDGVReservasi()
        {
            loadReservasi();
            dgvReservasi.DataSource = dtReservasi;
            dgvReservasi.Columns[0].HeaderText = "ID";
            dgvReservasi.Columns[0].Width = 100;
            dgvReservasi.Columns[1].HeaderText = "Kode Reservasi";
            dgvReservasi.Columns[2].HeaderText = "Nama Tamu";
            dgvReservasi.Columns[3].HeaderText = "Jenis Kamar";
            dgvReservasi.Columns[4].HeaderText = "Nomor Kamar";
            dgvReservasi.Columns[5].HeaderText = "DP";
            dgvReservasi.Columns[6].HeaderText = "Deposito";
            dgvReservasi.Columns[7].HeaderText = "Tanggal Check In";
            dgvReservasi.Columns[8].HeaderText = "Tanggal Check Out";
            dgvReservasi.Columns[9].HeaderText = "Total Biaya";
            dgvReservasi.Columns[10].HeaderText = "Nama Karyawan";

            //DISABLE SORT
            foreach (DataGridViewColumn col in dgvReservasi.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvReservasi.ClearSelection();
        }

        private void changeMode(int mode)
        {
            if (mode == 1)
            {
                // RESERVASI
                lbKodeReservasi.Text = "-";
                dtpCheckIn.Value = dtpCheckOut.Value = DateTime.Now;
                lbTotalTarifKamar.Text = "Rp 0";
                lbKodeKaryawan.Text = "-";

                btReservasi.Enabled = true;
                btBatal.Enabled = false;
            } else
            {
                // BATAL
                btReservasi.Enabled = false;
                btBatal.Enabled = true;
            }
        }

        private void dgvReservasi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;

            if (selected > -1)
            {
                changeMode(0);

            }
        }

        private void btReservasi_Click(object sender, EventArgs e)
        {

        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                MessageBox.Show("Tanggal Check Out tidak boleh kurang dari Tanggal Check In!");
            }
        }
    }
}