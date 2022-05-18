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
    public partial class FormDataJenisMakanan : Form
    {
        DataTable dtjenis;
        DataRow pick;
        bool isEdit = false;
        string query = "";
        public FormDataJenisMakanan()
        {
            InitializeComponent();
        }

        private void FormDataJenisMakanan_Load(object sender, EventArgs e)
        {
            /*Koneksi.openConn();*/
            query = @"SELECT
  jenis_makanan.id_jenis_makanan,
  jenis_makanan.nama_jenis_makanan
FROM jenis_makanan
WHERE jenis_makanan.status_jenis_makanan = 1
order by 1 asc";
            isEdit = false;
            loadDatagrid();
        }

        public void loadDatagrid()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Koneksi.conn);
                dtjenis = new DataTable();
                adapter.Fill(dtjenis);

                dataGridView1.DataSource = dtjenis;
                dataGridView1.Columns[0].HeaderText = "ID Jenis Makanan";
                dataGridView1.Columns[1].HeaderText = "Nama Jenis Makanan";
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refreshDataGridView()
        {
            dataGridView1.DataSource = dtjenis;
            dataGridView1.Columns[0].HeaderText = "ID Jenis Makanan";
            dataGridView1.Columns[1].HeaderText = "Nama Jenis Makanan";
            dataGridView1.ClearSelection();
        }

        public void generateID()
        {
            if (tbNama.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(id_jenis_makanan) FROM jenis_makanan", Koneksi.conn);
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
            if (!isEdit)
            {
                generateID();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = @"SELECT
count(jenis_makanan.id_jenis_makanan)
FROM jenis_makanan
WHERE UPPER(jenis_makanan.nama_jenis_makanan) like '%" + tbNama.Text.ToUpper() + "%' AND jenis_makanan.status_jenis_makanan=0";
                    cmd.Connection = Koneksi.getConn();
                    int ada;
                    ada = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    if (ada != 0)
                    {
                        MySqlCommand cmdid = new MySqlCommand();
                        cmdid.CommandText = @"SELECT
jenis_makanan.id_jenis_makanan
FROM jenis_makanan
WHERE UPPER(jenis_makanan.nama_jenis_makanan) like '%" + tbNama.Text.ToUpper() + "%' AND jenis_makanan.status_jenis_makanan=0";
                        cmdid.Connection = Koneksi.getConn();
                        int idtemp;
                        idtemp = Convert.ToInt32(cmdid.ExecuteScalar().ToString());

                        MySqlCommand cmd2 = new MySqlCommand();
                        cmd2.CommandText = "UPDATE jenis_makanan SET nama_jenis_makanan=@nama_jenis_makanan, status_jenis_makanan=@status_jenis_makanan WHERE id_jenis_makanan=@id_jenis_makanan";
                        cmd2.Parameters.AddWithValue("@id_jenis_makanan", idtemp);
                        cmd2.Parameters.AddWithValue("@nama_jenis_makanan", tbNama.Text);
                        cmd2.Parameters.AddWithValue("@status_jenis_makanan", "1");

                        cmd2.Connection = Koneksi.getConn();
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(@"SELECT
  jenis_makanan.id_jenis_makanan,
  jenis_makanan.nama_jenis_makanan,
  jenis_makanan.status_jenis_makanan
FROM jenis_makanan
order by 1 asc", Koneksi.getConn());
                        DataTable dt = new DataTable();
                        MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                        adapter.Fill(dt);

                        DataRow baru = dt.NewRow();
                        baru["id_jenis_makanan"] = tbKode.Text;
                        baru["nama_jenis_makanan"] = tbNama.Text;
                        baru["status_jenis_makanan"] = "1";
                        dt.Rows.Add(baru);

                        adapter.Update(dt);
                    }
                    loadDatagrid();
                    refreshDataGridView();

                    isEdit = false;
                    tbKode.Text = "";
                    tbNama.Text = "";
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;

                    MessageBox.Show("Berhasil Insert Jenis Makanan!");
                    sqlt.Commit();
                }
                catch (MySqlException ex)
                {
                    sqlt.Rollback();
                    MessageBox.Show("Gagal Insert Jenis Makanan!");
                }
                                   
            }
            else
            {
                MessageBox.Show("Nama Jenis Makanan tidak boleh kosong!");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
            try
            {
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "UPDATE jenis_makanan set status_jenis_makanan=@status_jenis_makanan WHERE id_jenis_makanan=@id_jenis_makanan";
                cmd2.Parameters.AddWithValue("@id_jenis_makanan", tbKode.Text);
                cmd2.Parameters.AddWithValue("@status_jenis_makanan", "0");

                cmd2.Connection = Koneksi.getConn();
                cmd2.ExecuteNonQuery();

                loadDatagrid();
                refreshDataGridView();

                isEdit = false;
                tbKode.Text = "";
                tbNama.Text = "";
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                btnTambah.Enabled = true;

                MessageBox.Show("Berhasil Hapus Jenis Makanan!");
                sqlt.Commit();
            }
            catch (MySqlException ex)
            {
                sqlt.Rollback();
                MessageBox.Show("Gagal Hapus Jenis Makanan!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                
                MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                try
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandText = "UPDATE jenis_makanan SET nama_jenis_makanan=@nama_jenis_makanan, status_jenis_makanan=@status_jenis_makanan WHERE id_jenis_makanan=@id_jenis_makanan";
                    cmd2.Parameters.AddWithValue("@id_jenis_makanan", tbKode.Text);
                    cmd2.Parameters.AddWithValue("@nama_jenis_makanan", tbNama.Text);
                    cmd2.Parameters.AddWithValue("@status_jenis_makanan", "1");

                    cmd2.Connection = Koneksi.getConn();
                    cmd2.ExecuteNonQuery();

                    loadDatagrid();
                    refreshDataGridView();

                    isEdit = false;
                    tbKode.Text = "";
                    tbNama.Text = "";
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;
                    btnTambah.Enabled = true;

                    MessageBox.Show("Berhasil Ubah Jenis Makanan!");
                    sqlt.Commit();
                }
                catch (MySqlException ex)
                {
                    sqlt.Rollback();
                    MessageBox.Show("Gagal Ubah Jenis Makanan!");
                }
            }
            else
            {
                MessageBox.Show("Nama Jenis Makanan tidak boleh kosong!");
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            isEdit = false;
            tbKode.Text = "";
            tbNama.Text = "";
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            query = @"SELECT
  jenis_makanan.id_jenis_makanan,
  jenis_makanan.nama_jenis_makanan
FROM jenis_makanan
WHERE jenis_makanan.status_jenis_makanan = 1
order by 1 asc";
            loadDatagrid();
            tbCari.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*jenis_makanan.id_jenis_makanan,
            jenis_makanan.nama_jenis_makanan */
            isEdit = true;
            btnHapus.Enabled = true;
            btnEdit.Enabled = true;
            btnTambah.Enabled = false;
            pick = dtjenis.Rows[dataGridView1.CurrentRow.Index];
            tbKode.Text = pick[0].ToString();
            tbNama.Text = pick[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = @"SELECT
  jenis_makanan.id_jenis_makanan,
  jenis_makanan.nama_jenis_makanan
FROM jenis_makanan
WHERE jenis_makanan.status_jenis_makanan = 1
AND
jenis_makanan.nama_jenis_makanan LIKE '%" + tbCari.Text + @"%'
order by 1 asc";
            loadDatagrid();
            tbCari.Text = "";
        }
    }
}
