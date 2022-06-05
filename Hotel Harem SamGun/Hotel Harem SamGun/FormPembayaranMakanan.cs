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
    public partial class FormPembayaranMakanan : Form
    {
        string query = "";
        string queryPembelian = "";
        DataTable dttamu;
        DataTable dtpembelian;
        DataRow pick;
        DataRow pickPembayaran;
        public FormPembayaranMakanan()
        {
            InitializeComponent();
        }

        private void FormPembayaranMakanan_Load(object sender, EventArgs e)
        {
            /*Koneksi.openConn();*/
            query = @"SELECT
tamu.kode_tamu,
tamu.nama_tamu
FROM tamu
WHERE tamu.status_tamu = 1";
            loadDatagrid();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
        }

        public void loadDatagrid()
        {
            try
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView1.EnableHeadersVisualStyles = false;

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Koneksi.conn);
                dttamu = new DataTable();
                adapter.Fill(dttamu);

                dataGridView1.DataSource = dttamu;
                dataGridView1.Columns[0].HeaderText = "Kode Tamu";
                dataGridView1.Columns[1].HeaderText = "Nama Tamu";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void loadDatagrid2()
        {
            try
            {
                dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView2.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView2.EnableHeadersVisualStyles = false;

                MySqlDataAdapter adapter = new MySqlDataAdapter(queryPembelian, Koneksi.conn);
                dtpembelian = new DataTable();
                adapter.Fill(dtpembelian);

                dataGridView2.DataSource = dtpembelian;
                dataGridView2.Columns[0].HeaderText = "Kode Pemesanan";
                dataGridView2.Columns[1].HeaderText = "Tanggal Pemesanan";
                dataGridView2.Columns[2].HeaderText = "Kode Tamu";
                dataGridView2.Columns[3].HeaderText = "Total Biaya Pemesanan";
                dataGridView2.Columns[4].HeaderText = "Status Pemesanan Makanan";
                dataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void refreshDataGridView()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DataSource = dttamu;
            dataGridView1.Columns[0].HeaderText = "Kode Tamu";
            dataGridView1.Columns[1].HeaderText = "Nama Tamu";
            dataGridView1.ClearSelection();
        }

        public void refreshDataGridView2()
        {
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.DataSource = dtpembelian;
            dataGridView2.Columns[0].HeaderText = "Kode Pemesanan";
            dataGridView2.Columns[1].HeaderText = "Tanggal Pemesanan";
            dataGridView2.Columns[2].HeaderText = "Kode Tamu";
            dataGridView2.Columns[3].HeaderText = "Total Biaya Pemesanan";
            dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].HeaderText = "Total Biaya Pemesanan";
            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[5].HeaderText = "Status Pemesanan Makanan";
            dataGridView2.Columns[5].Visible = false;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                if (row.Cells[5].Value.ToString() == "0")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (row.Cells[5].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

            dataGridView2.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = @"SELECT
  tamu.kode_tamu,
  tamu.nama_tamu
FROM tamu
WHERE tamu.status_tamu = 1
AND tamu.nama_tamu LIKE '%" + tbCari.Text + "%'";
            loadDatagrid();
            refreshDataGridView();
            tbCari.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pick = dttamu.Rows[dataGridView1.CurrentRow.Index];
            queryPembelian = @"SELECT
  header_pemesanan_makanan.kode_pemesanan,
  DATE_FORMAT(header_pemesanan_makanan.tanggal_pemesanan, '%W, %d %M %Y'),
  header_pemesanan_makanan.kode_tamu,
  header_pemesanan_makanan.total_biaya_pemesanan,
  CONCAT('Rp ', FORMAT(header_pemesanan_makanan.total_biaya_pemesanan, 0)),
  header_pemesanan_makanan.status_pemesanan_makanan
FROM header_pemesanan_makanan
WHERE header_pemesanan_makanan.kode_tamu='" + pick[0].ToString() + "'";

            loadDatagrid2();
            refreshDataGridView2();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pickPembayaran = dtpembelian.Rows[dataGridView2.CurrentRow.Index];
            tbSubtotal.Text = pickPembayaran[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pickPembayaran != null)
            {
                if (pickPembayaran[5].ToString() == "0")
                {
                    MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                    try
                    {
                        MySqlCommand cmd2 = new MySqlCommand();
                        cmd2.CommandText = @"UPDATE header_pemesanan_makanan SET status_pemesanan_makanan=@status_pemesanan_makanan
                        WHERE kode_pemesanan=@kode_pemesanan";
                        cmd2.Parameters.AddWithValue("@status_pemesanan_makanan", "1");
                        cmd2.Parameters.AddWithValue("@kode_pemesanan", pickPembayaran[0].ToString());

                        cmd2.Connection = Koneksi.getConn();
                        cmd2.ExecuteNonQuery();

                        loadDatagrid2();
                        refreshDataGridView2();

                        tbSubtotal.Text = "0";

                        MessageBox.Show("Berhasil bayar!", "Berhasil");
                        sqlt.Commit();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        sqlt.Rollback();
                        MessageBox.Show("Gagal bayar!", "Gagal");
                    }
                }
                else
                {
                    MessageBox.Show("Sudah dibayar!", "Gagal");
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih terlebih dahulu pembayaran yang ingin dibayarkan!", "Gagal");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
