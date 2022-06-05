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
    public partial class FormDataResepsionis : Form
    {
        DataTable dtkaryawan;
        DataRow pick;
        bool isEdit = false;
        bool start = false;
        string query = "";
        public FormDataResepsionis()
        {
            InitializeComponent();
        }

        private void FormDataResepsionis_Load(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f7a13e");
            /*Koneksi.openConn();*/
            query = @"SELECT
  karyawan.id_karyawan,
  karyawan.kode_karyawan,
  karyawan.username,
  karyawan.nama_karyawan,
  karyawan.jenis_kelamin_karyawan,
  karyawan.tanggal_lahir_karyawan,
  karyawan.alamat_karyawan,
  karyawan.nomor_telepon_karyawan,
  karyawan.email_karyawan,
  karyawan.password,
  repeat('*', length(password)),
  karyawan.roles,
  karyawan.status_karyawan
FROM karyawan
WHERE karyawan.status_karyawan != 0
order by 1 asc";
            isEdit = false;
            start = false;
            loadDatagrid();
            start = true;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle.Font = new Font("Gill Sans MT", 12, FontStyle.Regular);
        }

        public void loadDatagrid()
        {
            try
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView1.EnableHeadersVisualStyles = false;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Koneksi.conn);
                dtkaryawan = new DataTable();
                adapter.Fill(dtkaryawan);

                dataGridView1.DataSource = dtkaryawan;
                dataGridView1.Columns[0].HeaderText = "ID Karyawan";
                dataGridView1.Columns[1].HeaderText = "Kode Karyawan";
                dataGridView1.Columns[2].HeaderText = "Username";
                dataGridView1.Columns[3].HeaderText = "Nama Karyawan";
                dataGridView1.Columns[4].HeaderText = "Jenis Kelamin";
                dataGridView1.Columns[5].HeaderText = "Tanggal Lahir";
                dataGridView1.Columns[6].HeaderText = "Alamat";
                dataGridView1.Columns[7].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[8].HeaderText = "Email";
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].HeaderText = "Roles";
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void refreshDataGridView()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DataSource = dtkaryawan;
            dataGridView1.Columns[0].HeaderText = "ID Karyawan";
            dataGridView1.Columns[1].HeaderText = "Kode Karyawan";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Nama Karyawan";
            dataGridView1.Columns[4].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[5].HeaderText = "Tanggal Lahir";
            dataGridView1.Columns[6].HeaderText = "Alamat";
            dataGridView1.Columns[7].HeaderText = "Nomor Telepon";
            dataGridView1.Columns[8].HeaderText = "Email";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Roles";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = @"SELECT
  karyawan.id_karyawan,
  karyawan.kode_karyawan,
  karyawan.username,
  karyawan.nama_karyawan,
  karyawan.jenis_kelamin_karyawan,
  karyawan.tanggal_lahir_karyawan,
  karyawan.alamat_karyawan,
  karyawan.nomor_telepon_karyawan,
  karyawan.email_karyawan,
  karyawan.password,
  repeat('*', length(password)),
  karyawan.roles,
  karyawan.status_karyawan
