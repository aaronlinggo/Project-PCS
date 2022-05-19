
namespace Hotel_Harem_SamGun
{
    partial class FormLaporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.btnReport1 = new System.Windows.Forms.Button();
            this.btnReport2 = new System.Windows.Forms.Button();
            this.btnReport4 = new System.Windows.Forms.Button();
            this.btnReport3 = new System.Windows.Forms.Button();
            this.btnReport5 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnReport5);
            this.panel1.Controls.Add(this.btnReport3);
            this.panel1.Controls.Add(this.btnReport4);
            this.panel1.Controls.Add(this.btnReport2);
            this.panel1.Controls.Add(this.btnReport1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 674);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(274, 65);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(976, 596);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(274, 13);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(231, 36);
            this.lblReportTitle.TabIndex = 2;
            this.lblReportTitle.Text = "Laporan <???>";
            // 
            // btnReport1
            // 
            this.btnReport1.Location = new System.Drawing.Point(12, 13);
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(242, 70);
            this.btnReport1.TabIndex = 0;
            this.btnReport1.Text = "Laporan Pemesanan Kamar Bulanan";
            this.btnReport1.UseVisualStyleBackColor = true;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // btnReport2
            // 
            this.btnReport2.Location = new System.Drawing.Point(12, 89);
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(242, 70);
            this.btnReport2.TabIndex = 1;
            this.btnReport2.Text = "Laporan Penambahan Fasilitas Paling Laris";
            this.btnReport2.UseVisualStyleBackColor = true;
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
            // 
            // btnReport4
            // 
            this.btnReport4.Location = new System.Drawing.Point(12, 241);
            this.btnReport4.Name = "btnReport4";
            this.btnReport4.Size = new System.Drawing.Size(242, 70);
            this.btnReport4.TabIndex = 2;
            this.btnReport4.Text = "Laporan Tipe Kamar Paling Laris";
            this.btnReport4.UseVisualStyleBackColor = true;
            this.btnReport4.Click += new System.EventHandler(this.btnReport4_Click);
            // 
            // btnReport3
            // 
            this.btnReport3.Location = new System.Drawing.Point(12, 165);
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(242, 70);
            this.btnReport3.TabIndex = 3;
            this.btnReport3.Text = "Laporan Jumlah Tamu per Bulan";
            this.btnReport3.UseVisualStyleBackColor = true;
            this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);
            // 
            // btnReport5
            // 
            this.btnReport5.Location = new System.Drawing.Point(12, 317);
            this.btnReport5.Name = "btnReport5";
            this.btnReport5.Size = new System.Drawing.Size(242, 70);
            this.btnReport5.TabIndex = 4;
            this.btnReport5.Text = "Laporan Penjualan Makanan Paling Laris";
            this.btnReport5.UseVisualStyleBackColor = true;
            this.btnReport5.Click += new System.EventHandler(this.btnReport5_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 591);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 70);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Kembali ke Menu Utama";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporan";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReport3;
        private System.Windows.Forms.Button btnReport4;
        private System.Windows.Forms.Button btnReport2;
        private System.Windows.Forms.Button btnReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReport5;
    }
}