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
    public partial class FormPemesananMakanan : Form
    {
        string query = "";
        int pilih;
        DataTable dtmakanan;
        DataTable dtkeranjang;
        DataRow pick;
        DataRow pickkeranjang;
        List<string> id_makanan = new List<string>();
        List<string> id_tamu = new List<string>();
        List<string> kode_tamu = new List<string>();
        List<String> id_keranjang = new List<string>();
        public FormPemesananMakanan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            if (tbPembelian.Text.Length > 0)
            {
                char temp = tbPembelian.Text[(tbPembelian.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbPembelian.Text = tbPembelian.Text.Remove(tbPembelian.Text.Length - 1, 1);
                    tbPembelian.SelectionStart = tbPembelian.Text.Length;
                }
            }
            else
            {
                tbPembelian.Text = "0";
            }
        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPembelian.Text) - 1 >= 0)
            {
                tbPembelian.Text = Convert.ToInt32(tbPembelian.Text) - 1 + "";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (tbStok.Text != tbPembelian.Text)
            {
                tbPembelian.Text = Convert.ToInt32(tbPembelian.Text) + 1 + "";

            }
        }

        private void FormPemesananMakanan_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f7a13e");

            query = @"SELECT
  makanan.id_makanan,
  makanan.nama_makanan,
  makanan.harga_makanan,
  makanan.stok_makanan,
  makanan.status_makanan,
  makanan.id_jenis_makanan,
  jenis_makanan.nama_jenis_makanan
FROM makanan
  INNER JOIN jenis_makanan
    ON makanan.id_jenis_makanan = jenis_makanan.id_jenis_makanan
WHERE makanan.status_makanan != 0
order by 1 asc";
            id_makanan = new List<string>();
            id_tamu = new List<string>();
            kode_tamu = new List<string>();
            id_keranjang = new List<string>();
            dtkeranjang = new DataTable();
            dtkeranjang.Columns.Add("No", typeof(string));
            dtkeranjang.Columns.Add("Nama Makanan", typeof(string));
            dtkeranjang.Columns.Add("Jumlah Pemesanan", typeof(string));
            dtkeranjang.Columns.Add("Total Harga", typeof(string));
            dataGridView2.DataSource = dtkeranjang;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            dataGridView2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            dataGridView2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            /*Koneksi.openConn();*/
            loadDatagrid();
            loadCB();
        }

        public void loadCB()
        {
            id_tamu = new List<string>();
            kode_tamu = new List<string>();
            cbTamu.Items.Clear();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Koneksi.conn;
            cmd.CommandText = @"SELECT id_tamu, kode_tamu, nama_tamu from tamu order by 1 asc";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbTamu.Items.Add(reader.GetString(2));
                id_tamu.Add(reader.GetString(0));
                kode_tamu.Add(reader.GetString(1));

            }
            reader.Close();

            cbTamu.SelectedIndex = 0;
        }

        public void loadDatagrid()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Koneksi.conn);
                dtmakanan = new DataTable();
                adapter.Fill(dtmakanan);

                dataGridView1.DataSource = dtmakanan;
                dataGridView1.Columns[0].HeaderText = "ID Makanan";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nama Makanan";
                dataGridView1.Columns[2].HeaderText = "Harga";
                dataGridView1.Columns[3].HeaderText = "Stok";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Jenis";
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*makanan.id_makanan, 0
            makanan.nama_makanan, 1
            makanan.harga_makanan, 2
            makanan.stok_makanan, 3
            makanan.status_makanan, 4
            makanan.id_jenis_makanan, 5
            jenis_makanan.nama_jenis_makanan 6 */
            pick = dtmakanan.Rows[dataGridView1.CurrentRow.Index];
            pilih = dataGridView1.CurrentRow.Index;
            tbNama.Text = pick[1].ToString();
            tbHarga.Text = pick[2].ToString();
            tbStok.Text = pick[3].ToString();
            if (pick[3].ToString() != "0")
            {
                tbKeterangan.Text = "Tersedia";
                btnTambah.Enabled = true;
            }
            else
            {
                tbKeterangan.Text = "Tidak Tersedia";
                btnTambah.Enabled = false;
            }
            btnMines.Enabled = true;
            btnPlus.Enabled = true;
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            query = @"SELECT
  makanan.id_makanan,
  makanan.nama_makanan,
  makanan.harga_makanan,
  makanan.stok_makanan,
  makanan.status_makanan,
  makanan.id_jenis_makanan,
  jenis_makanan.nama_jenis_makanan
FROM makanan
  INNER JOIN jenis_makanan
    ON makanan.id_jenis_makanan = jenis_makanan.id_jenis_makanan
