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
    public partial class FormDataMenuMakanan : Form
    {
        bool isEdit = false;
        List<String> id_jenis = new List<string>();
        DataTable dtmakanan;
        DataRow pick;
        bool start = false;
        public FormDataMenuMakanan()
        {
            InitializeComponent();
        }

        private void FormDataMenuMakanan_Load(object sender, EventArgs e)
        {
            /*Koneksi.openConn();*/
            id_jenis = new List<string>();
            isEdit = false;
            start = false;
            loadCB();
            loadDatagrid();

            start = true;
        }

        public void loadCB()
        {
            id_jenis = new List<string>();
            cbJenisMakanan.Items.Clear();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Koneksi.conn;
            cmd.CommandText = @"SELECT id_jenis_makanan, nama_jenis_makanan FROM jenis_makanan order by 1 asc";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbJenisMakanan.Items.Add(reader.GetString(1));
                id_jenis.Add(reader.GetString(0));

            }
            reader.Close();

            cbJenisMakanan.SelectedIndex = 0;
        }

        public void loadDatagrid()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(@"SELECT
  makanan.id_makanan,
  makanan.nama_makanan,
  makanan.harga_makanan,
  makanan.stok_makanan,
  makanan.status_makanan,
  makanan.id_jenis_makanan,
  (
   CASE
     WHEN makanan.status_makanan = 0 THEN 'Tidak Tersedia'
     ELSE 'Tersedia'
   END
  ),
  jenis_makanan.nama_jenis_makanan
FROM makanan
  INNER JOIN jenis_makanan
    ON makanan.id_jenis_makanan = jenis_makanan.id_jenis_makanan
WHERE makanan.status_makanan != 99
order by 1 asc", Koneksi.conn);
                dtmakanan = new DataTable();
                adapter.Fill(dtmakanan);

                dataGridView1.DataSource = dtmakanan;
                dataGridView1.Columns[0].HeaderText = "ID Makanan";
                dataGridView1.Columns[1].HeaderText = "Nama Makanan";
                dataGridView1.Columns[2].HeaderText = "Harga Makanan";
                dataGridView1.Columns[3].HeaderText = "Stok Makanan";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Status Makanan";
                dataGridView1.Columns[7].HeaderText = "Jenis Makanan";
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            if (tbHarga.Text.Length > 0)
            {
                char temp = tbHarga.Text[(tbHarga.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbHarga.Text = tbHarga.Text.Remove(tbHarga.Text.Length - 1, 1);
                    tbHarga.SelectionStart = tbHarga.Text.Length;
                }
            }

            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void tbStok_TextChanged(object sender, EventArgs e)
        {
            if (tbStok.Text.Length > 0)
            {
                char temp = tbStok.Text[(tbStok.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbStok.Text = tbStok.Text.Remove(tbStok.Text.Length - 1, 1);
                    tbStok.SelectionStart = tbStok.Text.Length;
                }
            }

            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        public void generateID()
        {
            if (tbNama.Text != "" || tbHarga.Text != "" || tbStok.Text != "" || rbTersedia.Checked != false || rbTidakTersedia.Checked != false || cbJenisMakanan.SelectedIndex != -1)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(id_makanan) FROM makanan", Koneksi.conn);
                int nextID = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                tbKode.Text = "" + nextID;
            }
            else
            {
                tbKode.Text = "";
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void cbJenisMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void rbTersedia_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void rbTidakTersedia_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            isEdit = false;
            start = false;
            tbKode.Text = "";
            tbNama.Text = "";
            tbHarga.Text = "";
            tbStok.Text = "";
            rbTersedia.Checked = true;
            rbTidakTersedia.Checked = false;
            cbJenisMakanan.SelectedIndex = 0;
            start = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                if (tbHarga.Text != "")
                {
                    if (tbStok.Text != "")
                    {
                        if (rbTersedia.Checked || rbTidakTersedia.Checked)
                        {
                            if (cbJenisMakanan.SelectedIndex != -1)
                            {
                                if (Convert.ToInt32(tbHarga.Text) >= 0)
                                {
                                    if (Convert.ToInt32(tbStok.Text) >= 0)
                                    {
                                        MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                                        try
                                        {
                                            // cek nama makanan
                                            // cek status makanan 99

                                            MySqlCommand cmd = new MySqlCommand();
                                            cmd.CommandText = @"SELECT
  count(makanan.id_makanan)
FROM makanan
WHERE UPPER(makanan.nama_makanan) like '%" + tbNama.Text.ToUpper() +"%' AND makanan.status_makanan=99";
                                            cmd.Connection = Koneksi.getConn();
                                            int ada;
                                            ada = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                                            int status = 0;
                                            if (rbTersedia.Checked)
                                            {
                                                status = 0;
                                            }
                                            else
                                            {
                                                status = 1;
                                            }

                                            if (ada != 0)
                                            {
                                                MySqlCommand cmdid = new MySqlCommand();
                                                cmdid.CommandText = @"SELECT
  makanan.id_makanan
FROM makanan
WHERE UPPER(makanan.nama_makanan) like '%" + tbNama.Text.ToUpper() + "%' AND makanan.status_makanan=99";
                                                cmdid.Connection = Koneksi.getConn();
                                                int idtemp;
                                                idtemp = Convert.ToInt32(cmdid.ExecuteScalar().ToString());

                                                MySqlCommand cmd2 = new MySqlCommand();
                                                cmd2.CommandText = "UPDATE makanan SET nama_makanan=@nama_makanan, harga_makanan=@harga_makanan, stok_makanan=@stok_makanan, status_makanan=@status_makanan, id_jenis_makanan=@id_jenis_makanan WHERE id_makanan=@id_makanan";
                                                cmd2.Parameters.AddWithValue("@id_makanan", idtemp);
                                                cmd2.Parameters.AddWithValue("@nama_makanan", tbNama.Text);
                                                cmd2.Parameters.AddWithValue("@harga_makanan", tbHarga.Text);
                                                cmd2.Parameters.AddWithValue("@stok_makanan", tbStok.Text);
                                                cmd2.Parameters.AddWithValue("@status_makanan", status);
                                                cmd2.Parameters.AddWithValue("@id_jenis_makanan", id_jenis[cbJenisMakanan.SelectedIndex]);

                                                cmd2.Connection = Koneksi.getConn();
                                                cmd2.ExecuteNonQuery();
                                            }
                                            else
                                            {
                                                MySqlDataAdapter adapter = new MySqlDataAdapter(@"SELECT
  makanan.id_makanan,
  makanan.nama_makanan,
  makanan.harga_makanan,
  makanan.stok_makanan,
  makanan.status_makanan,
  makanan.id_jenis_makanan
FROM makanan
order by 1 asc", Koneksi.getConn());
                                                DataTable dt = new DataTable();
                                                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                                                adapter.Fill(dt);

                                                DataRow baru = dt.NewRow();
                                                baru["id_makanan"] = tbKode.Text;
                                                baru["nama_makanan"] = tbNama.Text;
                                                baru["harga_makanan"] = tbHarga.Text;
                                                baru["stok_makanan"] = tbStok.Text;
                                                baru["status_makanan"] = status;
                                                baru["id_jenis_makanan"] = id_jenis[cbJenisMakanan.SelectedIndex];
                                                dt.Rows.Add(baru);

                                                adapter.Update(dt);
                                            }
                                            loadCB();
                                            loadDatagrid();
                                            refreshDataGridView();

                                            isEdit = false;
                                            start = false;
                                            tbKode.Text = "";
                                            tbNama.Text = "";
                                            tbHarga.Text = "";
                                            tbStok.Text = "";
                                            rbTersedia.Checked = true;
                                            rbTidakTersedia.Checked = false;
                                            cbJenisMakanan.SelectedIndex = 0;
                                            start = true;
                                            btnEdit.Enabled = false;
                                            btnHapus.Enabled = false;

                                            MessageBox.Show("Berhasil Insert Menu Makanan!");
                                            sqlt.Commit();
                                        }
                                        catch (MySqlException ex)
                                        {
                                            sqlt.Rollback();
                                            MessageBox.Show("Gagal Insert Menu Makanan!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Stok Makanan harus lebih besar sama dengan 0 (>=0)");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Harga Makanan harus lebih besar sama dengan 0 (>=0)");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Jenis Makanan tidak boleh kosong!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Status Makanan tidak boleh kosong!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stok Makanan tidak boleh kosong!");
                    }
                }
                else
                {
                    MessageBox.Show("Harga Makanan tidak boleh kosong!");
                }
            }
            else
            {
                MessageBox.Show("Nama Makanan tidak boleh kosong!");
            }
        }

        public void refreshDataGridView()
        {
            dataGridView1.DataSource = dtmakanan;
            dataGridView1.Columns[0].HeaderText = "ID Makanan";
            dataGridView1.Columns[1].HeaderText = "Nama Makanan";
            dataGridView1.Columns[2].HeaderText = "Harga Makanan";
            dataGridView1.Columns[3].HeaderText = "Stok Makanan";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Status Makanan";
            dataGridView1.Columns[7].HeaderText = "Jenis Makanan";
            dataGridView1.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                if (tbHarga.Text != "")
                {
                    if (tbStok.Text != "")
                    {
                        if (rbTersedia.Checked || rbTidakTersedia.Checked)
                        {
                            if (cbJenisMakanan.SelectedIndex != -1)
                            {
                                if (Convert.ToInt32(tbHarga.Text) >= 0)
                                {
                                    if (Convert.ToInt32(tbStok.Text) >= 0)
                                    {
                                        MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                                        try
                                        {
                                            int status = 0;
                                            if (rbTersedia.Checked)
                                            {
                                                status = 0;
                                            }
                                            else
                                            {
                                                status = 1;
                                            }

                                            MySqlCommand cmd2 = new MySqlCommand();
                                            cmd2.CommandText = "UPDATE makanan SET nama_makanan=@nama_makanan, harga_makanan=@harga_makanan, stok_makanan=@stok_makanan, status_makanan=@status_makanan, id_jenis_makanan=@id_jenis_makanan WHERE id_makanan=@id_makanan";
                                            cmd2.Parameters.AddWithValue("@id_makanan", tbKode.Text);
                                            cmd2.Parameters.AddWithValue("@nama_makanan", tbNama.Text);
                                            cmd2.Parameters.AddWithValue("@harga_makanan", tbHarga.Text);
                                            cmd2.Parameters.AddWithValue("@stok_makanan", tbStok.Text);
                                            cmd2.Parameters.AddWithValue("@status_makanan", status);
                                            cmd2.Parameters.AddWithValue("@id_jenis_makanan", id_jenis[cbJenisMakanan.SelectedIndex]);
                                            cmd2.Connection = Koneksi.getConn();
                                            cmd2.ExecuteNonQuery();

                                            loadCB();
                                            loadDatagrid();
                                            refreshDataGridView();

                                            isEdit = false;
                                            start = false;
                                            tbKode.Text = "";
                                            tbNama.Text = "";
                                            tbHarga.Text = "";
                                            tbStok.Text = "";
                                            rbTersedia.Checked = true;
                                            rbTidakTersedia.Checked = false;
                                            cbJenisMakanan.SelectedIndex = 0;
                                            start = true;
                                            btnEdit.Enabled = false;
                                            btnHapus.Enabled = false;

                                            MessageBox.Show("Berhasil Ubah Menu Makanan!");
                                            sqlt.Commit();
                                        }
                                        catch (MySqlException ex)
                                        {
                                            sqlt.Rollback();
                                            MessageBox.Show("Gagal Ubah Menu Makanan!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Stok Makanan harus lebih besar sama dengan 0 (>=0)");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Harga Makanan harus lebih besar sama dengan 0 (>=0)");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Jenis Makanan tidak boleh kosong!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Status Makanan tidak boleh kosong!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stok Makanan tidak boleh kosong!");
                    }
                }
                else
                {
                    MessageBox.Show("Harga Makanan tidak boleh kosong!");
                }
            }
            else
            {
                MessageBox.Show("Nama Makanan tidak boleh kosong!");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
            try
            {
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "UPDATE makanan set status_makanan=@status_makanan WHERE id_makanan=@id_makanan";
                cmd2.Parameters.AddWithValue("@id_makanan", tbKode.Text);
                cmd2.Parameters.AddWithValue("@status_makanan", "99");

                cmd2.Connection = Koneksi.getConn();
                cmd2.ExecuteNonQuery();

                loadCB();
                loadDatagrid();
                refreshDataGridView();

                isEdit = false;
                start = false;
                tbKode.Text = "";
                tbNama.Text = "";
                tbHarga.Text = "";
                tbStok.Text = "";
                rbTersedia.Checked = true;
                rbTidakTersedia.Checked = false;
                cbJenisMakanan.SelectedIndex = 0;
                start = true;
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;

                MessageBox.Show("Berhasil Hapus Menu Makanan!");
                sqlt.Commit();
            }
            catch (MySqlException ex)
            {
                sqlt.Rollback();
                MessageBox.Show("Gagal Hapus Menu Makanan!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*makanan.id_makanan, 0
            makanan.nama_makanan, 1
            makanan.harga_makanan, 2
            makanan.stok_makanan, 3
            makanan.status_makanan, 4
            makanan.id_jenis_makanan, 5
            (
            CASE
                WHEN makanan.status_makanan = 0 THEN 'Tidak Tersedia'
                ELSE 'Tersedia'
            END
            ), 6
            jenis_makanan.nama_jenis_makanan 7 */
            isEdit = true;
            btnHapus.Enabled = true;
            btnEdit.Enabled = true;
            pick = dtmakanan.Rows[dataGridView1.CurrentRow.Index];
            tbKode.Text = pick[0].ToString();
            tbNama.Text = pick[1].ToString();
            tbHarga.Text = pick[2].ToString();
            tbStok.Text = pick[3].ToString();
            if (pick[4].ToString() == "0")
            {
                rbTidakTersedia.Checked = true;
                rbTersedia.Checked = false;
            }
            else
            {
                rbTidakTersedia.Checked = false;
                rbTersedia.Checked = true;
            }
            cbJenisMakanan.SelectedItem = pick[7].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
