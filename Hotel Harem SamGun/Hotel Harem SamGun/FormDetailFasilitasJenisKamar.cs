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
            cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT f.id_fasilitas AS \"ID Fasilitas\", nama_fasilitas AS \"Nama Fasilitas\" FROM detail_fasilitas df JOIN fasilitas f ON f.id_fasilitas = df.id_fasilitas JOIN jenis_kamar jk ON jk.id_jenis_kamar = df.id_jenis_kamar WHERE jk.id_jenis_kamar = {id_jk} ORDER BY 1";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int idxRow = dgvDetailFasilitas.Rows.Add();
                dgvDetailFasilitas.Rows[idxRow].Cells[0].Value = reader.GetString(0);
                dgvDetailFasilitas.Rows[idxRow].Cells[1].Value = reader.GetString(1);
            }
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
            selectedIdx = -1;
            selectedIdx2 = -1;
        }

        private void dgvDetailFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdx2 = dgvDetailFasilitas.CurrentCell.RowIndex;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            dgvDetailFasilitas.Rows.RemoveAt(selectedIdx2);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            searchDGVFasilitas(tbCari.Text);
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
