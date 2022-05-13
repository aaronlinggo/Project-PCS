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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //CEK FIELD TEXTBOX
            if (tbUsername.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tidak boleh ada field kosong!");
                return;
            }

            //CEK USERNAME
            string username = "";
            if (tbUsername.Text.Trim() != username)
            {
                MessageBox.Show("Username tidak terdaftar! Harap cek kembali!");
                return;
            }

            //CEK PASSWORD
            string password = "";
            if (tbPassword.Text.Trim() != password)
            {
                MessageBox.Show("Password salah! Harap cek kembali!");
                tbPassword.Text = "";
                return;
            }

            bool admin = true;

            //GANTI FORM
            Hide();
            if (admin)
            {
                FormMenuAdmin form = new FormMenuAdmin();
                form.ShowDialog();
            } else
            {
                FormMenuResepsionis form = new FormMenuResepsionis();
                form.ShowDialog();
            }
            Show();
        }
    }
}
