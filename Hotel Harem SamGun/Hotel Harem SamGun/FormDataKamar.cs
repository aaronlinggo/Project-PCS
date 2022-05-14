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
    public partial class FormDataKamar : Form
    {
        public FormDataKamar()
        {
            InitializeComponent();
        }

        private void numLantai_ValueChanged(object sender, EventArgs e)
        {
            tbNama.Text = $"{numLantai.Value}" + ($"{numNoKamar.Value}").PadLeft(2,'0'); 
        }

        private void numNoKamar_ValueChanged(object sender, EventArgs e)
        {
            tbNama.Text = $"{numLantai.Value}" + ($"{numNoKamar.Value}").PadLeft(2, '0');
        }
    }
}