FROM karyawan
WHERE karyawan.status_karyawan != 0
order by 1 asc";
            isEdit = false;
            start = false;
            tbID.Text = "";
            tbKode.Text = "";
            tbUsername.Text = "";
            tbNama.Text = "";
            tbAlamat.Text = "";
            tbNoTelp.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            dtTanggalLahir.Value = DateTime.Now;
            rbAdmin.Checked = true;
            rbResepsionis.Checked = false;
            start = true;
            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnTambah.Enabled = true;
            rbAdmin.Enabled = true;
            rbResepsionis.Enabled = true;
            dataGridView1.ClearSelection();
            loadDatagrid();
            refreshDataGridView();
            tbCari.Text = "";
        }

        private void tbNoTelp_TextChanged(object sender, EventArgs e)
        {
            if (start)
            {
                generateID();
            }

        }

        public void generateID()
        {
            if (tbKode.Text != "" || tbUsername.Text != "" || tbNama.Text != "" || rbLaki.Checked != false || rbPerempuan.Checked != false || tbAlamat.Text != "" || tbEmail.Text != "" || tbPassword.Text != "" || rbAdmin.Checked != false || rbResepsionis.Checked != false)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(id_karyawan) FROM karyawan", Koneksi.conn);
                int nextID = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                tbID.Text = "" + nextID;
            }
            else
            {
                tbID.Text = "";
            }
        }
        public void generateKode()
        {
            if (rbAdmin.Checked && !rbResepsionis.Checked)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id_karyawan) FROM karyawan WHERE roles = 'Admin'", Koneksi.conn);
                int nextID = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                string temp = "";
                if (nextID < 10)
                {
                    temp = "00";
                }
                else if (nextID < 100)
                {
                    temp = "0";
                }
                tbKode.Text = "AD" + temp + "" + nextID;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id_karyawan) FROM karyawan WHERE roles = 'Resepsionis'", Koneksi.conn);
                int nextID = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                string temp = "";
                if (nextID < 10)
                {
                    temp = "00";
                }
                else if (nextID < 100)
                {
                    temp = "0";
                }
                tbKode.Text = "RE" + temp + "" + nextID;
            }
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                    generateKode();
                }
            }
        }

        private void rbResepsionis_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                    generateKode();
                }
            }
        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void dtTanggalLahir_ValueChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (start)
            {
                if (!isEdit)
                {
                    generateID();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (rbLaki.Checked || rbPerempuan.Checked)
                    {
                        if (DateTime.Today.Year - dtTanggalLahir.Value.Year >= 18)
                        {
                            if (tbAlamat.Text != "")
                            {
                                if (tbAlamat.Text != "")
                                {
                                    if (tbEmail.Text != "")
                                    {
                                        if (tbPassword.Text != "")
                                        {
                                            if (rbAdmin.Checked || rbResepsionis.Checked)
                                            {
                                                if (tbPassword.Text == tbConfirm.Text)
                                                {
                                                    MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                                                    try
                                                    {
                                                        // cek nama makanan
                                                        // cek status makanan 99

                                                        MySqlCommand cmd = new MySqlCommand();
                                                        cmd.CommandText = @"SELECT
  count(karyawan.id_karyawan)
FROM karyawan
WHERE UPPER(karyawan.nama_karyawan) like '%" + tbUsername.Text.ToUpper() + "%' AND karyawan.status_karyawan=0";
                                                        cmd.Connection = Koneksi.getConn();
                                                        int ada;
                                                        ada = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                                                        string jk = "";
                                                        if (rbLaki.Checked && !rbPerempuan.Checked)
                                                        {
                                                            jk = "L";
                                                        }
                                                        else
                                                        {
                                                            jk = "P";
                                                        }

                                                        if (ada != 0)
                                                        {
                                                            MySqlCommand cmdid = new MySqlCommand();
                                                            cmdid.CommandText = @"SELECT
  karyawan.id_karyawan
FROM karyawan
WHERE UPPER(karyawan.nama_karyawan) like '%" + tbUsername.Text.ToUpper() + "%' AND karyawan.status_karyawan=0";
                                                            cmdid.Connection = Koneksi.getConn();
                                                            int idtemp;
                                                            idtemp = Convert.ToInt32(cmdid.ExecuteScalar().ToString());

                                                            MySqlCommand cmd2 = new MySqlCommand();
                                                            cmd2.CommandText = "UPDATE karyawan SET nama_karyawan=@nama_karyawan, username=@username, jenis_kelamin_karyawan=@jenis_kelamin_karyawan, tanggal_lahir_karyawan=@tanggal_lahir_karyawan, alamat_karyawan=@alamat_karyawan, nomor_telepon_karyawan=@nomor_telepon_karyawan, email_karyawan=@email_karyawan, password=@password, roles=@roles, status_karyawan=@status_karyawan WHERE id_karyawan=@id_karyawan";
                                                            cmd2.Parameters.AddWithValue("@id_karyawan", idtemp);
                                                            cmd2.Parameters.AddWithValue("@nama_karyawan", tbNama.Text);
                                                            cmd2.Parameters.AddWithValue("@username", tbUsername.Text);
                                                            cmd2.Parameters.AddWithValue("@jenis_kelamin_karyawan", jk);
                                                            cmd2.Parameters.AddWithValue("@tanggal_lahir_karyawan", dtTanggalLahir.Value.ToString("yyyy-MM-dd"));
                                                            cmd2.Parameters.AddWithValue("@alamat_karyawan", tbAlamat.Text);
                                                            cmd2.Parameters.AddWithValue("@nomor_telepon_karyawan", tbNoTelp.Text);
                                                            cmd2.Parameters.AddWithValue("@email_karyawan", tbEmail.Text);
                                                            cmd2.Parameters.AddWithValue("@password", tbPassword.Text);
                                                            if (rbAdmin.Checked && !rbResepsionis.Checked)
                                                            {
                                                                cmd2.Parameters.AddWithValue("@roles", "Admin");
                                                            }
                                                            else
                                                            {
                                                                cmd2.Parameters.AddWithValue("@roles", "Resepsionis");
                                                            }
                                                            cmd2.Parameters.AddWithValue("@status_karyawan", "1");

                                                            cmd2.Connection = Koneksi.getConn();
                                                            cmd2.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            MySqlDataAdapter adapter = new MySqlDataAdapter(@"SELECT
  karyawan.id_karyawan,
  karyawan.kode_karyawan,
  karyawan.username,
  karyawan.nama_karyawan,
  karyawan.jenis_kelamin_karyawan,
  karyawan.tanggal_lahir_karyawan,
  karyawan.alamat_karyawan,
  karyawan.nomor_telepon_karyawan,
  karyawan.email_karyawan,
  karyawan.password,
  repeat('*', length(password)),
  karyawan.roles,
  karyawan.status_karyawan
FROM karyawan
order by 1 asc", Koneksi.getConn());
                                                            DataTable dt = new DataTable();
                                                            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                                                            adapter.Fill(dt);

                                                            DataRow baru = dt.NewRow();
                                                            baru["id_karyawan"] = tbID.Text;
                                                            baru["kode_karyawan"] = tbKode.Text;
                                                            baru["username"] = tbUsername.Text;
                                                            baru["nama_karyawan"] = tbNama.Text;
                                                            baru["jenis_kelamin_karyawan"] = jk;
                                                            baru["tanggal_lahir_karyawan"] = dtTanggalLahir.Value.ToString("yyyy-MM-dd");
                                                            baru["alamat_karyawan"] = tbAlamat.Text;
                                                            baru["nomor_telepon_karyawan"] = tbNoTelp.Text;
                                                            baru["email_karyawan"] = tbEmail.Text;
                                                            baru["password"] = tbPassword.Text;
                                                            if (rbAdmin.Checked && !rbResepsionis.Checked)
                                                            {
                                                                baru["roles"] = "Admin";
                                                            }
                                                            else
                                                            {
                                                                baru["roles"] = "Resepsionis";
                                                            }
                                                            baru["status_karyawan"] = "1";

                                                            dt.Rows.Add(baru);

                                                            adapter.Update(dt);
                                                        }

                                                        loadDatagrid();
                                                        refreshDataGridView();

                                                        isEdit = false;
                                                        start = false;
                                                        tbID.Text = "";
                                                        tbKode.Text = "";
                                                        tbUsername.Text = "";
                                                        tbNama.Text = "";
                                                        tbAlamat.Text = "";
                                                        tbNoTelp.Text = "";
                                                        tbEmail.Text = "";
                                                        tbPassword.Text = "";
                                                        rbLaki.Checked = true;
                                                        rbPerempuan.Checked = false;
                                                        dtTanggalLahir.Value = DateTime.Now;
                                                        rbAdmin.Checked = true;
                                                        rbResepsionis.Checked = false;
                                                        start = true;
                                                        btnHapus.Enabled = false;
                                                        btnEdit.Enabled = false;

                                                        MessageBox.Show("Berhasil menambah data karyawan baru!", "Berhasil");
                                                        sqlt.Commit();
                                                    }
                                                    catch (MySqlException ex)
                                                    {
                                                        Console.WriteLine(ex.Message);
                                                        sqlt.Rollback();
                                                        MessageBox.Show("Gagal menambah data karyawan baru!", "Gagal");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Confirm password tidak sesuai!", "Gagal");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Roles tidak boleh kosong!", "Gagal");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Password tidak boleh kosong!", "Gagal");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Email tidak boleh kosong!", "Gagal");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Alamat tidak boleh kosong!", "Gagal");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nomor telepon tidak boleh kosong!", "Gagal");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Minimal umur adalah 18 tahun!", "Gagal");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jenis kelamin tidak boleh kosong!", "Gagal");
                    }
                }
                else
                {
                    MessageBox.Show("Nama karyawan tidak boleh kosong!", "Gagal");
                }
            }
            else
            {
                MessageBox.Show("Username tidak boleh kosong!", "Gagal");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*karyawan.id_karyawan, 0
  karyawan.kode_karyawan, 1
  karyawan.username, 2
  karyawan.nama_karyawan, 3
  karyawan.jenis_kelamin_karyawan, 4
  karyawan.tanggal_lahir_karyawan, 5
  karyawan.alamat_karyawan, 6
  karyawan.nomor_telepon_karyawan, 7
  karyawan.email_karyawan, 8
  karyawan.password, 9
  repeat('*', length(password)), 10
  karyawan.roles, 11
  karyawan.status_karyawan 12 */
            isEdit = true;
            btnHapus.Enabled = true;
            btnEdit.Enabled = true;
            pick = dtkaryawan.Rows[dataGridView1.CurrentRow.Index];
            tbID.Text = pick[0].ToString();
            tbKode.Text = pick[1].ToString();
            tbUsername.Text = pick[2].ToString();
            tbNama.Text = pick[3].ToString();
            if (pick[4].ToString() == "L")
            {
                rbLaki.Checked = true;
                rbPerempuan.Checked = false;
            }
            else
            {
                rbLaki.Checked = false;
                rbPerempuan.Checked = true;
            }
            dtTanggalLahir.Value = Convert.ToDateTime(pick[5].ToString());
            tbAlamat.Text = pick[6].ToString();
            tbNoTelp.Text = pick[7].ToString();
            tbEmail.Text = pick[8].ToString();
            tbPassword.Text = pick[9].ToString();
            if (pick[11].ToString() == "Admin")
            {
                rbAdmin.Checked = true;
                rbResepsionis.Checked = false;
            }
            else
            {
                rbAdmin.Checked = false;
                rbResepsionis.Checked = true;
            }
            rbAdmin.Enabled = false;
            rbResepsionis.Enabled = false;
            btnTambah.Enabled = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
            try
            {
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "UPDATE karyawan SET status_karyawan=@status_karyawan WHERE kode_karyawan=@kode_karyawan";
                cmd2.Parameters.AddWithValue("@kode_karyawan", tbKode.Text);
                cmd2.Parameters.AddWithValue("@status_karyawan", "0");

                cmd2.Connection = Koneksi.getConn();
                cmd2.ExecuteNonQuery();

                loadDatagrid();
                refreshDataGridView();

                isEdit = false;
                start = false;
                tbID.Text = "";
                tbKode.Text = "";
                tbUsername.Text = "";
                tbNama.Text = "";
                tbAlamat.Text = "";
                tbNoTelp.Text = "";
                tbEmail.Text = "";
                tbPassword.Text = "";
                rbLaki.Checked = true;
                rbPerempuan.Checked = false;
                dtTanggalLahir.Value = DateTime.Now;
                rbAdmin.Checked = true;
                rbResepsionis.Checked = false;
                start = true;
                btnHapus.Enabled = false;
                btnEdit.Enabled = false;

                rbAdmin.Enabled = true;
                rbResepsionis.Enabled = true;
                btnTambah.Enabled = true;

                MessageBox.Show("Berhasil hapus data karyawan!", "Berhasil");
                sqlt.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                sqlt.Rollback();
                MessageBox.Show("Gagal hapus data karyawan!", "Gagal");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (rbLaki.Checked || rbPerempuan.Checked)
                    {
                        if (DateTime.Today.Year - dtTanggalLahir.Value.Year >= 18)
                        {
                            if (tbAlamat.Text != "")
                            {
                                if (tbAlamat.Text != "")
                                {
                                    if (tbEmail.Text != "")
                                    {
                                        if (tbPassword.Text != "")
                                        {
                                            if (rbAdmin.Checked || rbResepsionis.Checked)
                                            {
                                                MySqlTransaction sqlt = Koneksi.getConn().BeginTransaction();
                                                try
                                                {
                                                    string jk = "";
                                                    if (rbLaki.Checked && !rbPerempuan.Checked)
                                                    {
                                                        jk = "L";
                                                    }
                                                    else
                                                    {
                                                        jk = "P";
                                                    }

                                                    MySqlCommand cmd2 = new MySqlCommand();
                                                    cmd2.CommandText = @"UPDATE karyawan SET nama_karyawan=@nama_karyawan, 
                        username=@username, 
                        jenis_kelamin_karyawan=@jenis_kelamin_karyawan, 
                        tanggal_lahir_karyawan=@tanggal_lahir_karyawan, 
                        alamat_karyawan=@alamat_karyawan, 
                        nomor_telepon_karyawan=@nomor_telepon_karyawan, 
                        email_karyawan=@email_karyawan, 
                        password=@password, 
                        roles=@roles
                        WHERE kode_karyawan=@kode_karyawan";
                                                    cmd2.Parameters.AddWithValue("@kode_karyawan", tbKode.Text);
                                                    cmd2.Parameters.AddWithValue("@nama_karyawan", tbNama.Text);
                                                    cmd2.Parameters.AddWithValue("@username", tbUsername.Text);
                                                    cmd2.Parameters.AddWithValue("@jenis_kelamin_karyawan", jk);
                                                    cmd2.Parameters.AddWithValue("@tanggal_lahir_karyawan", dtTanggalLahir.Value.ToString("yyyy-MM-dd"));
                                                    cmd2.Parameters.AddWithValue("@alamat_karyawan", tbAlamat.Text);
                                                    cmd2.Parameters.AddWithValue("@nomor_telepon_karyawan", tbNoTelp.Text);
                                                    cmd2.Parameters.AddWithValue("@email_karyawan", tbEmail.Text);
                                                    cmd2.Parameters.AddWithValue("@password", tbPassword.Text);
                                                    if (rbAdmin.Checked && !rbResepsionis.Checked)
                                                    {
                                                        cmd2.Parameters.AddWithValue("@roles", "Admin");
                                                    }
                                                    else
                                                    {
                                                        cmd2.Parameters.AddWithValue("@roles", "Resepsionis");
                                                    }

                                                    cmd2.Connection = Koneksi.getConn();
                                                    cmd2.ExecuteNonQuery();

                                                    loadDatagrid();
                                                    refreshDataGridView();

                                                    isEdit = false;
                                                    start = false;
                                                    tbID.Text = "";
                                                    tbKode.Text = "";
                                                    tbUsername.Text = "";
                                                    tbNama.Text = "";
                                                    tbAlamat.Text = "";
                                                    tbNoTelp.Text = "";
                                                    tbEmail.Text = "";
                                                    tbPassword.Text = "";
                                                    rbLaki.Checked = true;
                                                    rbPerempuan.Checked = false;
                                                    dtTanggalLahir.Value = DateTime.Now;
                                                    rbAdmin.Checked = true;
                                                    rbResepsionis.Checked = false;
                                                    start = true;
                                                    btnHapus.Enabled = false;
                                                    btnEdit.Enabled = false;
                                                    btnTambah.Enabled = true;

                                                    rbAdmin.Enabled = true;
                                                    rbResepsionis.Enabled = true;

                                                    MessageBox.Show("Berhasil ubah data karyawan!", "Berhasil");
                                                    sqlt.Commit();
                                                }
                                                catch (MySqlException ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                    sqlt.Rollback();
                                                    MessageBox.Show("Gagal ubah data karyawan!", "Gagal");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Roles tidak boleh kosong!", "Gagal");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Password tidak boleh kosong!", "Gagal");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Email tidak boleh kosong!", "Gagal");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Alamat tidak boleh kosong!", "Gagal");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nomor telepon tidak boleh kosong!", "Gagal");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Minimal umur adalah 18 tahun!", "Gagal");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jenis kelamin tidak boleh kosong!", "Gagal");
                    }
                }
                else
                {
                    MessageBox.Show("Nama karyawan tidak boleh kosong!", "Gagal");
                }
            }
            else
            {
                MessageBox.Show("Username tidak boleh kosong!", "Gagal");
            }
        }

        private void tbNoTelp_TextChanged_1(object sender, EventArgs e)
        {
            if (tbNoTelp.Text.Length > 0)
            {
                char temp = tbNoTelp.Text[(tbNoTelp.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbNoTelp.Text = tbNoTelp.Text.Remove(tbNoTelp.Text.Length - 1, 1);
                    tbNoTelp.SelectionStart = tbNoTelp.Text.Length;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = @"SELECT
  karyawan.id_karyawan,
  karyawan.kode_karyawan,
  karyawan.username,
  karyawan.nama_karyawan,
  karyawan.jenis_kelamin_karyawan,
  karyawan.tanggal_lahir_karyawan,
  karyawan.alamat_karyawan,
  karyawan.nomor_telepon_karyawan,
  karyawan.email_karyawan,
  karyawan.password,
  repeat('*', length(password)),
  karyawan.roles,
  karyawan.status_karyawan
FROM karyawan
WHERE karyawan.status_karyawan != 0
AND
karyawan.nama_karyawan LIKE '%" + tbCari.Text + @"%'
order by 1 asc";
            loadDatagrid();
            refreshDataGridView();
            tbCari.Text = "";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
