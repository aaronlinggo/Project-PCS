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
    public partial class FormCheckInOut : Form
    {
        private DataTable dtList;
        private List<string> columnName;
        public string fontName = "Gill Sans MT";
        private bool searchModeOn;

        public FormCheckInOut()
        {
            InitializeComponent();

            columnName = new List<string>();
        }

        private void FormCheckInOut_Load(object sender, EventArgs e)
        {
            searchModeOn = false;

            textBox2.Enabled = false;
            textBox2.Text = "-";

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            checkBox1.Checked = true;
            checkBox1.Enabled = false;
            checkBox1.Visible = false;

            columnName.Add("Kode Reservasi");
            columnName.Add("Nama Tamu");
            columnName.Add("Nomor Kamar");
            columnName.Add("Jenis Kamar");
            columnName.Add("Jumlah Penghuni Kamar");
            columnName.Add("Tanggal Check In");
            columnName.Add("Tanggal Check Out");
            columnName.Add("Jadwal Check In");
            columnName.Add("Jadwal Check Out");
            columnName.Add("Lama Menginap");
            columnName.Add("Subtotal Reservasi");
            columnName.Add("Status Reservasi");
            columnName.Add("ID");
            columnName.Add("Kode Kamar");

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);

            dataGridViewSetup();

            this.Text = "Konfirmasi Check-in";
            this.Update();
        }

        public void loadDatabase()
        {
            try
            {
                MySqlDataAdapter da;

                if (!searchModeOn)
                {
                    da = new MySqlDataAdapter("SELECT hr.kode_reservasi, t.nama_tamu, k.nomor_kamar, jk.nama_jenis_kamar, CONCAT(dr.jumlah_penghuni_kamar, ' orang'), DATE_FORMAT(dr.tanggal_check_in, '%W, %d %M %Y'), DATE_FORMAT(dr.tanggal_check_out, '%W, %d %M %Y'), DATE_FORMAT(dr.jadwal_check_in, '%W, %d %M %Y'), DATE_FORMAT(dr.jadwal_check_out, '%W, %d %M %Y'), CONCAT(DATEDIFF(dr.jadwal_check_out, dr.jadwal_check_in), ' hari'), CONCAT('Rp. ', FORMAT(dr.subtotal_biaya_reservasi, '###,###,###')), dr.status_detail_reservasi, dr.id_detail_reservasi, k.kode_kamar FROM header_reservasi hr RIGHT OUTER JOIN detail_reservasi dr ON hr.kode_reservasi = dr.kode_reservasi LEFT OUTER JOIN kamar k ON dr.kode_kamar = k.kode_kamar LEFT OUTER JOIN tamu t ON hr.kode_tamu = t.kode_tamu LEFT OUTER JOIN jenis_kamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar WHERE dr.status_detail_reservasi = @status_detail_reservasi;", Koneksi.getConn());
                    da.SelectCommand.Parameters.AddWithValue("@status_detail_reservasi", (radioButton2.Checked) ? 2 : 1);
                }
                else
                {
                    if (textBox2.Text == "")
                    {
                        da = new MySqlDataAdapter("SELECT hr.kode_reservasi, t.nama_tamu, k.nomor_kamar, jk.nama_jenis_kamar, CONCAT(dr.jumlah_penghuni_kamar, ' orang'), DATE_FORMAT(dr.tanggal_check_in, '%W, %d %M %Y'), DATE_FORMAT(dr.tanggal_check_out, '%W, %d %M %Y'), DATE_FORMAT(dr.jadwal_check_in, '%W, %d %M %Y'), DATE_FORMAT(dr.jadwal_check_out, '%W, %d %M %Y'), CONCAT(DATEDIFF(dr.jadwal_check_out, dr.jadwal_check_in), ' hari'), CONCAT('Rp. ', FORMAT(dr.subtotal_biaya_reservasi, '###,###,###')), dr.status_detail_reservasi, dr.id_detail_reservasi, k.kode_kamar FROM header_reservasi hr RIGHT OUTER JOIN detail_reservasi dr ON hr.kode_reservasi = dr.kode_reservasi LEFT OUTER JOIN kamar k ON dr.kode_kamar = k.kode_kamar LEFT OUTER JOIN tamu t ON hr.kode_tamu = t.kode_tamu LEFT OUTER JOIN jenis_kamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar WHERE dr.status_detail_reservasi = @status_detail_reservasi AND t.nama_tamu LIKE @nama_tamu;", Koneksi.getConn());
                        da.SelectCommand.Parameters.AddWithValue("@status_detail_reservasi", (radioButton2.Checked) ? 2 : 1);
                        da.SelectCommand.Parameters.AddWithValue("@nama_tamu", "%" + textBox1.Text.Trim() + "%");
                    }
                    else
                    {
                        da = new MySqlDataAdapter("SELECT hr.kode_reservasi, t.nama_tamu, k.nomor_kamar, jk.nama_jenis_kamar, CONCAT(dr.jumlah_penghuni_kamar, ' orang'), DATE_FORMAT(dr.tanggal_check_in, '%W, %d %M %Y'), DATE_FORMAT(dr.tanggal_check_out, '%W, %d %M %Y'), DATE_FORMAT(dr.jadwal_check_in, '%W, %d %M %Y'), DATE_FORMAT(dr.jadwal_check_out, '%W, %d %M %Y'), CONCAT(DATEDIFF(dr.jadwal_check_out, dr.jadwal_check_in), ' hari'), CONCAT('Rp. ', FORMAT(dr.subtotal_biaya_reservasi, '###,###,###')), dr.status_detail_reservasi, dr.id_detail_reservasi, k.kode_kamar FROM header_reservasi hr RIGHT OUTER JOIN detail_reservasi dr ON hr.kode_reservasi = dr.kode_reservasi LEFT OUTER JOIN kamar k ON dr.kode_kamar = k.kode_kamar LEFT OUTER JOIN tamu t ON hr.kode_tamu = t.kode_tamu LEFT OUTER JOIN jenis_kamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar WHERE dr.status_detail_reservasi = @status_detail_reservasi AND t.nama_tamu LIKE @nama_tamu AND k.nomor_kamar LIKE @nomor_kamar;", Koneksi.getConn());
                        da.SelectCommand.Parameters.AddWithValue("@status_detail_reservasi", (radioButton2.Checked) ? 2 : 1);
                        da.SelectCommand.Parameters.AddWithValue("@nama_tamu", "%" + textBox1.Text.Trim() + "%");
                        da.SelectCommand.Parameters.AddWithValue("@nomor_kamar", "%" + textBox2.Text.Trim() + "%");
                    }

                    searchModeOn = false;
                }

                dtList = new DataTable();
                da.Fill(dtList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fitDataGridViewColumn(int columnIndex, bool setWidthGrow = false, int minimumWidth = 0)
        {
            if (setWidthGrow)
            {
                dataGridView1.Columns[columnIndex].MinimumWidth = (minimumWidth != 0) ? minimumWidth : dataGridView1.Columns[columnIndex].Width;
            }

            dataGridView1.Columns[columnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // Console.WriteLine("Column [Index, Width]: " + columnIndex + ", " + dataGridView1.Columns[columnIndex].Width);
        }

        private void fitDataGridViewColumn(string columnName, bool setWidthGrow = false, int minimumWidth = 0)
        {
            if (setWidthGrow)
            {
                dataGridView1.Columns[columnName].MinimumWidth = (minimumWidth != 0) ? minimumWidth : dataGridView1.Columns[columnName].Width;
            }

            dataGridView1.Columns[columnName].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // Console.WriteLine("Column [Index, Width]: " + columnName + ", " + dataGridView1.Columns[columnName].Width);
        }

        public void refreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtList;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dtList.Columns[i].ColumnName = columnName[i];
            }

            fitDataGridViewColumn("Kode Reservasi", true, minimumWidth: 150);
            fitDataGridViewColumn("Nomor Kamar", false);
            fitDataGridViewColumn("Jenis Kamar", true, minimumWidth: 130);
            fitDataGridViewColumn("Jumlah Penghuni Kamar", false);

            if (radioButton1.Checked)
            {
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
            }
            else
            {
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
            }

            if (radioButton2.Checked)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Cells[10].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            dataGridView1.ClearSelection();
        }

        private void dataGridViewSetup()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            loadDatabase();
            refreshDataGridView();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Visible = false;
                label1.Text = "KONFIRMASI CHECK-IN";
                btnUpdate.Text = "CHECK IN";
                dataGridViewSetup();

                this.Text = "Konfirmasi Check-in";
                this.Update();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = "KONFIRMASI CHECK-OUT";
                btnUpdate.Text = "CHECK OUT";
                dataGridViewSetup();
                checkBox1.Checked = true;
                checkBox1.Visible = true;

                this.Text = "Konfirmasi Check-out";
                this.Update();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "-";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "-")
            {
                MessageBox.Show("Isi minimal field nama untuk dapat menggunakan fitur Cari!", "Gagal");

                dataGridViewSetup();
            }
            else
            {
                try
                {
                    int roomNumber = (textBox2.Text.Trim().Length > 0) ? Convert.ToInt32(textBox2.Text.Trim()) : 0;

                    if (roomNumber < 0)
                    {
                        MessageBox.Show("Nomor kamar tidak boleh minus!", "Gagal");
                    }
                    else
                    {
                        searchModeOn = true;

                        dataGridViewSetup();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Nomor kamar harus berupa angka!", "Gagal");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "-";

            dataGridViewSetup();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                using (MySqlTransaction obTrans = Koneksi.getConn().BeginTransaction())
                {
                    try
                    {
                        string kode_reservasi = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        int id_detail_reservasi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[12].Value);

                        MySqlCommand cmd = new MySqlCommand("SELECT dr.jadwal_check_in FROM detail_reservasi dr WHERE dr.id_detail_reservasi = @id_detail_reservasi;", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@id_detail_reservasi", id_detail_reservasi);
                        DateTime jadwal_check_in = Convert.ToDateTime(cmd.ExecuteScalar().ToString());

                        if (DateTime.Now.Date < jadwal_check_in.Date)
                        {
                            obTrans.Rollback();
                            MessageBox.Show("Check-in tidak boleh di luar jadwal yang sudah direservasi!", "Gagal");
                        }
                        else
                        {
                            cmd = new MySqlCommand("SELECT COUNT(dr.kode_kamar) FROM detail_reservasi dr WHERE dr.kode_kamar = @kode_kamar AND dr.status_detail_reservasi = 2;", Koneksi.getConn());
                            cmd.Parameters.AddWithValue("@kode_kamar", dataGridView1.SelectedRows[0].Cells[13].Value.ToString());
                            int activeReservation = Convert.ToInt32(cmd.ExecuteScalar());

                            if (activeReservation != 0)
                            {
                                obTrans.Rollback();
                                MessageBox.Show("Kamar masih ditempati/belum kosong!", "Gagal");
                            }
                            else
                            {
                                cmd = new MySqlCommand("SELECT jk.harga_jenis_kamar / 2 FROM kamar k LEFT OUTER JOIN jenis_kamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar WHERE k.nomor_kamar = @nomor_kamar;", Koneksi.getConn());
                                cmd.Parameters.AddWithValue("@nomor_kamar", dataGridView1.SelectedRows[0].Cells[2].Value);
                                int harga_jenis_kamar = Convert.ToInt32(cmd.ExecuteScalar());

                                cmd = new MySqlCommand("UPDATE detail_reservasi SET tanggal_check_in = @tanggal_check_in, subtotal_biaya_reservasi = @subtotal_biaya_reservasi, status_detail_reservasi = @status_detail_reservasi WHERE id_detail_reservasi = @id_detail_reservasi;", Koneksi.getConn());
                                cmd.Parameters.AddWithValue("@tanggal_check_in", DateTime.Now.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@subtotal_biaya_reservasi", harga_jenis_kamar);
                                cmd.Parameters.AddWithValue("@status_detail_reservasi", 2);
                                cmd.Parameters.AddWithValue("@id_detail_reservasi", id_detail_reservasi);
                                cmd.ExecuteNonQuery();

                                cmd = new MySqlCommand("SELECT hr.total_biaya_reservasi FROM header_reservasi hr WHERE hr.kode_reservasi = @kode_reservasi;", Koneksi.getConn());
                                cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                                int total_biaya_reservasi = Convert.ToInt32(cmd.ExecuteScalar());

                                cmd = new MySqlCommand("UPDATE header_reservasi SET total_biaya_reservasi = @total_biaya_reservasi WHERE kode_reservasi = @kode_reservasi;", Koneksi.getConn());
                                cmd.Parameters.AddWithValue("@total_biaya_reservasi", total_biaya_reservasi + harga_jenis_kamar);
                                cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                                cmd.ExecuteNonQuery();

                                obTrans.Commit();
                                MessageBox.Show("Berhasil check-in!", "Berhasil");

                                dataGridViewSetup();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        obTrans.Rollback();
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Tidak ada data yang sedang dipilih!", "Gagal");
                    }
                }
            }
            else
            {
                using (MySqlTransaction obTrans = Koneksi.getConn().BeginTransaction())
                {
                    try
                    {
                        string kode_reservasi = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        int id_detail_reservasi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[12].Value);

                        MySqlCommand cmd = new MySqlCommand("SELECT dr.subtotal_biaya_reservasi FROM detail_reservasi dr WHERE dr.id_detail_reservasi = @id_detail_reservasi;", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@id_detail_reservasi", id_detail_reservasi);
                        int subtotal_biaya_reservasi = Convert.ToInt32(cmd.ExecuteScalar());

                        cmd = new MySqlCommand("SELECT IFNULL(SUM(def.subtotal_extra_fasilitas), 0) FROM detail_extra_fasilitas def LEFT OUTER JOIN header_extra_fasilitas hef ON def.id_header_extra_fasilitas = hef.id_header_extra_fasilitas WHERE hef.kode_reservasi = @kode_reservasi AND def.kode_kamar = @kode_kamar AND def.status_detail = @status_detail;", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                        cmd.Parameters.AddWithValue("@kode_kamar", dataGridView1.SelectedRows[0].Cells[13].Value.ToString());
                        cmd.Parameters.AddWithValue("@status_detail", 1);
                        int subtotal_extra_fasilitas = Convert.ToInt32(cmd.ExecuteScalar());

                        cmd = new MySqlCommand("UPDATE detail_reservasi SET tanggal_check_out = @tanggal_check_out, subtotal_biaya_reservasi = @subtotal_biaya_reservasi, status_detail_reservasi = @status_detail_reservasi WHERE id_detail_reservasi = @id_detail_reservasi;", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@tanggal_check_out", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@subtotal_biaya_reservasi", subtotal_biaya_reservasi + subtotal_extra_fasilitas);
                        cmd.Parameters.AddWithValue("@status_detail_reservasi", 0);
                        cmd.Parameters.AddWithValue("@id_detail_reservasi", id_detail_reservasi);
                        cmd.ExecuteNonQuery();

                        cmd = new MySqlCommand("UPDATE detail_extra_fasilitas def LEFT OUTER JOIN header_extra_fasilitas hef ON def.id_header_extra_fasilitas = hef.id_header_extra_fasilitas SET def.status_detail = 0 WHERE hef.kode_reservasi = @kode_reservasi AND def.kode_kamar = @kode_kamar AND def.status_detail = 1;", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                        cmd.Parameters.AddWithValue("@kode_kamar", dataGridView1.SelectedRows[0].Cells[13].Value.ToString());
                        cmd.ExecuteNonQuery();

                        cmd = new MySqlCommand("SELECT hr.total_biaya_reservasi FROM header_reservasi hr WHERE hr.kode_reservasi = @kode_reservasi;", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                        int total_biaya_reservasi = Convert.ToInt32(cmd.ExecuteScalar());

                        cmd = new MySqlCommand("UPDATE header_reservasi SET total_biaya_reservasi = @total_biaya_reservasi WHERE kode_reservasi = @kode_reservasi;", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@total_biaya_reservasi", total_biaya_reservasi + subtotal_extra_fasilitas);
                        cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                        cmd.ExecuteNonQuery();

                        cmd = new MySqlCommand("SELECT COUNT(*) FROM detail_reservasi dr WHERE dr.kode_reservasi = @kode_reservasi AND (dr.status_detail_reservasi = 1 OR dr.status_detail_reservasi = 2);", Koneksi.getConn());
                        cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                        int activeReservation = Convert.ToInt32(cmd.ExecuteScalar());

                        if (activeReservation == 0)
                        {
                            cmd = new MySqlCommand("UPDATE header_reservasi SET status_header_reservasi = 0 WHERE kode_reservasi = @kode_reservasi;", Koneksi.getConn());
                            cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                            cmd.ExecuteNonQuery();
                        }

                        if (checkBox1.Checked)
                        {
                            cmd = new MySqlCommand("SELECT dr.deposito FROM detail_reservasi dr WHERE dr.id_detail_reservasi = @id_detail_reservasi;", Koneksi.getConn());
                            cmd.Parameters.AddWithValue("@id_detail_reservasi", id_detail_reservasi);
                            int deposito = Convert.ToInt32(cmd.ExecuteScalar());

                            cmd = new MySqlCommand("SELECT hr.total_biaya_reservasi FROM header_reservasi hr WHERE hr.kode_reservasi = @kode_reservasi;", Koneksi.getConn());
                            cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                            total_biaya_reservasi = Convert.ToInt32(cmd.ExecuteScalar());

                            cmd = new MySqlCommand("UPDATE header_reservasi SET total_biaya_reservasi = @total_biaya_reservasi WHERE kode_reservasi = @kode_reservasi;", Koneksi.getConn());
                            cmd.Parameters.AddWithValue("@total_biaya_reservasi", total_biaya_reservasi - deposito);
                            cmd.Parameters.AddWithValue("@kode_reservasi", kode_reservasi);
                            cmd.ExecuteNonQuery();

                            cmd = new MySqlCommand("UPDATE detail_reservasi SET deposito = 0 WHERE id_detail_reservasi = @id_detail_reservasi;", Koneksi.getConn());
                            cmd.Parameters.AddWithValue("@id_detail_reservasi", id_detail_reservasi);
                            cmd.ExecuteNonQuery();
                        }

                        obTrans.Commit();
                        MessageBox.Show("Berhasil check-out!", "Berhasil");

                        dataGridViewSetup();
                    }
                    catch (Exception ex)
                    {
                        obTrans.Rollback();
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Tidak ada data yang sedang dipilih!", "Gagal");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridView1.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
            }
        }
    }
}
