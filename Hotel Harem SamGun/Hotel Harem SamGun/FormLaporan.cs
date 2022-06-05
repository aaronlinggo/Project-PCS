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
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "LAPORAN PEMESANAN KAMAR BULANAN";
            LaporanPemesananKamarBulanan mainReport = new LaporanPemesananKamarBulanan();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
            btnReport1.BackColor = Color.FromArgb(255,69,0);
            btnReport2.BackColor = Color.FromArgb(255, 128, 0);
            btnReport3.BackColor = Color.FromArgb(255, 128, 0);
            btnReport4.BackColor = Color.FromArgb(255, 128, 0);
            btnReport5.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "LAPORAN PENAMBAHAN FASILITAS PALING LARIS";
            LaporanPenambahanFasilitasPalingLaris mainReport = new LaporanPenambahanFasilitasPalingLaris();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
            btnReport1.BackColor = Color.FromArgb(255, 128, 0);
            btnReport2.BackColor = Color.FromArgb(255, 69, 0);
            btnReport3.BackColor = Color.FromArgb(255, 128, 0);
            btnReport4.BackColor = Color.FromArgb(255, 128, 0);
            btnReport5.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "LAPORAN JUMLAH TAMU PER BULAN";
            LaporanJumlahTamuPerbulan mainReport = new LaporanJumlahTamuPerbulan();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
            btnReport1.BackColor = Color.FromArgb(255, 128, 0);
            btnReport2.BackColor = Color.FromArgb(255, 128, 0);
            btnReport3.BackColor = Color.FromArgb(255, 69, 0);
            btnReport4.BackColor = Color.FromArgb(255, 128, 0);
            btnReport5.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "LAPORAN JENIS KAMAR PALING LARIS";
            LaporanPemesananTipeKamarPalingLaris mainReport = new LaporanPemesananTipeKamarPalingLaris();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
            btnReport1.BackColor = Color.FromArgb(255, 128, 0);
            btnReport2.BackColor = Color.FromArgb(255, 128, 0);
            btnReport3.BackColor = Color.FromArgb(255, 128, 0);
            btnReport4.BackColor = Color.FromArgb(255, 69, 0);
            btnReport5.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "LAPORAN PENJUALAN MAKANAN PALING LARIS";
            LaporanPenjualanMakananPalingLaku mainReport = new LaporanPenjualanMakananPalingLaku();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
            btnReport1.BackColor = Color.FromArgb(255, 128, 0);
            btnReport2.BackColor = Color.FromArgb(255, 128, 0);
            btnReport3.BackColor = Color.FromArgb(255, 128, 0);
            btnReport4.BackColor = Color.FromArgb(255, 128, 0);
            btnReport5.BackColor = Color.FromArgb(255, 69, 0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
