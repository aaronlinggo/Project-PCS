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
    public partial class FormLogin : Form
    {
        DataTable dtUsernamePasswordRoles;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Koneksi.openConn();
            if (!Koneksi.valid)
            {
                MessageBox.Show("Gagal terhubung ke database!", "GAGAL");
            }
        }

        private bool getUsernamePasswordRoles()
        {
            dtUsernamePasswordRoles = new DataTable();
            try
            {
                string query = $"SELECT username, password, roles FROM `karyawan` WHERE `username`=@Username AND `password`=@Password";
                MySqlDataAdapter da = new MySqlDataAdapter(query, Koneksi.conn);
                da.SelectCommand.Parameters.AddWithValue("@Username", tbUsername.Text);
                da.SelectCommand.Parameters.AddWithValue("@Password", tbPassword.Text);
                da.Fill(dtUsernamePasswordRoles);

                if (dtUsernamePasswordRoles.Rows.Count == 1) return true;
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

            if (!getUsernamePasswordRoles())
            {
                MessageBox.Show("Username dan Password tidak ditemukan!", "GAGAL");
                return;
            }

            //CEK USERNAME
            MessageBox.Show(dtUsernamePasswordRoles.Rows[0][0].ToString());
            if (tbUsername.Text.Trim() != dtUsernamePasswordRoles.Rows[0][0].ToString())
            {
                MessageBox.Show("Username Salah! Harap cek kembali!", "GAGAL");
                return;
            }

            //CEK PASSWORD
            if (tbPassword.Text.Trim() != dtUsernamePasswordRoles.Rows[0][1].ToString())
            {
                MessageBox.Show("Password Salah! Harap cek kembali!", "GAGAL");
                tbPassword.Text = "";
                return;
            }

            string roles = dtUsernamePasswordRoles.Rows[0][2].ToString();

            //GANTI FORM
            this.Hide();
            if (roles == "Admin")
            {
                FormMenuAdmin form = new FormMenuAdmin();
                form.ShowDialog();
            } else
            {
                FormMenuResepsionis form = new FormMenuResepsionis();
                form.ShowDialog();
            }
            this.Show();
        }
    }
}
