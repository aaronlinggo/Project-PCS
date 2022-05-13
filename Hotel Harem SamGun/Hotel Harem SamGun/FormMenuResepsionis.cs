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
    public partial class FormMenuResepsionis : Form
    {
        public FormMenuResepsionis()
        {
            InitializeComponent();
        }

        private void btReservasi_Click(object sender, EventArgs e)
        {
            Hide();
            FormReservasi form = new FormReservasi();
            form.ShowDialog();
            Show();
        }

        private void btPenambahanFasilitasKamar_Click(object sender, EventArgs e)
        {
            Hide();
            //FormPenambahanFasilitasKamar form = new FormPenambahanFasilitasKamar();
            //form.ShowDialog();
            Show();
        }

        private void btPemesananMakanan_Click(object sender, EventArgs e)
        {
            Hide();
            FormPemesananMakanan form = new FormPemesananMakanan();
            form.ShowDialog();
            Show();
        }

        private void btCheckInCheckOut_Click(object sender, EventArgs e)
        {
            Hide();
            //FormCheckInCheckOut form = new FormCheckInCheckOut();
            //form.ShowDialog();
            Show();
        }
    }
}
