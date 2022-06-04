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
    public partial class FormDataKamar : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        DataTable dt;
        int selectedIdx = -1;
        public string fontName = "Gill Sans MT";

        public FormDataKamar()
        {
            InitializeComponent();
            rb1.Checked = true;
            conn = new MySqlConnection();
            Koneksi.openConn();
            conn = Koneksi.conn;
            refreshDGV();
            isiComboKategori();
            comboJenisKamar.SelectedIndex = 0;
            tbNoKamar.Text = $"{numLantai.Value}" + ($"{numKamarKe.Value}").PadLeft(2, '0');
            generateID();
            generateKode();
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

        public void resetTampilan()
        {
            tbID.Text = "-";
            comboJenisKamar.SelectedIndex = 0;
            numKamarKe.Value = 0;
            numLantai.Value = 0;
            rb1.Checked = true;
            tbKode.Text = "-";
            tbNoKamar.Text = "-";
            selectedIdx = -1;
        }

        public void refreshDGV()
        {
            dgvKamar.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvKamar.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvKamar.EnableHeadersVisualStyles = false;

            dt = new DataTable();
            query = "SELECT id_kamar, kode_kamar, nomor_kamar, nomor_lantai, nama_jenis_kamar, CONCAT('Rp ', FORMAT(harga_jenis_kamar,0,'de_DE')), IF(status_kamar=1,'Tersedia','Tidak tersedia') FROM kamar k JOIN jenis_kamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar ORDER BY id_kamar";
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvKamar.DataSource = dt;
            dgvKamar.Columns[0].HeaderText = "ID Kamar";
            dgvKamar.Columns[1].HeaderText = "Kode Kamar";
            dgvKamar.Columns[2].HeaderText = "Nomor Kamar";
            dgvKamar.Columns[3].HeaderText = "Lantai";
            dgvKamar.Columns[4].HeaderText = "Jenis Kamar";
            dgvKamar.Columns[5].HeaderText = "Harga Kamar";
            dgvKamar.Columns[6].HeaderText = "Status Kamar";
            dgvKamar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKamar.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            selectedIdx = -1;
            dgvKamar = UpdateDataGridViewFont(dgvKamar, 16F);
        }

        public void searchDGV(string keyword)
        {
            dt = new DataTable();
            query = $"SELECT id_kamar, kode_kamar, nomor_kamar, nomor_lantai, nama_jenis_kamar, CONCAT('Rp ', FORMAT(harga_jenis_kamar,0,'de_DE')), IF(status_kamar=1,'Tersedia','Tidak tersedia') FROM kamar k JOIN jenis_kamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar WHERE nama_jenis_kamar LIKE '%{keyword}%' ORDER BY id_kamar";
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvKamar.DataSource = dt;
            dgvKamar.Columns[0].HeaderText = "ID Kamar";
            dgvKamar.Columns[1].HeaderText = "Kode Kamar";
            dgvKamar.Columns[2].HeaderText = "Nomor Kamar";
            dgvKamar.Columns[3].HeaderText = "Lantai";
            dgvKamar.Columns[4].HeaderText = "Jenis Kamar";
            dgvKamar.Columns[5].HeaderText = "Harga Kamar";
            dgvKamar.Columns[6].HeaderText = "Status Kamar";
            dgvKamar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKamar.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKamar.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            selectedIdx = -1;
        }
        public void isiComboKategori()
        {
            query = "SELECT id_jenis_kamar, nama_jenis_kamar FROM jenis_kamar ORDER BY 1";
            dt = new DataTable();
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            comboJenisKamar.DataSource = dt;
            comboJenisKamar.DisplayMember = "nama_jenis_kamar";
            comboJenisKamar.ValueMember = "id_jenis_kamar";
        }

        public void generateID()
        {
            query = "SELECT COUNT(*) FROM kamar";
            cmd = new MySqlCommand(query, conn);
            int jumlah = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            jumlah++;
            tbID.Text = jumlah.ToString();
        }

        public void generateKode()
        {
            query = $"SELECT CONCAT(UPPER(SUBSTR(nama_jenis_kamar,1,2)) , UPPER(SUBSTR(nama_jenis_kamar,INSTR(nama_jenis_kamar, ' ')+1,1))) FROM jenis_kamar WHERE id_jenis_kamar = '{comboJenisKamar.SelectedIndex + 1}'";
            cmd = new MySqlCommand(query, conn);
            tbKode.Text = cmd.ExecuteScalar().ToString() + tbNoKamar.Text;
        }
        private void numLantai_ValueChanged(object sender, EventArgs e)
        {
            if (selectedIdx == -1)
            {
                generateID();
            }
            tbNoKamar.Text = $"{numLantai.Value}" + ($"{numKamarKe.Value}").PadLeft(2, '0');
            generateKode();
        }

        private void numNoKamar_ValueChanged(object sender, EventArgs e)
        {
            if (selectedIdx == -1)
            {
                generateID();
            }
            tbNoKamar.Text = $"{numLantai.Value}" + ($"{numKamarKe.Value}").PadLeft(2, '0');
            generateKode();
        }

        private void dgvKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdx = dgvKamar.CurrentCell.RowIndex;
            tbID.Text = dgvKamar.Rows[selectedIdx].Cells[0].Value.ToString();
            tbKode.Text = dgvKamar.Rows[selectedIdx].Cells[1].Value.ToString();
            tbNoKamar.Text = dgvKamar.Rows[selectedIdx].Cells[2].Value.ToString();
            numLantai.Value = Convert.ToInt32(dgvKamar.Rows[selectedIdx].Cells[3].Value.ToString());
            numKamarKe.Value = Convert.ToInt32(dgvKamar.Rows[selectedIdx].Cells[2].Value.ToString().Substring(1, 2));
            cmd = new MySqlCommand($"SELECT id_jenis_kamar FROM jenis_kamar WHERE nama_jenis_kamar = '{dgvKamar.Rows[selectedIdx].Cells[4].Value.ToString()}'", conn);
            int id_jenis_kamar = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            comboJenisKamar.SelectedIndex = id_jenis_kamar - 1;
            if (dgvKamar.Rows[selectedIdx].Cells[6].Value.ToString() == "Tersedia")
            {
                rb1.Checked = true;
            }
            else
            {
                rb0.Checked = true;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (selectedIdx > -1)
            {
                //update atau delete
                MessageBox.Show("Tidak bisa insert di data yang sudah ada di database");
            }
            else
            {
                if (numLantai.Value == 0 || numKamarKe.Value == 0)
                {
                    MessageBox.Show("Lantai dan Kamarnya tidak mungkin 0");
                }
                else
                {
                    int nomor_kamar = Convert.ToInt32(tbNoKamar.Text);
                    query = $"SELECT COUNT(*) FROM kamar where nomor_kamar = '{nomor_kamar}'";
                    cmd = new MySqlCommand(query, conn);
                    int jumlah = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (jumlah > 0)
                    {
                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = $"UPDATE kamar SET status_kamar = 1 WHERE nomor_kamar = '{tbNoKamar.Text}'";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // belum ada, boleh insert
                        int status;
                        if (rb1.Checked)
                        {
                            status = 1;
                        }
                        else
                        {
                            status = 99;
                        }
                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO kamar (id_kamar, kode_kamar, nomor_kamar, nomor_lantai, status_kamar, id_jenis_kamar) VALUES (@id, @kode, @nomor, @lantai, @status, @jenis)";
                        cmd.Parameters.Add(new MySqlParameter("@id", tbID.Text));
                        cmd.Parameters.Add(new MySqlParameter("@kode", tbKode.Text));
                        cmd.Parameters.Add(new MySqlParameter("@nomor", tbNoKamar.Text));
                        cmd.Parameters.Add(new MySqlParameter("@lantai", numLantai.Value));
                        cmd.Parameters.Add(new MySqlParameter("@status", status));
                        cmd.Parameters.Add(new MySqlParameter("@jenis", comboJenisKamar.SelectedValue));
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Berhasil menambah kamar baru");
                    refreshDGV();
                    resetTampilan();
                }

            }

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

            if (selectedIdx > -1)
            {
                if (numLantai.Value == 0 || numKamarKe.Value == 0)
                {
                    MessageBox.Show("Lantai dan nomor kamar tidak mungkin 0");
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
                        status = 99;
                    }
                    query = $"UPDATE kamar SET kode_kamar = '{tbKode.Text}', nomor_kamar = '{tbNoKamar.Text}', nomor_lantai = '{numLantai.Value}',status_kamar = '{status}', id_jenis_kamar = '{comboJenisKamar.SelectedValue}' WHERE id_kamar = '{tbID.Text}'";
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengubah kamar");
                    refreshDGV();
                    resetTampilan();
                }
            }
            else
            {
                MessageBox.Show("Tidak bisa mengubah");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdx > -1)
            {
                query = $"UPDATE kamar SET status_kamar = '99' WHERE id_kamar = '{tbID.Text}'";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus kamar");
                refreshDGV();
                resetTampilan();
            }
            else
            {
                MessageBox.Show("Tidak bisa menghapus");
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            resetTampilan();
            refreshDGV();
            tbCari.Text = "";
        }

        private void comboJenisKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateKode();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            searchDGV(tbCari.Text);
        }

        private void FormDataKamar_Load(object sender, EventArgs e)
        {

        }
    }
}
