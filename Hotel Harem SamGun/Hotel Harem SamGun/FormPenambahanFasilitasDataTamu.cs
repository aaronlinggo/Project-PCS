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
    public partial class FormPenambahanFasilitasDataTamu : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        DataTable dt;
        public int id_reservasi;

        public FormPenambahanFasilitasDataTamu()
        {
            Koneksi.openConn();
            conn = Koneksi.conn;
            InitializeComponent();
            refreshDGV();
            
        }

        public void refreshDGV()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id_header_reservasi, hr.kode_reservasi, nama_tamu, nomor_kamar, nama_jenis_kamar, DATE_FORMAT(tanggal_check_in,'%W, %d %M %Y') FROM header_reservasi hr JOIN tamu t ON t.kode_tamu = hr.kode_tamu JOIN detail_reservasi dr ON hr.kode_reservasi = dr.kode_reservasi JOIN kamar k ON k.kode_kamar = dr.kode_kamar  JOIN jenis_kamar jk ON jk.id_jenis_kamar = k.id_jenis_kamar WHERE tanggal_check_in IS NOT NULL AND tanggal_check_out IS NULL";
            dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nomor Reservasi";
            dataGridView1.Columns[2].HeaderText = "Nama Tamu";
            dataGridView1.Columns[3].HeaderText = "Nomor Kamar";
            dataGridView1.Columns[4].HeaderText = "Nama Jenis Kamar";
            dataGridView1.Columns[5].HeaderText = "Tanggal Check In";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void searchDGV(string tamu, string no_kamar)
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT id_header_reservasi, hr.kode_reservasi, nama_tamu, nomor_kamar, nama_jenis_kamar, DATE_FORMAT(tanggal_check_in,'%W, %d %M %Y') FROM header_reservasi hr JOIN tamu t ON t.kode_tamu = hr.kode_tamu JOIN detail_reservasi dr ON hr.kode_reservasi = dr.kode_reservasi JOIN kamar k ON k.kode_kamar = dr.kode_kamar  JOIN jenis_kamar jk ON jk.id_jenis_kamar = k.id_jenis_kamar WHERE tanggal_check_in IS NOT NULL AND tanggal_check_out IS NULL AND nama_tamu LIKE'%{tamu}%' AND nomor_kamar LIKE '%{no_kamar}%'";
            dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nomor Reservasi";
            dataGridView1.Columns[2].HeaderText = "Nama Tamu";
            dataGridView1.Columns[3].HeaderText = "Nomor Kamar";
            dataGridView1.Columns[4].HeaderText = "Nama Jenis Kamar";
            dataGridView1.Columns[5].HeaderText = "Tanggal Check In";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            int selectedIdx = dataGridView1.CurrentCell.RowIndex; 
            id_reservasi = Convert.ToInt32(dataGridView1.Rows[selectedIdx].Cells[0].Value.ToString());
            FormPenambahanFasilitasKamar form = new FormPenambahanFasilitasKamar(this);
            form.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchDGV(tbTamu.Text, tbNoKamar.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshDGV();
            tbNoKamar.Text = "";
            tbTamu.Text = "";
        }

        private void tbNoKamar_TextChanged(object sender, EventArgs e)
        {
            if (tbNoKamar.Text.Length > 0)
            {
                char temp = tbNoKamar.Text[(tbNoKamar.Text.Length - 1)];
                if (!Char.IsDigit(temp))
                {
                    tbNoKamar.Text = tbNoKamar.Text.Remove(tbNoKamar.Text.Length - 1, 1);
                    tbNoKamar.SelectionStart = tbNoKamar.Text.Length;
                }
            }
        }
    }
}
