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
            lblReportTitle.Text = "Laporan Pemesanan Kamar Bulanan";
            LaporanPemesananKamarBulanan mainReport = new LaporanPemesananKamarBulanan();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "Laporan Penambahan Fasilitas Paling Laris";
            LaporanPenambahanFasilitasPalingLaris mainReport = new LaporanPenambahanFasilitasPalingLaris();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "Laporan Jumlah Tamu per Bulan";
            LaporanJumlahTamuPerbulan mainReport = new LaporanJumlahTamuPerbulan();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "Laporan Tipe Kamar Paling Laris";
            LaporanPemesananTipeKamarPalingLaris mainReport = new LaporanPemesananTipeKamarPalingLaris();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            lblReportTitle.Text = "Laporan Penjualan Makanan Paling Laris";
            LaporanPenjualanMakananPalingLaku mainReport = new LaporanPenjualanMakananPalingLaku();
            mainReport.SetDatabaseLogon(Koneksi.uid, Koneksi.pass, Koneksi.server, Koneksi.database);
            crystalReportViewer1.ReportSource = mainReport;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
