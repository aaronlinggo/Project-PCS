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
    public partial class FormReservasi : Form
    {
        DataTable dtHeaderReservasi;
        MySqlDataAdapter da;

        public FormReservasi()
        {
            InitializeComponent();
        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            refresh_cbCari_dgvHeaderReservasi();
            ResetAll();
            dgvHeaderReservasi.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dgvHeaderReservasi.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvHeaderReservasi.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
        }

        private void fillDT(DataTable dt, string query)
        {
            try
            {
                dgvHeaderReservasi.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvHeaderReservasi.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dgvHeaderReservasi.EnableHeadersVisualStyles = false;
                da = new MySqlDataAdapter(query, Koneksi.conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void loadHeaderReservasi(int status)
        {
            dtHeaderReservasi = new DataTable();
            string query = @"
                    SELECT CONCAT(t.nama_tamu, ' - ', kode_reservasi) AS nama_kode, kode_reservasi, t.nama_tamu, CONCAT('Rp ', FORMAT(total_biaya_reservasi, 0, 'de_DE')), total_biaya_reservasi, k.nama_karyawan, status_header_reservasi
                    FROM header_reservasi hr
                    JOIN tamu t ON t.kode_tamu = hr.kode_tamu
                    JOIN karyawan k ON k.kode_karyawan = hr.kode_karyawan";
            if (status == 0)
            {
                // SELESAI
                query += " WHERE status_header_reservasi = 0";
            }
            else if (status == 1)
            {
                // SEDANG BERLANGSUNG
                query += " WHERE status_header_reservasi = 1";
            }
            else if (status == 2)
            {
                // DIBATALKAN
                query += " WHERE status_header_reservasi = 99";
            }
            query += " ORDER BY id_header_reservasi";
            fillDT(dtHeaderReservasi, query);
        }

        private void refresh_cbCari_dgvHeaderReservasi(int status = -1)
        {
            dgvHeaderReservasi.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvHeaderReservasi.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvHeaderReservasi.EnableHeadersVisualStyles = false;
            loadHeaderReservasi(status);
            cbCari.DataSource = dtHeaderReservasi;
            cbCari.DisplayMember = "nama_kode";
            cbCari.ValueMember = "kode_reservasi";
            cbCari.SelectedIndex = -1;

            dgvHeaderReservasi.DataSource = dtHeaderReservasi;
            dgvHeaderReservasi.Columns[0].Visible = false;
            dgvHeaderReservasi.Columns[1].HeaderText = "Kode Reservasi";
            dgvHeaderReservasi.Columns[2].HeaderText = "Nama Tamu";
            dgvHeaderReservasi.Columns[3].HeaderText = "Total Biaya Reservasi";
            dgvHeaderReservasi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHeaderReservasi.Columns[4].Visible = false;
            dgvHeaderReservasi.Columns[5].HeaderText = "Nama Karyawan";
            dgvHeaderReservasi.Columns[6].Visible = false;

            //DISABLE SORT
            foreach (DataGridViewColumn col in dgvHeaderReservasi.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //COLOR
            foreach (DataGridViewRow row in dgvHeaderReservasi.Rows)
            {

                if (row.Cells[6].Value.ToString() == "0")
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else if (row.Cells[6].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }

            dgvHeaderReservasi.ClearSelection();
        }

        private void ResetAll()
        {
            cbStatus.SelectedIndex = -1;
            cbCari.SelectedIndex = -1;

            lbKodeReservasi.Text = "-";
            lbNamaTamu.Text = "-";
            lbJumlahReservasi.Text = "-";
            lbTotalBiayaReservasi.Text = "-";
        }

        private void btCari_Click(object sender, EventArgs e)
        {
            if (cbCari.SelectedIndex != -1)
            {
                fillInput("cari");
            }
        }

        private void dgvHeaderReservasi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                fillInput("dgv");
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_cbCari_dgvHeaderReservasi(cbStatus.SelectedIndex);
        }

        private void btBersihkan_Click(object sender, EventArgs e)
        {
            dgvHeaderReservasi.ClearSelection();
            ResetAll();
        }

        private void fillInput(string asal)
        {
            if (asal == "cari")
            {
                dgvHeaderReservasi.Rows[cbCari.SelectedIndex].Selected = true;
            }

            lbKodeReservasi.Text = dgvHeaderReservasi.SelectedRows[0].Cells[1].Value.ToString();
            lbNamaTamu.Text = dgvHeaderReservasi.SelectedRows[0].Cells[2].Value.ToString();
            lbJumlahReservasi.Text = getJumlahReservasi().ToString();
            lbTotalBiayaReservasi.Text = $"{dgvHeaderReservasi.SelectedRows[0].Cells[3].Value}";
        }

        private int getJumlahReservasi()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM detail_reservasi WHERE kode_reservasi = @KodeReservasi";
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.conn);
                cmd.Parameters.AddWithValue("@KodeReservasi", lbKodeReservasi.Text);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return 0;
            }
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBuatReservasi_Click(object sender, EventArgs e)
        {
            Hide();
            FormDetailReservasi form = new FormDetailReservasi();
            form.ShowDialog();
            FormReservasi_Load(sender, e);
            Show();
        }
    }
}