WHERE makanan.status_makanan != 0
order by 1 asc";
            tbNama.Text = "";
            tbHarga.Text = "";
            tbStok.Text = "";
            tbKeterangan.Text = "";
            tbPembelian.Text = "0";
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnMines.Enabled = false;
            btnPlus.Enabled = false;
            dataGridView1.ClearSelection();
            loadDatagrid();
            tbCari.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbPembelian.Text != "0")
            {
                int ada_id = -1;
                int pos_ada = -1;

                for (int i = 0; i < id_keranjang.Count; i++)
                {
                    if (dataGridView1.Rows[pilih].Cells[0].Value.ToString() == id_keranjang[i])
                    {
                        ada_id = Convert.ToInt32(id_keranjang[i]);
                        pos_ada = i;
                        break;
                    }
                }

                if (ada_id == -1)
                {
                    DataRow baru = dtkeranjang.NewRow();
                    baru["No"] = dtkeranjang.Rows.Count + 1;
                    baru["Nama Makanan"] = dataGridView1.Rows[pilih].Cells[1].Value;
                    baru["Jumlah Pemesanan"] = tbPembelian.Text;
                    baru["Total Harga"] = Convert.ToInt32(dataGridView1.Rows[pilih].Cells[2].Value) * Convert.ToInt32(tbPembelian.Text) + "";
                    dtkeranjang.Rows.Add(baru);

                    id_keranjang.Add(dataGridView1.Rows[pilih].Cells[0].Value.ToString());
                }
                else
                {
                    dataGridView2.Rows[pos_ada].Cells[2].Value = Convert.ToInt32(dataGridView2.Rows[pos_ada].Cells[2].Value.ToString()) + Convert.ToInt32(tbPembelian.Text) + "";
                    dataGridView2.Rows[pos_ada].Cells[3].Value = Convert.ToInt32(dataGridView2.Rows[pos_ada].Cells[3].Value.ToString()) + (Convert.ToInt32(dataGridView1.Rows[pilih].Cells[2].Value) * Convert.ToInt32(tbPembelian.Text)) + "";
                }

                dataGridView2.DataSource = dtkeranjang;

                tbSubtotal.Text = Convert.ToInt32(tbSubtotal.Text) + (Convert.ToInt32(dataGridView1.Rows[pilih].Cells[2].Value) * Convert.ToInt32(tbPembelian.Text)) + "";

                btnTambah.Enabled = false;
                tbPembelian.Text = "0";
                tbNama.Text = "";
                tbHarga.Text = "";
                tbStok.Text = "";
                tbKeterangan.Text = "";
            }
            else
            {
                MessageBox.Show("Jumlah yang ingin dibeli minimum 1!");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows[0].Index != -1)
            {
                id_keranjang.RemoveAt(dataGridView2.SelectedRows[0].Index);

                dtkeranjang.Rows[dataGridView2.SelectedRows[0].Index].Delete();

                int tot = 0;

                for (int i = 0; i < dtkeranjang.Rows.Count; i++)
                {
                    dtkeranjang.Rows[i][0] = i + 1;
                    tot += Convert.ToInt32(dtkeranjang.Rows[i][3].ToString());
                }
                tbSubtotal.Text = tot + "";

                btnHapus.Enabled = false;
            }

            if (dtkeranjang.Rows.Count > 0)
            {
                btnPesan.Enabled = true;
            }
            else if (dtkeranjang.Rows.Count < 1)
            {
                btnPesan.Enabled = false;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapus.Enabled = true;
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dtkeranjang.Rows.Count > 0)
            {
                btnPesan.Enabled = true;
            }
            else if (dtkeranjang.Rows.Count < 1)
            {
                btnPesan.Enabled = false;
            }
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtkeranjang.Rows.Count > 0)
            {
                btnPesan.Enabled = true;
            }
            else if (dtkeranjang.Rows.Count < 1)
            {
                btnPesan.Enabled = false;
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (cbTamu.SelectedIndex != -1)
            {
                MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                try
                {
                    MySqlCommand cmd55 = new MySqlCommand();
                    cmd55.CommandText = "select max(id_pemesanan) + 1 from pemesanan_makanan";
                    cmd55.Connection = Koneksi.getConn();
                    int id_pemesanan = Convert.ToInt32(cmd55.ExecuteScalar().ToString());
                    /*"NOTA" + 2 digit tanggal pemesanan + 2 digit bulan pemesanan + 2 digit tahun pemesanan + 5 digit nomor urut*/
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select count(id_pemesanan) + 1 from pemesanan_makanan where kode_pemesanan LIKE 'NOTA" + DateTime.Now.ToString("ddMMyy") + "%'";
                    cmd.Connection = Koneksi.getConn();
                    int count_kode;
                    count_kode = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    string nota = "NOTA" + DateTime.Now.ToString("ddMMyy");
                    if (count_kode < 10)
                    {
                        nota += "0000" + count_kode;
                    }
                    else if (count_kode < 100)
                    {
                        nota += "000" + count_kode;
                    }
                    else if (count_kode < 1000)
                    {
                        nota += "00" + count_kode;
                    }
                    else if (count_kode < 10000)
                    {
                        nota += "0" + count_kode;
                    }
                    else if (count_kode < 100000)
                    {
                        nota += "" + count_kode;
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter("select id_detail_pemesanan, kode_pemesanan, id_makanan, jumlah_pemesanan, subtotal_biaya_pemesanan from detail_pemesanan_makanan", Koneksi.getConn());
                    DataTable dt = new DataTable();
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);

                    string query = $"insert into pemesanan_makanan values('{id_pemesanan}', '{nota}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{kode_tamu[cbTamu.SelectedIndex]}', '{tbSubtotal.Text}')";
                    MySqlCommand cmd1 = new MySqlCommand(query, Koneksi.getConn());
                    cmd1.ExecuteNonQuery();

                    int tot_harga = 0;

                    MySqlCommand cmd565 = new MySqlCommand();
                    cmd565.CommandText = "select max(id_detail_pemesanan) + 1 from detail_pemesanan_makanan";
                    cmd565.Connection = Koneksi.getConn();
                    int id_detail_pemesanan = Convert.ToInt32(cmd565.ExecuteScalar().ToString());

                    for (int i = 0; i < dtkeranjang.Rows.Count; i++)
                    {
                        MySqlCommand checkstock = new MySqlCommand();
                        checkstock.CommandText = $"select stok_makanan from makanan where id_makanan='{id_keranjang[i]}'";
                        checkstock.Connection = Koneksi.getConn();
                        int stock = Convert.ToInt32(checkstock.ExecuteScalar().ToString());

                        if (stock - Convert.ToInt32(dtkeranjang.Rows[i].ItemArray[2].ToString()) >= 0)
                        {
                            DataRow baru = dt.NewRow();
                            baru["id_detail_pemesanan"] = id_detail_pemesanan;
                            baru["kode_pemesanan"] = nota;
                            baru["id_makanan"] = id_keranjang[i];
                            baru["jumlah_pemesanan"] = dtkeranjang.Rows[i].ItemArray[2];
                            baru["subtotal_biaya_pemesanan"] = dtkeranjang.Rows[i].ItemArray[3];
                            id_detail_pemesanan++;
                            dt.Rows.Add(baru);

                            MySqlCommand check_total = new MySqlCommand();
                            check_total.CommandText = $"select total_terjual from makanan where id_makanan='{id_keranjang[i]}'";
                            check_total.Connection = Koneksi.getConn();
                            int terjual = Convert.ToInt32(check_total.ExecuteScalar().ToString());

                            MySqlCommand cm9 = new MySqlCommand();
                            cm9.CommandText = "UPDATE makanan SET stok_makanan=@tot, total_terjual=@tot1 WHERE id_makanan=@kod";
                            cm9.Parameters.AddWithValue("@kod", id_keranjang[i]);
                            cm9.Parameters.AddWithValue("@tot", stock - Convert.ToInt32(dtkeranjang.Rows[i].ItemArray[2].ToString()));
                            cm9.Parameters.AddWithValue("@tot1", terjual + Convert.ToInt32(dtkeranjang.Rows[i].ItemArray[2].ToString()));
                            cm9.Connection = Koneksi.getConn();
                            cm9.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Gagal Beli, Stok tidak mencukupi!");
                            sqlt.Rollback();
                            return;
                        }
                    }

                    dtkeranjang = new DataTable();
                    dtkeranjang.Columns.Add("No", typeof(string));
                    dtkeranjang.Columns.Add("Nama Makanan", typeof(string));
                    dtkeranjang.Columns.Add("Jumlah Pemesanan", typeof(string));
                    dtkeranjang.Columns.Add("Total Harga", typeof(string));
                    dataGridView2.DataSource = dtkeranjang;

                    id_keranjang = new List<string>();

                    tbNama.Text = "";
                    tbHarga.Text = "";
                    tbStok.Text = "";
                    tbKeterangan.Text = "";
                    tbPembelian.Text = "0";
                    tbSubtotal.Text = "0";
                    btnHapus.Enabled = false;
                    btnTambah.Enabled = false;
                    btnMines.Enabled = false;
                    btnPlus.Enabled = false;

                    MessageBox.Show("Berhasil Pesan Makanan!");

                    adapter.Update(dt);

                    sqlt.Commit();
                }
                catch (MySqlException ex)
                {
                    sqlt.Rollback();
                    MessageBox.Show(ex.Message);
                }

                loadDatagrid();
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Pilih Tamu yang ingin membeli makanan!");
            }
        }

        public void refreshDataGridView()
        {
            dataGridView1.DataSource = dtmakanan;
            dataGridView1.Columns[0].HeaderText = "ID Makanan";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nama Makanan";
            dataGridView1.Columns[2].HeaderText = "Harga";
            dataGridView1.Columns[3].HeaderText = "Stok";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Jenis";
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = @"SELECT
  makanan.id_makanan,
  makanan.nama_makanan,
  makanan.harga_makanan,
  makanan.stok_makanan,
  makanan.status_makanan,
  makanan.id_jenis_makanan,
  jenis_makanan.nama_jenis_makanan
FROM makanan
  INNER JOIN jenis_makanan
    ON makanan.id_jenis_makanan = jenis_makanan.id_jenis_makanan
WHERE makanan.status_makanan != 0
AND
makanan.nama_makanan LIKE '%" + tbCari.Text + @"%'
order by 1 asc";
            loadDatagrid();
            tbCari.Text = "";
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
