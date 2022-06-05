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
    public partial class FormPencatatanDataTamu : Form
    {
        DataTable dtTamu;

        public FormPencatatanDataTamu()
        {
            InitializeComponent();
        }

        private void FormPencatatanDataTamu_Load(object sender, EventArgs e)
        {
            refresh_cbCari_dgvTamu();
            changeMode(1);
            dgvTamu.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dgvTamu.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvTamu.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
        }

        private void generateKodeTamu()
        {
            // ADD & EXECUTE PROCEDURE
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = Koneksi.conn;
                cmd.CommandText = @"
                CREATE OR REPLACE PROCEDURE generateKodeTamu(IN nama VARCHAR(255), OUT kode VARCHAR(7))
                BEGIN
	                DECLARE jumlah INT;
	
	                IF INSTR(nama, ' ') = 0 THEN
		                SET kode = UPPER(SUBSTR(nama, 1, 4));
	                ELSE
		                SET kode = UPPER(CONCAT(SUBSTR(nama, 1, 2), SUBSTR(nama, INSTR(nama, ' ') + 1, 2)));
	                END IF;
	
	                SELECT COUNT(*) INTO jumlah FROM tamu WHERE kode_tamu LIKE CONCAT(kode,'%');
	                SET kode = CONCAT(kode, LPAD(jumlah + 1, 3, '0'));
                END";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "generateKodeTamu";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters["@nama"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@kode", MySqlDbType.VarChar);
                cmd.Parameters["@kode"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                lbKodeTamu.Text = cmd.Parameters["@kode"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeMode(int mode)
        {
            if (mode == 1)
            {
                // TAMBAH
                lbKodeTamu.Text = "-";
                tbNama.Text = "";
                rbLakiLaki.Checked = false;
                rbPerempuan.Checked = false;
                dtpTanggalLahir.Value = DateTime.Now;
                tbNegaraAsal.Text = "";
                tbAlamat.Text = "";
                tbNomorTelepon.Text = "";
                tbEmail.Text = "";
                cbStatus.Checked = true;

                tbNama.Enabled = true;
                dtpTanggalLahir.Enabled = true;
                tbNegaraAsal.Enabled = true;

                btTambah.Enabled = true;
                btPerbarui.Enabled = false;

                AcceptButton = btTambah;
            }
            else
            {
                // PERBARUI
                tbNama.Enabled = false;
                dtpTanggalLahir.Enabled = false;
                tbNegaraAsal.Enabled = false;

                btTambah.Enabled = false;
                btPerbarui.Enabled = true;

                AcceptButton = btPerbarui;
            }
        }

        private void loadTamu()
        {
            dgvTamu.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvTamu.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvTamu.EnableHeadersVisualStyles = false;
            dtTamu = new DataTable();
            string query = @"SELECT CONCAT(nama_tamu, ' - ', kode_tamu) AS kode_lengkap, kode_tamu, nama_tamu, CASE WHEN jenis_kelamin_tamu = 'L' THEN 'Laki-laki' ELSE 'Perempuan' END, jenis_kelamin_tamu, DATE_FORMAT(tanggal_lahir_tamu, '%d %M %Y'), tanggal_lahir_tamu, alamat_tamu, negara_asal, nomor_telepon_tamu, email_tamu, CASE WHEN status_tamu = 1 THEN 'Aktif' ELSE 'Non Aktif' END, status_tamu FROM tamu;";
            MySqlDataAdapter da = new MySqlDataAdapter(query, Koneksi.conn);
            da.Fill(dtTamu);
        }

        private void refresh_cbCari_dgvTamu()
        {
            dgvTamu.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvTamu.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvTamu.EnableHeadersVisualStyles = false;
            loadTamu();
            cbCari.DataSource = dtTamu;
            cbCari.DisplayMember = "kode_lengkap";
            cbCari.ValueMember = "kode_tamu";

            dgvTamu.DataSource = dtTamu;
            dgvTamu.Columns[0].Visible = false;
            dgvTamu.Columns[1].HeaderText = "Kode";
            dgvTamu.Columns[2].HeaderText = "Nama";
            dgvTamu.Columns[3].HeaderText = "Jenis Kelamin";
            dgvTamu.Columns[4].Visible = false;
            dgvTamu.Columns[5].HeaderText = "Tanggal Lahir";
            dgvTamu.Columns[6].Visible = false;
            dgvTamu.Columns[7].HeaderText = "Alamat";
            dgvTamu.Columns[8].HeaderText = "Negara Asal";
            dgvTamu.Columns[9].HeaderText = "Nomor Telepon";
            dgvTamu.Columns[10].HeaderText = "Email";
            dgvTamu.Columns[11].HeaderText = "Status";
            dgvTamu.Columns[12].Visible = false;

            //DISABLE SORT
            foreach (DataGridViewColumn col in dgvTamu.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //COLOR
            foreach (DataGridViewRow row in dgvTamu.Rows)
            {
                if (row.Cells[12].Value.ToString() == "0")
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }

            dgvTamu.ClearSelection();
        }

        private void btCari_Click(object sender, EventArgs e)
        {
            fillInput("cari");
        }

        private void fillInput(string asal)
        {
            changeMode(0);
            if (asal == "cari")
            {
                dgvTamu.Rows[cbCari.SelectedIndex].Selected = true;
            }

            lbKodeTamu.Text = dgvTamu.SelectedRows[0].Cells[1].Value.ToString();
            tbNama.Text = dgvTamu.SelectedRows[0].Cells[2].Value.ToString();
            if (dgvTamu.SelectedRows[0].Cells[4].Value.ToString() == "L")
            {
                rbLakiLaki.Checked = true;
                rbPerempuan.Checked = false;
            }
            else
            {
                rbLakiLaki.Checked = false;
                rbPerempuan.Checked = true;
            }
            dtpTanggalLahir.Value = (DateTime)dgvTamu.SelectedRows[0].Cells[6].Value;
            tbNegaraAsal.Text = dgvTamu.SelectedRows[0].Cells[8].Value.ToString();
            tbAlamat.Text = dgvTamu.SelectedRows[0].Cells[7].Value.ToString();
            tbNomorTelepon.Text = dgvTamu.SelectedRows[0].Cells[9].Value.ToString();
            tbEmail.Text = dgvTamu.SelectedRows[0].Cells[10].Value.ToString();
            if (dgvTamu.SelectedRows[0].Cells[12].Value.ToString() == "1")
            {
                cbStatus.Checked = true;
            }
            else
            {
                cbStatus.Checked = false;
            }
        }

        private void dgvTamu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                fillInput("dgv");
            }
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text.Trim() == "" || (!rbLakiLaki.Checked && !rbPerempuan.Checked) || tbNegaraAsal.Text.Trim() == "" || tbAlamat.Text.Trim() == "" || tbNomorTelepon.Text.Trim() == "" || tbEmail.Text.Trim() == "" || !tbEmail.Text.Contains("@"))
            {
                MessageBox.Show("Pastikan SEMUA data sudah terisi dengan BENAR!");
                return;
            }

            if (cekAda() == 1)
            {
                return;
            }

            string query = $"INSERT INTO tamu VALUES(@Id, @KodeTamu, @Nama, @JenisKelamin, @TanggalLahir, @Alamat, @NegaraAsal, @NomorTelepon, @Email, @Status)";

            MySqlTransaction trans = Koneksi.conn.BeginTransaction();
            try
            {
                string jenisKelamin = "L";
                if (rbPerempuan.Checked)
                {
                    jenisKelamin = "P";
                }
                int status = Convert.ToInt32(cbStatus.Checked);

                MySqlCommand cmd = new MySqlCommand(query, Koneksi.conn);
                cmd.Parameters.AddWithValue("@Id", 0);
                cmd.Parameters.AddWithValue("@KodeTamu", lbKodeTamu.Text);
                cmd.Parameters.AddWithValue("@Nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
                cmd.Parameters.AddWithValue("@TanggalLahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Alamat", tbAlamat.Text);
                cmd.Parameters.AddWithValue("@NegaraAsal", tbNegaraAsal.Text);
                cmd.Parameters.AddWithValue("@NomorTelepon", tbNomorTelepon.Text);
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Berhasil menambahkan!", "BERHASIL");
                FormPencatatanDataTamu_Load(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                trans.Rollback();
                MessageBox.Show("Gagal menambahkan!", "GAGAL");
            }
        }

        private int cekAda()
        {
            // ADD & EXECUTE PROCEDURE
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = Koneksi.conn;
                cmd.CommandText = @"
                CREATE OR REPLACE PROCEDURE cekDataTamu(IN nama VARCHAR(255), IN tanggalLahir VARCHAR(255), IN negaraAsal VARCHAR(255), OUT kode VARCHAR(7))
                BEGIN
	                SELECT kode_tamu INTO kode FROM tamu WHERE nama_tamu = nama AND tanggal_lahir_tamu = STR_TO_DATE(tanggalLahir, '%Y-%m-%d') AND negara_asal = negaraAsal;
                END";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "cekDataTamu";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters["@nama"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@tanggalLahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters["@tanggalLahir"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@negaraAsal", tbNegaraAsal.Text);
                cmd.Parameters["@negaraAsal"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@kode", MySqlDbType.VarChar);
                cmd.Parameters["@kode"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (cmd.Parameters["@kode"].Value.ToString() != "")
            {
                cbStatus.Checked = true;
                MessageBox.Show("Tamu sudah terdaftar! Mengubah status tamu menjadi Aktif", "UPDATE DATA TAMU");
                updateData(cmd.Parameters["@kode"].Value.ToString());
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void updateData(string kode)
        {
            string query = $"UPDATE tamu SET jenis_kelamin_tamu = @JenisKelamin, alamat_tamu = @Alamat, nomor_telepon_tamu = @NomorTelepon, email_tamu = @Email, status_tamu = @Status WHERE kode_tamu = @KodeTamu";

            MySqlTransaction trans = Koneksi.conn.BeginTransaction();
            try
            {
                string jenisKelamin = "L";
                if (rbPerempuan.Checked)
                {
                    jenisKelamin = "P";
                }
                int status = Convert.ToInt32(cbStatus.Checked);

                MySqlCommand cmd = new MySqlCommand(query, Koneksi.conn);
                if (kode != "")
                {
                    cmd.Parameters.AddWithValue("@KodeTamu", kode);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@KodeTamu", lbKodeTamu.Text);
                }
                cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
                cmd.Parameters.AddWithValue("@Alamat", tbAlamat.Text);
                cmd.Parameters.AddWithValue("@NomorTelepon", tbNomorTelepon.Text);
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Berhasil memperbarui!", "BERHASIL");

                refresh_cbCari_dgvTamu();
                changeMode(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                trans.Rollback();
                MessageBox.Show("Gagal memperbarui!", "GAGAL");
            }
        }

        private void btPerbarui_Click(object sender, EventArgs e)
        {
            if (tbAlamat.Text.Trim() == "" || tbNomorTelepon.Text.Trim() == "" || tbEmail.Text.Trim() == "" || !tbEmail.Text.Contains("@"))
            {
                MessageBox.Show("Pastikan SEMUA data sudah terisi dengan BENAR!");
                return;
            }

            updateData("");
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            changeMode(1);
        }

        private void tbNomorTelepon_TextChanged(object sender, EventArgs e)
        {
            if (tbNomorTelepon.Text.Length > 0)
            {
                char temp = tbNomorTelepon.Text[(tbNomorTelepon.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbNomorTelepon.Text = tbNomorTelepon.Text.Remove(tbNomorTelepon.Text.Length - 1, 1);
                    tbNomorTelepon.SelectionStart = tbNomorTelepon.Text.Length;
                }
            }
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text.Trim() != "" && tbNama.Text.Length >= 4)
            {
                generateKodeTamu();
            }
            else
            {
                MessageBox.Show("Pastikan Nama lebih panjang dari 4");
            }
        }

        private void cbCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptButton = btCari;
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
