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
            hitungSubtotal();
        }


        public void isiKodeReservasidanNamaTamu()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT hr.kode_reservasi FROM header_reservasi hr JOIN detail_reservasi dr ON dr.kode_reservasi = hr.kode_reservasi WHERE id_detail_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblKodeReservasi.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = $"SELECT nama_tamu FROM header_reservasi hr JOIN tamu t ON t.kode_tamu = hr.kode_tamu JOIN detail_reservasi dr ON dr.kode_reservasi = hr.kode_reservasi WHERE id_detail_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblNamaTamu.Text = cmd.ExecuteScalar().ToString();
            
            cmd.CommandText = $"SELECT nomor_kamar FROM header_reservasi hr  JOIN detail_reservasi dr ON dr.kode_reservasi = hr.kode_reservasi JOIN kamar k ON k.kode_kamar = dr.kode_kamar WHERE id_detail_reservasi = '{id_reservasi}'";
            cmd.Connection = conn;
            lblNoKamar.Text = cmd.ExecuteScalar().ToString();
        }



        public void refreshDGV()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id_extra_fasilitas, nama_extra_fasilitas, stok_extra_fasilitas, CONCAT('Rp ', FORMAT(harga_extra_fasilitas,0,'de_DE')) FROM extra_fasilitas WHERE status_extra_fasilitas = 1";
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

        public void searchDGV(string keyword)
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT id_extra_fasilitas, nama_extra_fasilitas, stok_extra_fasilitas, CONCAT('Rp ', FORMAT(harga_extra_fasilitas,0,'de_DE')) FROM extra_fasilitas WHERE status_extra_fasilitas = 1 AND nama_extra_fasilitas LIKE '%{keyword}%'";
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
            hitungSubtotal();
        }

        public void hitungSubtotal()
        {
            int subtotal = 0;
            for (int i = 0; i < dgvKeranjang.Rows.Count; i++)
            {
                cmd = new MySqlCommand();
                cmd.CommandText = $"select harga_extra_fasilitas from extra_fasilitas where id_extra_fasilitas = '{dgvKeranjang.Rows[i].Cells[0].Value}'";
                cmd.Connection = conn;
                int harga = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                int jumlah = Convert.ToInt32(dgvKeranjang.Rows[i].Cells[3].Value.ToString());
                subtotal += (jumlah * harga);

            }
            // tbSubtotal.Text = subtotal.ToString();
            decimal number;
            number = decimal.Parse(subtotal.ToString(), System.Globalization.NumberStyles.Currency);
            tbSubtotal.Text = number.ToString("#,#");
            tbSubtotal.SelectionStart = tbSubtotal.Text.Length;
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
            hitungSubtotal();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(selectedIdxKeranjang > -1)
            {
                dgvKeranjang.Rows.RemoveAt(selectedIdxKeranjang);
            }
            hitungSubtotal();
        }

        private void dgvKeranjang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvKeranjang.Rows.Count > 0)
            {
                selectedIdxKeranjang = dgvKeranjang.CurrentCell.RowIndex;
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                int id_header;
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT COUNT(*) FROM header_extra_fasilitas WHERE kode_reservasi = '{lblKodeReservasi.Text}'";
                int jml = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if(jml > 0)
                {
                    // sudah ada di header
                    cmd.CommandText = $"SELECT id_header_extra_fasilitas FROM header_extra_fasilitas WHERE kode_reservasi = '{lblKodeReservasi.Text}'";
                    id_header = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }
                else
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM header_extra_fasilitas";
                    id_header = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    id_header++;
                    // belum ada di header
                    cmd.CommandText = "INSERT INTO header_extra_fasilitas (id_header_extra_fasilitas, kode_reservasi, total_biaya_extra_fasilitas) VALUES (@id_header, @kode_res, 0)";
                    cmd.Parameters.Add(new MySqlParameter("@id_header", id_header));
                    cmd.Parameters.Add(new MySqlParameter("@kode_res", lblKodeReservasi.Text));
                    cmd.ExecuteNonQuery();
                }
                for (int i = 0; i < dgvKeranjang.RowCount; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = $"SELECT harga_extra_fasilitas from extra_fasilitas WHERE id_extra_fasilitas = '{dgvKeranjang.Rows[i].Cells[0].Value}'";
                    cmd.Connection = conn;
                    int harga = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(*) FROM detail_extra_fasilitas";
                    int new_id_use = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    new_id_use++;

                    cmd.CommandText = $"SELECT kode_kamar FROM kamar WHERE nomor_kamar = '{lblNoKamar.Text}'";
                    string kode_kamar = cmd.ExecuteScalar().ToString();

                    int subtotal = harga * Convert.ToInt32(dgvKeranjang.Rows[i].Cells[3].Value.ToString());

                    cmd.CommandText = "INSERT INTO detail_extra_fasilitas (id_detail_extra_fasilitas, id_header_extra_fasilitas, kode_kamar, id_extra_fasilitas, jumlah_extra_fasilitas, subtotal_extra_fasilitas, status_detail) VALUES (@id_use, @id_header, @kode_kamar, @id_extra, @jumlah, @subtotal,1)";
                    cmd.Parameters.Add(new MySqlParameter("@id_use", new_id_use));
                    cmd.Parameters.Add(new MySqlParameter("@id_header", id_header));
                    cmd.Parameters.Add(new MySqlParameter("@kode_kamar", kode_kamar));
                    cmd.Parameters.Add(new MySqlParameter("@id_extra", Convert.ToInt32(dgvKeranjang.Rows[i].Cells[0].Value.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@jumlah", Convert.ToInt32(dgvKeranjang.Rows[i].Cells[3].Value.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@subtotal", subtotal));
                    cmd.ExecuteNonQuery();

                    int id_extra = Convert.ToInt32(dgvKeranjang.Rows[i].Cells[0].Value.ToString());
                    int jumlah = Convert.ToInt32(dgvKeranjang.Rows[i].Cells[3].Value.ToString());

                    cmd.CommandText = $"SELECT stok_extra_fasilitas FROM extra_fasilitas WHERE id_extra_fasilitas = '{id_extra}'";
                    int stok_baru = Convert.ToInt32(cmd.ExecuteScalar().ToString()) - jumlah;

                    cmd.CommandText = $"UPDATE extra_fasilitas SET stok_extra_fasilitas = '{stok_baru}' WHERE id_extra_fasilitas = '{id_extra}'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"SELECT total_biaya_extra_fasilitas FROM header_extra_fasilitas WHERE kode_reservasi = '{lblKodeReservasi.Text}'";
                    int total_biaya_baru = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + subtotal;

                    cmd.CommandText = $"UPDATE header_extra_fasilitas SET total_biaya_extra_fasilitas = '{total_biaya_baru}' WHERE kode_reservasi = '{lblKodeReservasi.Text}'";
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
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            searchDGV(tbCari.Text);
        }

        private void btnBersihkan2_Click(object sender, EventArgs e)
        {
            selectedIdxFasilitas = -1;
            selectedIdxKeranjang = -1;
            refreshDGV();
            resetField();
            tbCari.Text = "";
        }

        private void FormPenambahanFasilitasKamar_Load(object sender, EventArgs e)
        {
            dgvFasilitas.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dgvFasilitas.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvFasilitas.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dgvKeranjang.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dgvKeranjang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvKeranjang.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
        }     

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if(selectedIdxFasilitas > -1)
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
                            cmd = new MySqlCommand();
                            cmd.CommandText = $"SELECT harga_extra_fasilitas FROM extra_fasilitas WHERE id_extra_fasilitas = '{tbID.Text}'";
                            cmd.Connection = conn;
                            int harga = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                            cmd = new MySqlCommand();
                            cmd.CommandText = $"SELECT CONCAT('Rp ', FORMAT({numJumlah.Value * Convert.ToInt32(harga)},0,'de_DE')) FROM DUAL";
                            cmd.Connection = conn;
                            dgvKeranjang.Rows[idxRow].Cells[4].Value = cmd.ExecuteScalar().ToString();
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
                            cmd.CommandText = $"SELECT harga_extra_fasilitas FROM extra_fasilitas WHERE id_extra_fasilitas = '{tbID.Text}'";
                            cmd.Connection = conn;
                            int harga = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                            cmd = new MySqlCommand();
                            cmd.CommandText = $"SELECT CONCAT('Rp ', FORMAT({jumlah * Convert.ToInt32(harga)},0,'de_DE')) FROM DUAL";
                            cmd.Connection = conn;
                            dgvKeranjang.Rows[idxRow].Cells[4].Value = cmd.ExecuteScalar().ToString();
                            resetField();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Jumlah harus lebih besar dari 0");
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih fasilitas terlebih dahulu");
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
