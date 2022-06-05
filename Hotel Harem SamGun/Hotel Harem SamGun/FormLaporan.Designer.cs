
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReport5 = new System.Windows.Forms.Button();
            this.btnReport3 = new System.Windows.Forms.Button();
            this.btnReport4 = new System.Windows.Forms.Button();
            this.btnReport2 = new System.Windows.Forms.Button();
            this.btnReport1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnReport5);
            this.panel1.Controls.Add(this.btnReport3);
            this.panel1.Controls.Add(this.btnReport4);
            this.panel1.Controls.Add(this.btnReport2);
            this.panel1.Controls.Add(this.btnReport1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 674);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 96);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 591);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 70);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "KEMBALI KE MENU UTAMA";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReport5
            // 
            this.btnReport5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReport5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport5.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnReport5.ForeColor = System.Drawing.Color.White;
            this.btnReport5.Location = new System.Drawing.Point(12, 447);
            this.btnReport5.Name = "btnReport5";
            this.btnReport5.Size = new System.Drawing.Size(242, 70);
            this.btnReport5.TabIndex = 4;
            this.btnReport5.Text = "LAPORAN PENJUALAN MAKANAN PALING LARIS";
            this.btnReport5.UseVisualStyleBackColor = false;
            this.btnReport5.Click += new System.EventHandler(this.btnReport5_Click);
            // 
            // btnReport3
            // 
            this.btnReport3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReport3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport3.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnReport3.ForeColor = System.Drawing.Color.White;
            this.btnReport3.Location = new System.Drawing.Point(12, 295);
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(242, 70);
            this.btnReport3.TabIndex = 3;
            this.btnReport3.Text = "LAPORAN JUMLAH TAMU PER BULAN";
            this.btnReport3.UseVisualStyleBackColor = false;
            this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);
            // 
            // btnReport4
            // 
            this.btnReport4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReport4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport4.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnReport4.ForeColor = System.Drawing.Color.White;
            this.btnReport4.Location = new System.Drawing.Point(12, 371);
            this.btnReport4.Name = "btnReport4";
            this.btnReport4.Size = new System.Drawing.Size(242, 70);
            this.btnReport4.TabIndex = 2;
            this.btnReport4.Text = "LAPORAN JENIS KAMAR PALING LARIS";
            this.btnReport4.UseVisualStyleBackColor = false;
            this.btnReport4.Click += new System.EventHandler(this.btnReport4_Click);
            // 
            // btnReport2
            // 
            this.btnReport2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReport2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport2.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnReport2.ForeColor = System.Drawing.Color.White;
            this.btnReport2.Location = new System.Drawing.Point(12, 219);
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(242, 70);
            this.btnReport2.TabIndex = 1;
            this.btnReport2.Text = "LAPORAN PENAMBAHAN FASILITAS PALING LARIS";
            this.btnReport2.UseVisualStyleBackColor = false;
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
            // 
            // btnReport1
            // 
            this.btnReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReport1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport1.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnReport1.ForeColor = System.Drawing.Color.White;
            this.btnReport1.Location = new System.Drawing.Point(12, 143);
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(242, 70);
            this.btnReport1.TabIndex = 0;
            this.btnReport1.Text = "LAPORAN PEMESANAN KAMAR BULANAN";
            this.btnReport1.UseVisualStyleBackColor = false;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(276, 65);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(976, 596);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblReportTitle.Location = new System.Drawing.Point(269, 13);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(229, 38);
            this.lblReportTitle.TabIndex = 2;
            this.lblReportTitle.Text = "LAPORAN <???>";
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}