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
    public partial class FormCheckInOut : Form
    {
        public DataTable dtCheckIn, dtCheckOut;

        public FormCheckInOut()
        {
            InitializeComponent();
        }

        private void FormCheckInOut_Load(object sender, EventArgs e)
        {
            loadDatabase();
            refreshDataGridView();
        }

        public void loadDatabase()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT r.kode_reservasi, t.nama_tamu, k.nomor_kamar, r.jadwal_check_in, r.jadwal_check_out, r.status_reservasi FROM reservasi r LEFT OUTER JOIN tamu t ON r.kode_tamu = t.kode_tamu LEFT OUTER JOIN kamar k ON r.kode_kamar = k.kode_kamar WHERE r.status_reservasi = 1;", Koneksi.getConn());

                dtCheckIn = new DataTable();
                da.Fill(dtCheckIn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // if(dtBasket == null || dtBasket.Rows.Count <= 0)
            // {
            //     dtBasket = new DataTable();
            //     dtBasket.Columns.Add("Number", typeof(string));
            //     dtBasket.Columns.Add("Name", typeof(string));
            //     dtBasket.Columns.Add("Count", typeof(string));
            //     dtBasket.Columns.Add("Total", typeof(string));
            //     dtBasket.Columns.Add("ID", typeof(string));
            // }

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT r.kode_reservasi, t.nama_tamu, k.nomor_kamar, r.jadwal_check_in, r.jadwal_check_out, r.status_reservasi FROM reservasi r LEFT OUTER JOIN tamu t ON r.kode_tamu = t.kode_tamu LEFT OUTER JOIN kamar k ON r.kode_kamar = k.kode_kamar WHERE r.status_reservasi = 2;", Koneksi.getConn());

                dtCheckOut = new DataTable();
                da.Fill(dtCheckOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtCheckIn;
            dataGridView1.Columns[0].HeaderText = "Kode Reservasi";
            // dataGridView1.Columns[0].Width = 48;
            dataGridView1.Columns[1].HeaderText = "Nama Tamu";
            dataGridView1.Columns[2].HeaderText = "Nomor Kamar";
            // JENIS KAMAR???
            // dataGridView1.Columns[2].Width = 54;
            dataGridView1.Columns[3].HeaderText = "Jadwal Check In";
            // dataGridView1.Columns[3].Width = 22;
            dataGridView1.Columns[4].HeaderText = "Jadwal Check Out";
            // dataGridView1.Columns[4].Width = 42;
            dataGridView1.Columns[5].Visible = false;
            // dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular);
            // dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // dataGridView1.AutoSize = false;
            dataGridView1.ClearSelection();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dtCheckOut;
            dataGridView2.Columns[0].HeaderText = "Kode Reservasi";
            dataGridView2.Columns[1].HeaderText = "Nama Tamu";
            dataGridView2.Columns[2].HeaderText = "Nomor Kamar";
            dataGridView2.Columns[3].HeaderText = "Jadwal Check In";
            dataGridView2.Columns[4].HeaderText = "Jadwal Check Out";
            dataGridView2.Columns[5].Visible = false;
            // dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular);
            // dataGridView2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // dataGridView2.AutoSize = false;
            dataGridView2.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridView1.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dataGridView2_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridView2.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
