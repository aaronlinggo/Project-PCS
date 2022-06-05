using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Harem_SamGun
{
    public partial class FormLogin : Form
    {
        public static DataTable dtKaryawan;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f7a13e");
            tbUsername.BackColor = System.Drawing.ColorTranslator.FromHtml("#f6f6f6");
            tbPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#f6f6f6");
            btLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#f7a13e");
            btLogin.ForeColor = System.Drawing.Color.White;

            Koneksi.openConn();
            btLogin.FlatAppearance.BorderSize = 0;
            if (!Koneksi.isValid)
            {
                MessageBox.Show("Gagal terhubung ke database!", "GAGAL");
                return;
            }
        }

        private bool getUsernamePasswordRoles()
        {
            dtKaryawan = new DataTable();

            try
            {
                string query = $"SELECT kode_karyawan, nama_karyawan, username, password, roles FROM karyawan WHERE username=@username";
                MySqlDataAdapter da = new MySqlDataAdapter(query, Koneksi.conn);
                da.SelectCommand.Parameters.AddWithValue("@username", tbUsername.Text);
                da.Fill(dtKaryawan);

                if (dtKaryawan.Rows.Count == 1) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //CEK FIELD TEXTBOX
            if (tbUsername.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tidak boleh ada field kosong!", "GAGAL");
                return;
            }

            string inputUsername = tbUsername.Text.Trim();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM karyawan k WHERE k.username = @username", Koneksi.getConn());
            cmd.Parameters.AddWithValue("@username", inputUsername);
            int userCount = Convert.ToInt32(cmd.ExecuteScalar());

            if (userCount > 0)
            {
                cmd = new MySqlCommand("SELECT k.password FROM karyawan k WHERE k.username = @username", Koneksi.getConn());
                cmd.Parameters.AddWithValue("@username", inputUsername);
                string userPassword = cmd.ExecuteScalar().ToString();

                if (tbPassword.Text.Trim() == userPassword)
                {
                    cmd = new MySqlCommand("SELECT k.roles FROM karyawan k WHERE k.username = @username", Koneksi.getConn());
                    cmd.Parameters.AddWithValue("@username", inputUsername);
                    string userRoles = cmd.ExecuteScalar().ToString();

                    this.Hide();

                    if (userRoles == "Admin")
                    {
                        FormMenuAdmin form = new FormMenuAdmin();
                        form.ShowDialog();
                    }
                    else
                    {
                        FormMenuResepsionis form = new FormMenuResepsionis();
                        form.ShowDialog();
                    }

                    this.Show();
                }
                else
                {
                    MessageBox.Show("Password yang anda masukkan salah! Harap cek kembali!", "Gagal");
                }
            }
            else
            {
                MessageBox.Show("Username tidak ditemukan!", "Gagal");
            }
        }
    }
}
