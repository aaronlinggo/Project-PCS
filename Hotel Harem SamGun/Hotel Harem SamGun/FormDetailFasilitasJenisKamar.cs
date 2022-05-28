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
    public partial class FormDetailFasilitasJenisKamar : Form
    {
        FormDataJenisKamar formLama;
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        DataTable dt, dtDetail;
        int selectedIdx = -1,selectedIdx2 = -1;
        int id_jk;
        
        public FormDetailFasilitasJenisKamar(FormDataJenisKamar formLama)
        {
            Koneksi.openConn();
            conn = Koneksi.conn;
            InitializeComponent();
            this.formLama = formLama;
            this.id_jk = formLama.id_jk;
            cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT nama_jenis_kamar FROM jenis_kamar WHERE id_jenis_kamar = {id_jk}";
            cmd.Connection = conn;
            lblJenisKamar.Text =  cmd.ExecuteScalar().ToString();
            refreshDGVFasilitas();
            refreshDGVDetailFasilitasAwal();
        }

        public void refreshDGVFasilitas()
        {
            dt = new DataTable();
            query = "SELECT id_fasilitas,nama_fasilitas, IF(status_fasilitas = 1, 'Tersedia','Tidak Tersedia') FROM fasilitas ORDER BY 1";
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvFasilitas.DataSource = dt;
            dgvFasilitas.Columns[0].HeaderText = "ID Fasilitas";
            dgvFasilitas.Columns[1].HeaderText = "Nama Fasilitas";
            dgvFasilitas.Columns[2].HeaderText = "Status";
            dgvFasilitas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFasilitas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            selectedIdx = -1;
        }

        public void refreshDGVDetailFasilitasAwal()
        {
            dgvDetailFasilitas.Rows.Clear();
            cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT f.id_fasilitas AS \"ID Fasilitas\", nama_fasilitas AS \"Nama Fasilitas\" FROM detail_fasilitas df JOIN fasilitas f ON f.id_fasilitas = df.id_fasilitas JOIN jenis_kamar jk ON jk.id_jenis_kamar = df.id_jenis_kamar WHERE jk.id_jenis_kamar = {id_jk} AND status_detail_fasilitas = 1 ORDER BY 1";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int idxRow = dgvDetailFasilitas.Rows.Add();
                dgvDetailFasilitas.Rows[idxRow].Cells[0].Value = reader.GetString(0);
                dgvDetailFasilitas.Rows[idxRow].Cells[1].Value = reader.GetString(1);
            }
            reader.Close();
            dgvDetailFasilitas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetailFasilitas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            selectedIdx = -1;
        }

        public void searchDGVFasilitas(string keyword)
        {
            dt = new DataTable();
            query = $"SELECT id_fasilitas,nama_fasilitas, IF(status_fasilitas = 1, 'Tersedia','Tidak Tersedia') FROM fasilitas WHERE nama_fasilitas LIKE '%{keyword}%'ORDER BY 1";
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvFasilitas.DataSource = dt;
            dgvFasilitas.Columns[0].HeaderText = "ID Fasilitas";
            dgvFasilitas.Columns[1].HeaderText = "Nama Fasilitas";
            dgvFasilitas.Columns[2].HeaderText = "Status";
            dgvFasilitas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFasilitas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            selectedIdx = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if(selectedIdx > -1)
            {
                bool found = false;
                string id_fas = dgvFasilitas.Rows[selectedIdx].Cells[0].Value.ToString();
                for (int i = 0; i < dgvDetailFasilitas.Rows.Count; i++)
                {
                    if(id_fas == dgvDetailFasilitas.Rows[i].Cells[0].Value.ToString())
                    {
                        found = true;
                    }
                }
                if(found)
                {
                    MessageBox.Show("Fasilitas tersebut sudah ditambahkan");
                }
                else
                {
                    int idxRow = dgvDetailFasilitas.Rows.Add();
                    dgvDetailFasilitas.Rows[idxRow].Cells[0].Value = dgvFasilitas.Rows[selectedIdx].Cells[0].Value.ToString();
                    dgvDetailFasilitas.Rows[idxRow].Cells[1].Value = dgvFasilitas.Rows[selectedIdx].Cells[1].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih fasilitasnya terlebih dahulu");
            }
            selectedIdx = -1;
            selectedIdx2 = -1;
        }

        private void dgvDetailFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdx2 = dgvDetailFasilitas.CurrentCell.RowIndex;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(selectedIdx2 > -1)
            {
                dgvDetailFasilitas.Rows.RemoveAt(selectedIdx2);
            }
            else
            {
                MessageBox.Show("Silahkan pilih detail fasilitas yang mau dihapus");
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            searchDGVFasilitas(tbCari.Text);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"UPDATE detail_fasilitas SET status_detail_fasilitas = 0 WHERE id_jenis_kamar = '{id_jk}'";
            cmd.ExecuteNonQuery();
            for (int i = 0; i < dgvDetailFasilitas.Rows.Count; i++)
            {
                int id_detail;
                cmd.CommandText = $"SELECT COUNT(*) FROM detail_fasilitas WHERE id_jenis_kamar = '{id_jk}' AND id_fasilitas = '{dgvDetailFasilitas.Rows[i].Cells[0].Value}'";
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if(count > 0)
                {
                    // sudah ada
                    cmd.CommandText = $"SELECT id_detail_fasilitas FROM detail_fasilitas WHERE id_jenis_kamar = '{id_jk}' AND id_fasilitas = '{dgvDetailFasilitas.Rows[i].Cells[0].Value}'";
                    id_detail = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    cmd.CommandText = $"UPDATE detail_fasilitas SET status_detail_fasilitas = 1 WHERE id_detail_fasilitas = '{id_detail}'";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // belum ada
                    cmd.CommandText = $"SELECT COUNT(*) FROM detail_fasilitas";
                    id_detail = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    id_detail++;
                    cmd.CommandText = "INSERT INTO detail_fasilitas (id_detail_fasilitas, id_jenis_kamar, id_fasilitas, status_detail_fasilitas) VALUES (@id_detail, @id_jk, @id_fas, 1)";
                    cmd.Parameters.Add(new MySqlParameter("@id_detail", id_detail));
                    cmd.Parameters.Add(new MySqlParameter("@id_jk", id_jk));
                    cmd.Parameters.Add(new MySqlParameter("@id_fas", dgvDetailFasilitas.Rows[i].Cells[0].Value));
                    cmd.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Berhasil merubah fasilitas");
            refreshDGVDetailFasilitasAwal();
            selectedIdx = -1;
            selectedIdx2 = -1;
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            refreshDGVFasilitas();
            tbCari.Text = "";
        }

        private void dgvFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdx = dgvFasilitas.CurrentCell.RowIndex;
        }
    }
}
