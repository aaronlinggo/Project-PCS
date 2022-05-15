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
                string query = $"SELECT * FROM reservasi";
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