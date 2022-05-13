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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btDataResepsionis_Click(object sender, EventArgs e)
        {
            Hide();
            //FormDataResepsionis form = new FormDataResepsionis();
            //form.ShowDialog();
            Show();
        }

        private void btDataMenuMakanan_Click(object sender, EventArgs e)
        {
            Hide();
            //FormDataMenuMakanan form = new FormDataMenuMakanan();
            //form.ShowDialog();
            Show();
        }

        private void btDataKamar_Click(object sender, EventArgs e)
        {
            Hide();
            //FormDataKamar form = new FormDataKamar();
            //form.ShowDialog();
            Show();
        }

        private void btDataFasilitasTambahanKamar_Click(object sender, EventArgs e)
        {
            Hide();
            //FormDataFasilitasTambahanKamar form = new FormDataFasilitasTambahanKamar();
            //form.ShowDialog();
            Show();
        }

        private void btLaporan_Click(object sender, EventArgs e)
        {
            Hide();
            //FormLaporan form = new FormLaporan();
            //form.ShowDialog();
            Show();
        }
    }
}
