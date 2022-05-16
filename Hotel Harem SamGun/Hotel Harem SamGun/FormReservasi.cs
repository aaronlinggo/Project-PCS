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
        DataTable dtTamu;
        DataTable dtJenisKamar;
        DataTable dtNomorKamar;

        MySqlDataAdapter da;

        public FormReservasi()
        {
            InitializeComponent();
        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            refreshDGVReservasi();
            loadNamaTamu();
            loadJenisKamar();
            changeMode(1);
        }

        private void fillDT(DataTable dt, string query)
        {
            try
            {
                da = new MySqlDataAdapter(query, Koneksi.conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadReservasi()
        {
            dtReservasi = new DataTable();
            string query = @"
                    SELECT kode_reservasi, t.nama_tamu, jk.nama_jenis_kamar, km.nomor_kamar, down_payment, deposito, jadwal_check_in, jadwal_check_out, tanggal_check_in, tanggal_check_out, total_biaya, kr.nama_karyawan, status_reservasi
                    FROM reservasi r
                    JOIN tamu t ON t.kode_tamu = r.kode_tamu
                    JOIN kamar km ON km.kode_kamar = r.kode_kamar
                    JOIN jenis_kamar jk ON jk.id_jenis_kamar = km.id_jenis_kamar
                    JOIN karyawan kr ON kr.kode_karyawan = r.kode_karyawan";
            fillDT(dtReservasi, query);
        }

        private void refreshDGVReservasi()
        {
            loadReservasi();
            dgvReservasi.DataSource = dtReservasi;
            dgvReservasi.Columns[0].HeaderText = "Kode Reservasi";
            dgvReservasi.Columns[1].HeaderText = "Nama Tamu";
            dgvReservasi.Columns[2].HeaderText = "Jenis Kamar";
            dgvReservasi.Columns[3].HeaderText = "Nomor Kamar";
            dgvReservasi.Columns[4].HeaderText = "DP";
            dgvReservasi.Columns[5].HeaderText = "Deposito";
            dgvReservasi.Columns[6].HeaderText = "Jadwal Check In";
            dgvReservasi.Columns[7].HeaderText = "Jadwal Check Out";
            dgvReservasi.Columns[8].HeaderText = "Tanggal Check In";
            dgvReservasi.Columns[9].HeaderText = "Tanggal Check Out";
            dgvReservasi.Columns[10].HeaderText = "Total Biaya";
            dgvReservasi.Columns[11].HeaderText = "Nama Karyawan";
            dgvReservasi.Columns[12].HeaderText = "Status Reservasi";

            //DISABLE SORT
            foreach (DataGridViewColumn col in dgvReservasi.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvReservasi.ClearSelection();
        }

        private void loadNamaTamu()
        {
            dtTamu = new DataTable();
            string query = "SELECT kode_tamu, nama_tamu FROM tamu WHERE status_tamu = 1";
            fillDT(dtTamu, query);
            cbNamaTamu.DataSource = dtTamu;
            cbNamaTamu.DisplayMember = "nama_tamu";
            cbNamaTamu.ValueMember = "kode_tamu";
        }

        private void loadJenisKamar()
        {
            dtJenisKamar = new DataTable();
            string query = "SELECT id_jenis_kamar, nama_jenis_kamar FROM jenis_kamar WHERE status_jenis_kamar = 1";
            fillDT(dtJenisKamar, query);
            cbJenisKamar.DataSource = dtJenisKamar;
            cbJenisKamar.DisplayMember = "nama_jenis_kamar";
            cbJenisKamar.ValueMember = "id_jenis_kamar";
        }

        private void loadNomorKamar()
        {
            dtNomorKamar = new DataTable();
            string query = $"SELECT kode_kamar, nomor_kamar FROM kamar WHERE status_kamar = 1 AND id_jenis_kamar = {Convert.ToInt32(dtJenisKamar.Rows[cbJenisKamar.SelectedIndex][0])}";
            fillDT(dtNomorKamar, query);
            cbNomorKamar.DataSource = dtNomorKamar;
            cbNomorKamar.DisplayMember = "nomor_kamar";
            cbNomorKamar.ValueMember = "kode_kamar";
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
                dtpCheckOut.Value = dtpCheckIn.Value;
            }
        }

        private void tbDownPayment_TextChanged(object sender, EventArgs e)
        {
            if (tbDownPayment.Text.Length > 0)
            {
                char temp = tbDownPayment.Text[(tbDownPayment.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbDownPayment.Text = tbDownPayment.Text.Remove(tbDownPayment.Text.Length - 1, 1);
                    tbDownPayment.SelectionStart = tbDownPayment.Text.Length;
                }
            }
        }

        private void tbDeposito_TextChanged(object sender, EventArgs e)
        {
            if (tbDeposito.Text.Length > 0)
            {
                char temp = tbDeposito.Text[(tbDeposito.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbDeposito.Text = tbDeposito.Text.Remove(tbDeposito.Text.Length - 1, 1);
                    tbDeposito.SelectionStart = tbDeposito.Text.Length;
                }
            }
        }

        private void cbJenisKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNomorKamar();
        }

        private void btTambahTamu_Click(object sender, EventArgs e)
        {
            Hide();
            FormPencatatanDataTamu form = new FormPencatatanDataTamu();
            form.ShowDialog();
            loadNamaTamu();
            Show();
        }
    }
}