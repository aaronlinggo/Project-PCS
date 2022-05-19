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
        bool inputingData;
        int deposito;
        int dp;
        DataTable dtReservasi;
        DataTable dtTamu;
        DataTable dtJenisKamar;
        DataTable dtNomorKamar;

        MySqlDataAdapter da;

        public FormReservasi()
        {
            InitializeComponent();
        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            refresh_cbCari_dgvReservasi();
            loadNamaTamu();
            loadJenisKamar();
            changeMode(1);
        }

        private void fillDT(DataTable dt, string query)
        {
            try
            {
                da = new MySqlDataAdapter(query, Koneksi.conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadReservasi(int status)
        {
            dtReservasi = new DataTable();
            string query = @"
                    SELECT CONCAT(t.nama_tamu, ' - ', kode_reservasi) AS nama_kode, kode_reservasi, t.nama_tamu, jk.nama_jenis_kamar, km.nomor_kamar, CONCAT('Rp ', FORMAT(down_payment, 0, 'de_DE'), ',00'), down_payment, CONCAT('Rp ', FORMAT(deposito, 0, 'de_DE'), ',00'), deposito, DATE_FORMAT(jadwal_check_in, '%W, %d %M %Y'), jadwal_check_in, DATE_FORMAT(jadwal_check_out, '%W, %d %M %Y'), jadwal_check_out, IFNULL(DATE_FORMAT(tanggal_check_in, '%W, %d %M %Y'), '-'), tanggal_check_in, IFNULL(DATE_FORMAT(tanggal_check_out, '%W, %d %M %Y'), '-'), tanggal_check_out, IFNULL(CONCAT('Rp ', FORMAT(total_biaya, 0, 'de_DE'), ',00'), '-'), total_biaya, kr.nama_karyawan, CASE WHEN status_reservasi = 0 THEN 'Selesai' WHEN status_reservasi = 1 THEN 'Dipesan' WHEN status_reservasi = 2 THEN 'Check In' ELSE 'Dibatalkan' END, status_reservasi
                    FROM reservasi r
                    JOIN tamu t ON t.kode_tamu = r.kode_tamu
                    JOIN kamar km ON km.kode_kamar = r.kode_kamar
                    JOIN jenis_kamar jk ON jk.id_jenis_kamar = km.id_jenis_kamar
                    JOIN karyawan kr ON kr.kode_karyawan = r.kode_karyawan
                    ORDER BY id_reservasi";
            if (status == 0)
            {
                // DONE
                query += " WHERE status_reservasi = 0";
            }
            else if (status == 1)
            {
                // RESERVED
                query += " WHERE status_reservasi = 1";
            }
            else if (status == 2)
            {
                // CHECKED IN
                query += " WHERE status_reservasi = 2";
            }
            else if (status == 3)
            {
                query += " WHERE status_reservasi = 99";
            }
            fillDT(dtReservasi, query);
        }

        private void refresh_cbCari_dgvReservasi(int status = -1)
        {
            loadReservasi(status);
            cbCari.DataSource = dtReservasi;
            cbCari.DisplayMember = "nama_kode";
            cbCari.ValueMember = "kode_reservasi";
            cbCari.SelectedIndex = -1;

            dgvReservasi.DataSource = dtReservasi;
            dgvReservasi.Columns[0].Visible = false;
            dgvReservasi.Columns[1].HeaderText = "Kode Reservasi";
            dgvReservasi.Columns[2].HeaderText = "Nama Tamu";
            dgvReservasi.Columns[3].HeaderText = "Jenis Kamar";
            dgvReservasi.Columns[4].HeaderText = "Nomor Kamar";
            dgvReservasi.Columns[5].HeaderText = "Down Payment";
            dgvReservasi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReservasi.Columns[6].Visible = false;
            dgvReservasi.Columns[7].HeaderText = "Deposito";
            dgvReservasi.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReservasi.Columns[8].Visible = false;
            dgvReservasi.Columns[9].HeaderText = "Jadwal Check In";
            dgvReservasi.Columns[10].Visible = false;
            dgvReservasi.Columns[11].HeaderText = "Jadwal Check Out";
            dgvReservasi.Columns[12].Visible = false;
            dgvReservasi.Columns[13].HeaderText = "Tanggal Check In";
            dgvReservasi.Columns[14].Visible = false;
            dgvReservasi.Columns[15].HeaderText = "Tanggal Check Out";
            dgvReservasi.Columns[16].Visible = false;
            dgvReservasi.Columns[17].HeaderText = "Total Biaya";
            dgvReservasi.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReservasi.Columns[18].Visible = false;
            dgvReservasi.Columns[19].HeaderText = "Nama Karyawan";
            dgvReservasi.Columns[20].HeaderText = "Status Reservasi";
            dgvReservasi.Columns[21].Visible = false;

            //DISABLE SORT
            foreach (DataGridViewColumn col in dgvReservasi.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //COLOR
            foreach (DataGridViewRow row in dgvReservasi.Rows)
            {

                if (row.Cells[21].Value.ToString() == "0")
                {
                    row.DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                }
                else if (row.Cells[21].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else if (row.Cells[21].Value.ToString() == "2")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
            }

            dgvReservasi.ClearSelection();
        }

        private void loadNamaTamu()
        {
            dtTamu = new DataTable();
            string query = "SELECT kode_tamu, nama_tamu FROM tamu WHERE status_tamu = 1";
            fillDT(dtTamu, query);
            cbNamaTamu.DataSource = dtTamu;
            cbNamaTamu.DisplayMember = "nama_tamu";
            cbNamaTamu.ValueMember = "kode_tamu";
            cbNamaTamu.SelectedIndex = -1;
        }

        private void loadJenisKamar()
        {
            dtJenisKamar = new DataTable();
            string query = "SELECT id_jenis_kamar, nama_jenis_kamar, harga_jenis_kamar FROM jenis_kamar WHERE status_jenis_kamar = 1";
            fillDT(dtJenisKamar, query);
            cbJenisKamar.DataSource = dtJenisKamar;
            cbJenisKamar.DisplayMember = "nama_jenis_kamar";
            cbJenisKamar.ValueMember = "id_jenis_kamar";
        }

        private void loadNomorKamar()
        {
            dtNomorKamar = new DataTable();
            string query = $"SELECT kode_kamar, nomor_kamar FROM kamar WHERE id_jenis_kamar = {Convert.ToInt32(dtJenisKamar.Rows[cbJenisKamar.SelectedIndex][0])}";
            fillDT(dtNomorKamar, query);
            cbNomorKamar.DataSource = dtNomorKamar;
            cbNomorKamar.DisplayMember = "nomor_kamar";
            cbNomorKamar.ValueMember = "kode_kamar";
        }

        private void changeMode(int mode = -1)
        {
            inputingData = false;
            cbNamaTamu.Enabled = false;
            dtpJadwalCheckIn.Enabled = false;
            dtpJadwalCheckOut.Enabled = false;
            cbJenisKamar.Enabled = false;
            cbNomorKamar.Enabled = false;

            if (mode == 1)
            {
                // RESERVASI
                inputingData = true;
                cbStatus.SelectedIndex = -1;
                cbCari.SelectedIndex = -1;

                lbKodeReservasi.Text = "-";
                cbNamaTamu.SelectedIndex = -1;
                dtpJadwalCheckIn.Value = DateTime.Today;
                dtpJadwalCheckOut.Value = DateTime.Today;
                cbJenisKamar.SelectedIndex = -1;
                cbNomorKamar.SelectedIndex = -1;
                lbDownPayment.Text = "-";
                lbDeposito.Text = "-";

                cbNamaTamu.Enabled = true;
                dtpJadwalCheckIn.Enabled = true;
                dtpJadwalCheckOut.Enabled = true;
                cbJenisKamar.Enabled = true;
                cbNomorKamar.Enabled = true;

                btReservasi.Enabled = true;
                btBatal.Enabled = false;
            }
            else if (mode == 2)
            {
                // Batal
                btReservasi.Enabled = false;
                btBatal.Enabled = true;
            }
            else
            {
                // NOTHING TO DO
                btReservasi.Enabled = false;
                btBatal.Enabled = false;
            }
        }

        private void dgvReservasi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                fillInput("dgv");
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_cbCari_dgvReservasi(cbStatus.SelectedIndex);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dgvReservasi.ClearSelection();
            changeMode(1);
        }

        private void btCari_Click(object sender, EventArgs e)
        {
            fillInput("cari");
        }

        private void fillInput(string asal)
        {
            if (asal == "cari")
            {
                dgvReservasi.Rows[cbCari.SelectedIndex].Selected = true;
            }

            int status = Convert.ToInt32(dgvReservasi.SelectedRows[0].Cells[21].Value);
            if (status == 1)
            {
                // DIPESAN -> BATAL
                changeMode(2);
            }
            else
            {
                // SELESAI / CHECK IN / BATAL -> NOTHING TO DO
                changeMode();
            }

            lbKodeReservasi.Text = dgvReservasi.SelectedRows[0].Cells[1].Value.ToString();
            for (int i = 0; i < cbNamaTamu.Items.Count; i++)
            {
                if (dgvReservasi.SelectedRows[0].Cells[2].Value.ToString() == dtTamu.Rows[i][1].ToString())
                {
                    cbNamaTamu.SelectedIndex = i;
                    break;
                }
            }
            dtpJadwalCheckIn.Value = (DateTime)dgvReservasi.SelectedRows[0].Cells[10].Value;
            dtpJadwalCheckOut.Value = (DateTime)dgvReservasi.SelectedRows[0].Cells[12].Value;
            for (int i = 0; i < cbJenisKamar.Items.Count; i++)
            {
                if (dgvReservasi.SelectedRows[0].Cells[3].Value.ToString() == dtJenisKamar.Rows[i][1].ToString())
                {
                    cbJenisKamar.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < cbNomorKamar.Items.Count; i++)
            {
                if (dgvReservasi.SelectedRows[0].Cells[4].Value.ToString() == dtNomorKamar.Rows[i][1].ToString())
                {
                    cbNomorKamar.SelectedIndex = i;
                    break;
                }
            }
            lbDownPayment.Text = $"{dgvReservasi.SelectedRows[0].Cells[5].Value}";
            lbDeposito.Text = $"{dgvReservasi.SelectedRows[0].Cells[7].Value}";
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool bisaReservasi()
        {
            DataTable dtListedReservasi = new DataTable();
            //FIND NOMOR KAMAR DAN STATUS 1 / 2
            string query = $"SELECT jadwal_check_in, jadwal_check_out FROM reservasi r JOIN kamar km ON km.kode_kamar = r.kode_kamar WHERE nomor_kamar = {dtNomorKamar.Rows[cbNomorKamar.SelectedIndex][1]} AND (status_reservasi = 1 OR status_reservasi = 2)";
            fillDT(dtListedReservasi, query);

            if (dtListedReservasi.Rows.Count > 0)
            {
                //CHECK JADWAL CHECK IN DAN JADWAL CHECK OUT
                for (int i = 0; i < dtListedReservasi.Rows.Count; i++)
                {
                    if ((dtpJadwalCheckIn.Value >= (DateTime)dtListedReservasi.Rows[i][0] && dtpJadwalCheckIn.Value <= (DateTime)dtListedReservasi.Rows[i][1]) || (dtpJadwalCheckOut.Value >= (DateTime)dtListedReservasi.Rows[i][0] && dtpJadwalCheckOut.Value <= (DateTime)dtListedReservasi.Rows[i][1]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void btReservasi_Click(object sender, EventArgs e)
        {
            // TIDAK BOLEH ADA DATA KOSONG
            if (cbNamaTamu.SelectedIndex == -1 || cbJenisKamar.SelectedIndex == -1 || cbNomorKamar.SelectedIndex == -1)
            {
                MessageBox.Show("Pastikan semua DATA TERISI dengan benar!", "GAGAL");
                return;
            }

            // PENGECEKAN TANGGAL
            if (!bisaReservasi())
            {
                MessageBox.Show("Kamar sudah direservasi / ditempati!", "GAGAL");
                return;
            }

            // DIPESAN -> 1
            string query = @"INSERT INTO reservasi (id_reservasi, kode_reservasi, kode_tamu, kode_kamar, down_payment, deposito, jadwal_check_in, jadwal_check_out, kode_karyawan, status_reservasi) VALUES (@IdReservasi, @KodeReservasi, @KodeTamu, @KodeKamar, @DownPayment, @Deposito, @JadwalCheckIn, @JadwalCheckOut, @KodeKaryawan, @StatusReservasi)";
            MySqlTransaction trans = Koneksi.conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.conn);
                cmd.Parameters.AddWithValue("@IdReservasi", 0);
                cmd.Parameters.AddWithValue("@KodeReservasi", lbKodeReservasi.Text);
                cmd.Parameters.AddWithValue("@KodeTamu", dtTamu.Rows[cbNamaTamu.SelectedIndex][0].ToString());
                cmd.Parameters.AddWithValue("@KodeKamar", dtNomorKamar.Rows[cbNomorKamar.SelectedIndex][0].ToString());
                cmd.Parameters.AddWithValue("@DownPayment", dp);
                cmd.Parameters.AddWithValue("@Deposito", deposito);
                cmd.Parameters.AddWithValue("@JadwalCheckIn", dtpJadwalCheckIn.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@JadwalCheckOut", dtpJadwalCheckOut.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@KodeKaryawan", FormLogin.dtKaryawan.Rows[0][0].ToString());
                cmd.Parameters.AddWithValue("@StatusReservasi", 1);
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Berhasil reservasi!", "BERHASIL");

                refresh_cbCari_dgvReservasi();
                changeMode(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                trans.Rollback();
                MessageBox.Show("Gagal reservasi!", "GAGAL");
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            // BATAL -> 99
            string query = @"UPDATE reservasi SET status_reservasi = 99 WHERE kode_reservasi = @KodeReservasi";
            MySqlTransaction trans = Koneksi.conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.conn);
                cmd.Parameters.AddWithValue("@KodeReservasi", lbKodeReservasi.Text);
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Berhasil membatalkan reservasi!", "BERHASIL");

                refresh_cbCari_dgvReservasi();
                changeMode(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                trans.Rollback();
                MessageBox.Show("Gagal membatalkan reservasi!", "GAGAL");
            }
        }

        private void dtpJadwalCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (inputingData)
            {
                if (dtpJadwalCheckIn.Value < DateTime.Today)
                {
                    MessageBox.Show("Jadwal Check In tidak boleh kurang dari Jadwal SAAT INI!");
                    dtpJadwalCheckIn.Value = DateTime.Today;
                }
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpJadwalCheckOut.Value < dtpJadwalCheckIn.Value)
            {
                Console.WriteLine("CO: " + dtpJadwalCheckOut.Value);
                Console.WriteLine("CI: " + dtpJadwalCheckIn.Value);
                MessageBox.Show("Jadwal Check Out tidak boleh kurang dari Jadwal Check In!");
                dtpJadwalCheckOut.Value = dtpJadwalCheckIn.Value;
            }
        }

        private void btTambahTamu_Click(object sender, EventArgs e)
        {
            Hide();
            FormPencatatanDataTamu form = new FormPencatatanDataTamu();
            form.ShowDialog();
            loadNamaTamu();
            Show();
        }

        private void generateKodeReservasi()
        {
            // ADD & EXECUTE PROCEDURE
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = Koneksi.conn;
                cmd.CommandText = @"
                CREATE OR REPLACE PROCEDURE generateKodeTamu(IN nama VARCHAR(255), IN nomor INT, OUT kode VARCHAR(15))
                BEGIN
	                SET kode = CONCAT('RSV', DATE_FORMAT(NOW(), '%d%m%y'));

                        IF INSTR(nama, ' ') = 0 THEN
                                SET kode = CONCAT(kode, SUBSTR(nama, 1, 2));
                        ELSE
                                SET kode = CONCAT(kode, CONCAT(SUBSTR(nama, 1, 1), SUBSTR(nama, INSTR(nama, ' ') + 1, 1)));
                        END IF;
        
                        SET kode = UPPER(CONCAT(kode, LPAD(nomor, 4, '0')));
                END";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "generateKodeTamu";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nama", dtTamu.Rows[cbNamaTamu.SelectedIndex][1].ToString());
                cmd.Parameters["@nama"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@nomor", dtNomorKamar.Rows[cbNomorKamar.SelectedIndex][1].ToString());
                cmd.Parameters["@nomor"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@kode", MySqlDbType.VarChar);
                cmd.Parameters["@kode"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                lbKodeReservasi.Text = cmd.Parameters["@kode"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generate_DownPayment_Deposito()
        {
            deposito = 500000;
            dp = (int)(Convert.ToInt32(dtJenisKamar.Rows[cbJenisKamar.SelectedIndex][2]) * 0.5);

            lbDownPayment.Text = $"Rp {string.Format("{0:#,0}", dp).Replace(",", ".")},00";
            lbDeposito.Text = $"Rp {string.Format("{0:#,0}", deposito).Replace(",", ".")},00";
        }

        private void cbNamaTamu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNamaTamu.SelectedIndex > -1)
            {
                if (cbNomorKamar.SelectedIndex > -1)
                {
                    generateKodeReservasi();
                }
            }
        }

        private void cbJenisKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJenisKamar.SelectedIndex > -1)
            {
                loadNomorKamar();
            }
            else
            {
                cbNomorKamar.DataSource = null;
                cbNomorKamar.Items.Clear();
                cbNomorKamar.Items.Add("");
            }
        }

        private void cbNomorKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNamaTamu.SelectedIndex > -1)
            {
                generateKodeReservasi();
            }
            if (cbNomorKamar.SelectedIndex > -1)
            {
                generate_DownPayment_Deposito();
            }
        }
    }
}