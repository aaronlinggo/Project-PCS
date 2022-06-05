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
    public partial class FormDataJenisKamar : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        DataTable dt;
        int selectedIdx = -1;
        public int id_jk;
        public string fontName = "Gill Sans MT";

        public FormDataJenisKamar()
        {
            Koneksi.openConn();
            conn = Koneksi.conn;
            InitializeComponent();
            rb1.Checked = true;
            resetTampilan();
            refreshDGV();
        }

        private void FormDataJenisKamar_Load(object sender, EventArgs e)
        {
            dgvJenisKamar.ClearSelection();
        }

        private DataGridView UpdateDataGridViewFont(DataGridView dataGridView, float fontSize)
        {
            dataGridView.Font = new Font(fontName, fontSize, dataGridView.Font.Style, GraphicsUnit.Pixel, ((byte)(0)));

            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                r.DefaultCellStyle.Font = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel);
            }

            return dataGridView;
        }

        public void refreshDGV()
        {
            dgvJenisKamar.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvJenisKamar.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvJenisKamar.EnableHeadersVisualStyles = false;

            dt = new DataTable();
            query = "SELECT id_jenis_kamar,nama_jenis_kamar,CONCAT('Rp ', FORMAT(harga_jenis_kamar,0,'de_DE')),IF(status_jenis_kamar = 1, 'Tersedia','Tidak Tersedia') FROM jenis_kamar ORDER BY id_jenis_kamar";
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvJenisKamar.DataSource = dt;
            dgvJenisKamar.Columns[0].HeaderText = "ID Jenis Kamar";
            dgvJenisKamar.Columns[1].HeaderText = "Nama Jenis Kamar";
            dgvJenisKamar.Columns[2].HeaderText = "Harga Jenis Kamar";
            dgvJenisKamar.Columns[3].HeaderText = "Status";
            dgvJenisKamar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvJenisKamar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvJenisKamar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvJenisKamar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            selectedIdx = -1;

            dgvJenisKamar = UpdateDataGridViewFont(dgvJenisKamar, 16F);
            dgvJenisKamar.ClearSelection();
        }

        public void searchDGV(string keyword)
        {
            dgvJenisKamar.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvJenisKamar.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvJenisKamar.EnableHeadersVisualStyles = false;

            dt = new DataTable();
            query = $"SELECT id_jenis_kamar,nama_jenis_kamar,CONCAT('Rp ', FORMAT(harga_jenis_kamar,0,'de_DE')),IF(status_jenis_kamar = 1, 'Tersedia','Tidak Tersedia') FROM jenis_kamar WHERE nama_jenis_kamar LIKE '%{keyword}%' ORDER BY id_jenis_kamar";
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvJenisKamar.DataSource = dt;
            dgvJenisKamar.Columns[0].HeaderText = "ID Jenis Kamar";
            dgvJenisKamar.Columns[1].HeaderText = "Nama Jenis Kamar";
            dgvJenisKamar.Columns[2].HeaderText = "Harga Jenis Kamar";
            dgvJenisKamar.Columns[3].HeaderText = "Status";
            dgvJenisKamar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvJenisKamar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvJenisKamar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvJenisKamar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvJenisKamar = UpdateDataGridViewFont(dgvJenisKamar, 16F);
            dgvJenisKamar.ClearSelection();
        }

        public void resetTampilan()
        {
            tbID.Text = "";
            tbNama.Text = "";
            tbHarga.Text = "";
            rb1.Checked = true;
            selectedIdx = -1;
            generateID();
        }

        public void generateID()
        {
            query = "SELECT COUNT(*) FROM jenis_kamar";
            cmd = new MySqlCommand(query, conn);
            int jumlah = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            jumlah++;
            tbID.Text = jumlah.ToString();
        }

        private void dgvJenisKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdx = dgvJenisKamar.CurrentCell.RowIndex;
            id_jk = Convert.ToInt32(dgvJenisKamar.Rows[selectedIdx].Cells[0].Value.ToString());
            tbID.Text = dgvJenisKamar.Rows[selectedIdx].Cells[0].Value.ToString();
            tbNama.Text = dgvJenisKamar.Rows[selectedIdx].Cells[1].Value.ToString();
            cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT harga_jenis_kamar FROM jenis_kamar WHERE id_jenis_kamar = '{tbID.Text}'";
            cmd.Connection = conn;
            tbHarga.Text = cmd.ExecuteScalar().ToString();
            if (dgvJenisKamar.Rows[selectedIdx].Cells[3].Value.ToString() == "Tersedia")
            {
                rb1.Checked = true;
            }
            else
            {
                rb0.Checked = true;
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            resetTampilan();
            refreshDGV();
            tbCari.Text = "";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdx > -1)
            {
                // int status;
                // if (rb1.Checked)
                // {
                //     status = 1;
                // }
                // else
                // {
                //     status = 0;
                // }
                query = $"UPDATE jenis_kamar SET status_jenis_kamar = 99 WHERE id_jenis_kamar = '{tbID.Text}'";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus jenis kamar");
                refreshDGV();
                resetTampilan();
            }
            else
            {
                MessageBox.Show("Tidak bisa menghapus jenis kamar");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (selectedIdx > -1)
            {
                //untuk update atau delete
                MessageBox.Show("Tidak bisa insert di data yang sudah ada di database");
            }
            else
            {
                if (tbNama.Text == "" || tbHarga.Text == "")
                {
                    MessageBox.Show("Semua field harus terisi");
                }
                else
                {
                    int harga;
                    if (!int.TryParse(tbHarga.Text, out harga))
                    {
                        MessageBox.Show("Harga harus angka");
                    }
                    else if (harga < 0)
                    {
                        MessageBox.Show("Harga minimalnya adalah 0");
                    }
                    else
                    {
                        int status;
                        if (rb1.Checked)
                        {
                            status = 1;
                        }
                        else
                        {
                            status = 0;
                        }
                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = $"SELECT COUNT(*) FROM jenis_kamar WHERE nama_jenis_kamar = '{tbNama.Text}'";
                        int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        if (count > 0)
                        {
                            cmd.CommandText = $"SELECT id_jenis_kamar FROM jenis_kamar WHERE nama_jenis_kamar = '{tbNama.Text}'";
                            int id_lama = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                            cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = $"UPDATE jenis_kamar SET status_jenis_kamar = 1 WHERE id_jenis_kamar = '{id_lama}'";
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd.CommandText = "INSERT INTO jenis_kamar (id_jenis_kamar, nama_jenis_kamar, harga_jenis_kamar, total_penyewaan, status_jenis_kamar) VALUES (@id, @nama, @harga, @sewa, @status)";
                            cmd.Parameters.Add(new MySqlParameter("@id", tbID.Text));
                            cmd.Parameters.Add(new MySqlParameter("@nama", tbNama.Text));
                            cmd.Parameters.Add(new MySqlParameter("@harga", harga));
                            cmd.Parameters.Add(new MySqlParameter("@sewa", 0));
                            cmd.Parameters.Add(new MySqlParameter("@status", status));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Berhasil menambah jenis kamar baru");
                        refreshDGV();
                        resetTampilan();
                    }
                }

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedIdx > -1)
            {
                int harga;
                if (!int.TryParse(tbHarga.Text, out harga))
                {
                    MessageBox.Show("Harga harus angka");
                }
                else if (harga < 0)
                {
                    MessageBox.Show("Harga minimalnya adalah 0");
                }
                else
                {
                    int status;
                    if (rb1.Checked)
                    {
                        status = 1;
                    }
                    else
                    {
                        status = 0;
                    }
                    query = $"UPDATE jenis_kamar SET nama_jenis_kamar = '{tbNama.Text}', harga_jenis_kamar = '{tbHarga.Text}', status_jenis_kamar = '{status}' WHERE id_jenis_kamar = '{tbID.Text}'";
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengubah jenis kamar");
                    refreshDGV();
                    resetTampilan();
                }

            }
            else
            {
                MessageBox.Show("Tidak bisa mengubah jenis kamar");
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
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            searchDGV(tbCari.Text);
        }

        private void btnFasilitas_Click(object sender, EventArgs e)
        {
            if(selectedIdx > -1)
            {
                this.Hide();
                FormDetailFasilitasJenisKamar form = new FormDetailFasilitasJenisKamar(this);
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Silahkan pilih terlebih dulu");
            }
        }
    }
}
