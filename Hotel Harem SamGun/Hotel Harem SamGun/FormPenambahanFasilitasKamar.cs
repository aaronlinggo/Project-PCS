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
    public partial class FormPenambahanFasilitasKamar : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        DataTable dt;
        int id_reservasi, selectedIdxFasilitas = -1, selectedIdxKeranjang = -1;
        FormPenambahanFasilitasDataTamu formLama;
        public FormPenambahanFasilitasKamar(FormPenambahanFasilitasDataTamu formLama)
        {
            Koneksi.openConn();
            conn = Koneksi.conn;
            InitializeComponent();
            this.formLama = formLama;
            id_reservasi = formLama.id_reservasi;
            isiKodeReservasidanNamaTamu();
            refreshDGV();
        }


        public void isiKodeReservasidanNamaTamu()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT kode_reservasi FROM reservasi WHERE id_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblKodeReservasi.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = $"SELECT nama_tamu FROM reservasi r JOIN tamu t ON t.kode_tamu = r.kode_tamu WHERE id_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblNamaTamu.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = $"SELECT nomor_kamar FROM reservasi r JOIN kamar k ON k.kode_kamar = r.kode_kamar WHERE id_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblNoKamar.Text = cmd.ExecuteScalar().ToString();
        }



        public void refreshDGV()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id_extra_fasilitas, nama_extra_fasilitas, stok_extra_fasilitas, harga_extra_fasilitas FROM extra_fasilitas WHERE status_extra_fasilitas = 1";
            dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvFasilitas.DataSource = dt;
            dgvFasilitas.Columns[0].HeaderText = "ID";
            dgvFasilitas.Columns[1].HeaderText = "Nama Fasilitas";
            dgvFasilitas.Columns[2].HeaderText = "Stok";
            dgvFasilitas.Columns[3].HeaderText = "Harga";
            dgvFasilitas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFasilitas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFasilitas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        public void resetField()
        {
            selectedIdxFasilitas = -1;
            selectedIdxKeranjang = -1;
            tbID.Text = "";
            tbNama.Text = "";
            tbHarga.Text = "";
            numJumlah.Value = 0;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            formLama.refreshDGV();
            formLama.Show();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            dgvKeranjang.Rows.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            dgvKeranjang.Rows.RemoveAt(selectedIdxKeranjang);
        }

        private void dgvKeranjang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdxKeranjang = dgvKeranjang.CurrentCell.RowIndex;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                for (int i = 0; i < dgvKeranjang.RowCount; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT COUNT(*) FROM use_extra_fasilitas";
                    int new_id_use = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    new_id_use++;

                    cmd.CommandText = $"SELECT kode_tamu FROM tamu WHERE nama_tamu = '{lblNamaTamu.Text}'";
                    string kode_tamu = cmd.ExecuteScalar().ToString();

                    cmd.CommandText = $"SELECT kode_kamar FROM kamar WHERE nomor_kamar = '{lblNoKamar.Text}'";
                    string kode_kamar = cmd.ExecuteScalar().ToString();

                    cmd.CommandText = "INSERT INTO use_extra_fasilitas (id_use_extra_fasilitas, kode_kamar, kode_tamu, id_extra_fasilitas, jumlah_extra_fasilitas, subtotal_extra_fasilitas) VALUES (@id_use, @kode_kamar, @kode_tamu, @id_extra, @jumlah, @subtotal)";
                    cmd.Parameters.Add(new MySqlParameter("@id_use", new_id_use));
                    cmd.Parameters.Add(new MySqlParameter("@kode_kamar", kode_kamar));
                    cmd.Parameters.Add(new MySqlParameter("@kode_tamu", kode_tamu));
                    cmd.Parameters.Add(new MySqlParameter("@id_extra", Convert.ToInt32(dgvKeranjang.Rows[i].Cells[0].Value.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@jumlah", Convert.ToInt32(dgvKeranjang.Rows[i].Cells[3].Value.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@subtotal", Convert.ToInt32(dgvKeranjang.Rows[i].Cells[4].Value.ToString())));
                    cmd.ExecuteNonQuery();

                    int id_extra = Convert.ToInt32(dgvKeranjang.Rows[i].Cells[0].Value.ToString());
                    int jumlah = Convert.ToInt32(dgvKeranjang.Rows[i].Cells[3].Value.ToString());

                    cmd.CommandText = $"SELECT stok_extra_fasilitas FROM extra_fasilitas WHERE id_extra_fasilitas = '{id_extra}'";
                    int stok_baru = Convert.ToInt32(cmd.ExecuteScalar().ToString()) - jumlah;

                    cmd.CommandText = $"UPDATE extra_fasilitas SET stok_extra_fasilitas = '{stok_baru}' WHERE id_extra_fasilitas = '{id_extra}'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"SELECT total_biaya FROM reservasi WHERE kode_reservasi = '{lblKodeReservasi.Text}'";
                    int total_biaya_baru = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + Convert.ToInt32(dgvKeranjang.Rows[i].Cells[4].Value.ToString());

                    cmd.CommandText = $"UPDATE reservasi SET total_biaya = '{total_biaya_baru}' WHERE kode_reservasi = '{lblKodeReservasi.Text}'";
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                MessageBox.Show("Transaksi Berhasil");
                dgvKeranjang.Rows.Clear();
                resetField();
                refreshDGV();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Gagal melakukan transaksi");
                trans.Rollback();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (numJumlah.Value > 0)
            {
                int idxRow = -1;
                for (int i = 0; i < dgvKeranjang.Rows.Count; i++)
                {
                    if (tbID.Text == dgvKeranjang.Rows[i].Cells[0].Value.ToString())
                    {
                        idxRow = i;
                    }
                }

                if (idxRow == -1)
                {
                    int stok = Convert.ToInt32(dgvFasilitas.Rows[selectedIdxFasilitas].Cells[2].Value.ToString());
                    int jumlah = Convert.ToInt32(numJumlah.Value.ToString());
                    if (jumlah > stok)
                    {
                        MessageBox.Show("Stok tidak mencukupi");
                    }
                    else
                    {
                        idxRow = dgvKeranjang.Rows.Add();
                        dgvKeranjang.Rows[idxRow].Cells[0].Value = tbID.Text;
                        dgvKeranjang.Rows[idxRow].Cells[1].Value = tbNama.Text;
                        dgvKeranjang.Rows[idxRow].Cells[2].Value = tbHarga.Text;
                        dgvKeranjang.Rows[idxRow].Cells[3].Value = numJumlah.Value;
                        dgvKeranjang.Rows[idxRow].Cells[4].Value = (numJumlah.Value * Convert.ToInt32(tbHarga.Text));
                        resetField();
                    }
                }
                else
                {
                    int stok = Convert.ToInt32(dgvFasilitas.Rows[selectedIdxFasilitas].Cells[2].Value.ToString());
                    int jumlah = Convert.ToInt32(numJumlah.Value.ToString()) + Convert.ToInt32(dgvKeranjang.Rows[idxRow].Cells[3].Value.ToString());
                    if (jumlah > stok)
                    {
                        MessageBox.Show("Stok tidak mencukupi");
                    }
                    else
                    {
                        dgvKeranjang.Rows[idxRow].Cells[3].Value = jumlah;
                        dgvKeranjang.Rows[idxRow].Cells[4].Value = (Convert.ToInt32(dgvKeranjang.Rows[idxRow].Cells[3].Value.ToString()) * Convert.ToInt32(tbHarga.Text));
                        resetField();
                    }
                }
            }
            else
            {
                MessageBox.Show("Jumlah harus lebih besar dari 0");
            }
        }

        private void dgvFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdxFasilitas = dgvFasilitas.CurrentCell.RowIndex;
            tbID.Text = dgvFasilitas.Rows[selectedIdxFasilitas].Cells[0].Value.ToString();
            tbNama.Text = dgvFasilitas.Rows[selectedIdxFasilitas].Cells[1].Value.ToString();
            tbHarga.Text = dgvFasilitas.Rows[selectedIdxFasilitas].Cells[3].Value.ToString();
        }
    }
}
