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
    public partial class FormDataTambahanFasilitasKamar : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        DataTable dt;
        int selectedIdx = -1;
        public FormDataTambahanFasilitasKamar()
        {
            Koneksi.openConn();
            conn = Koneksi.conn;
            InitializeComponent();
            rb1.Checked = true;
            resetTampilan();
            refreshDGV();
        }

        public void refreshDGV()
        {
            dt = new DataTable();
            query = "SELECT id_extra_fasilitas,nama_extra_fasilitas,stok_extra_fasilitas,harga_extra_fasilitas, IF(status_extra_fasilitas = 1, 'Tersedia', 'Tidak Tersedia') FROM extra_fasilitas ORDER BY 1";
            cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvFasilitas.DataSource = dt;
            dgvFasilitas.Columns[0].HeaderText = "ID Fasilitas";
            dgvFasilitas.Columns[1].HeaderText = "Nama Fasilitas";
            dgvFasilitas.Columns[2].HeaderText = "Stok Fasilitas";
            dgvFasilitas.Columns[3].HeaderText = "Harga Fasilitas";
            dgvFasilitas.Columns[4].HeaderText = "Status Fasilitas";
            dgvFasilitas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFasilitas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            selectedIdx = -1;
        }

        public void resetTampilan()
        {
            tbID.Text = "";
            tbHarga.Text = "";
            tbStok.Text = "";
            tbNama.Text = "";
            selectedIdx = -1;
            generateID();
        }

        public void generateID()
        {
            query = "SELECT COUNT(*) FROM extra_fasilitas";
            cmd = new MySqlCommand(query, conn);
            int jumlah = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            jumlah++;
            tbID.Text = jumlah.ToString();
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
                if(tbNama.Text == "" || tbHarga.Text == "" || tbStok.Text == "")
                {
                    MessageBox.Show("Semua field harus terisi");
                }
                else
                {
                    int harga;
                    if (!int.TryParse(tbHarga.Text, out harga))
                    {
                        // cek harga
                        MessageBox.Show("Harga harus angka");
                    }
                    else if (harga < 0)
                    {
                        MessageBox.Show("Harga minimalnya adalah 0");
                    }
                    else
                    {
                        int stok;
                        if (!int.TryParse(tbStok.Text, out stok))
                        {
                            // cek stok
                            MessageBox.Show("Stok harus angka");
                        }
                        else if (stok < 0)
                        {
                            MessageBox.Show("Stok minimalnya adalah 0");
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
                            cmd.CommandText = $"SELECT COUNT(*) FROM extra_fasilitas WHERE nama_extra_fasilitas = '{tbNama.Text}'";
                            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                            cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            if (count > 0)
                            {
                                // ambil id lama
                                cmd.CommandText = $"SELECT id_extra_fasilitas FROM extra_fasilitas WHERE nama_extra_fasilitas = '{tbNama.Text}'";
                                int id_lama = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                                // updata yg lama
                                cmd.CommandText = $"UPDATE extra_fasilitas SET status_extra_fasilitas = 1 WHERE id_extra_fasilitas = '{id_lama}'";
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd.CommandText = "INSERT INTO extra_fasilitas (id_extra_fasilitas, nama_extra_fasilitas, stok_extra_fasilitas, harga_extra_fasilitas, status_extra_fasilitas) VALUES (@id, @nama, @stok, @harga, @status)";
                                cmd.Parameters.Add(new MySqlParameter("@id", tbID.Text));
                                cmd.Parameters.Add(new MySqlParameter("@nama", tbNama.Text));
                                cmd.Parameters.Add(new MySqlParameter("@stok", tbStok.Text));
                                cmd.Parameters.Add(new MySqlParameter("@harga", tbHarga.Text));
                                cmd.Parameters.Add(new MySqlParameter("@status", status));
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Berhasil menambah tambahan fasilitas baru");
                            refreshDGV();
                            resetTampilan();
                        }
                    }
                }
                
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedIdx > -1)
            {
                if(tbNama.Text == "" || tbHarga.Text == "" || tbStok.Text == "")
                {
                    MessageBox.Show("Semua field harus terisi");
                }
                else
                {
                    int harga;
                    if (!int.TryParse(tbHarga.Text, out harga))
                    {
                        // cek harga
                        MessageBox.Show("Harga harus angka");
                    }
                    else if (harga < 0)
                    {
                        MessageBox.Show("Harga minimalnya adalah 0");
                    }
                    else
                    {
                        int stok;
                        if (!int.TryParse(tbStok.Text, out stok))
                        {
                            // cek harga
                            MessageBox.Show("Stok harus angka");
                        }
                        else if (stok < 0)
                        {
                            MessageBox.Show("Stok minimalnya adalah 0");
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
                            query = $"UPDATE extra_fasilitas SET nama_extra_fasilitas = '{tbNama.Text}', stok_extra_fasilitas = '{tbStok.Text}', harga_extra_fasilitas = '{tbHarga.Text}', status_extra_fasilitas = '{status}' WHERE id_extra_fasilitas = '{tbID.Text}'";
                            cmd = new MySqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Berhasil mengubah tambahan fasilitas");
                            refreshDGV();
                            resetTampilan();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tidak bisa mengubah tambahan fasilitas");
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            resetTampilan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdx > -1)
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
                query = $"UPDATE extra_fasilitas SET nama_extra_fasilitas = '{tbNama.Text}', stok_extra_fasilitas = '{tbStok.Text}', harga_extra_fasilitas = '{tbHarga.Text}', status_extra_fasilitas = '{status}' WHERE id_extra_fasilitas = '{tbID.Text}'";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengubah extra fasilitas");
                refreshDGV();
                resetTampilan();
            }
            else
            {
                MessageBox.Show("Tidak bisa mengubah extra fasilitas");
            }
        }

        private void dgvFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdx = dgvFasilitas.CurrentCell.RowIndex;
            tbID.Text = dgvFasilitas.Rows[selectedIdx].Cells[0].Value.ToString();
            tbNama.Text = dgvFasilitas.Rows[selectedIdx].Cells[1].Value.ToString();
            tbStok.Text = dgvFasilitas.Rows[selectedIdx].Cells[2].Value.ToString();
            tbHarga.Text = dgvFasilitas.Rows[selectedIdx].Cells[3].Value.ToString();
            if (dgvFasilitas.Rows[selectedIdx].Cells[4].Value.ToString() == "Tersedia")
            {
                rb1.Checked = true;
            }
            else
            {
                rb0.Checked = true;
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
