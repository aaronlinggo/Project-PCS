namespace Hotel_Harem_SamGun
{
    partial class FormReservasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservasi = new System.Windows.Forms.DataGridView();
            this.btReservasi = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.dtpJadwalCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpJadwalCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbJenisKamar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbKodeReservasi = new System.Windows.Forms.Label();
            this.cbNamaTamu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNomorKamar = new System.Windows.Forms.ComboBox();
            this.btTambahTamu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCari = new System.Windows.Forms.ComboBox();
            this.btCari = new System.Windows.Forms.Button();
            this.btKembali = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbDownPayment = new System.Windows.Forms.Label();
            this.lbDeposito = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 575);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jadwal Check In :";
            // 
            // dgvReservasi
            // 
            this.dgvReservasi.AllowUserToAddRows = false;
            this.dgvReservasi.AllowUserToDeleteRows = false;
            this.dgvReservasi.AllowUserToResizeColumns = false;
            this.dgvReservasi.AllowUserToResizeRows = false;
            this.dgvReservasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReservasi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasi.Location = new System.Drawing.Point(13, 105);
            this.dgvReservasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservasi.Name = "dgvReservasi";
            this.dgvReservasi.ReadOnly = true;
            this.dgvReservasi.RowHeadersVisible = false;
            this.dgvReservasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservasi.Size = new System.Drawing.Size(1238, 347);
            this.dgvReservasi.TabIndex = 99;
            this.dgvReservasi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservasi_CellDoubleClick);
            // 
            // btReservasi
            // 
            this.btReservasi.Location = new System.Drawing.Point(1034, 496);
            this.btReservasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btReservasi.Name = "btReservasi";
            this.btReservasi.Size = new System.Drawing.Size(174, 50);
            this.btReservasi.TabIndex = 2;
            this.btReservasi.Text = "RESERVASI";
            this.btReservasi.UseVisualStyleBackColor = true;
            this.btReservasi.Click += new System.EventHandler(this.btReservasi_Click);
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(1034, 575);
            this.btBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(174, 49);
            this.btBatal.TabIndex = 3;
            this.btBatal.Text = "BATAL";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // dtpJadwalCheckIn
            // 
            this.dtpJadwalCheckIn.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpJadwalCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJadwalCheckIn.Location = new System.Drawing.Point(166, 570);
            this.dtpJadwalCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpJadwalCheckIn.Name = "dtpJadwalCheckIn";
            this.dtpJadwalCheckIn.Size = new System.Drawing.Size(298, 26);
            this.dtpJadwalCheckIn.TabIndex = 4;
            this.dtpJadwalCheckIn.ValueChanged += new System.EventHandler(this.dtpJadwalCheckIn_ValueChanged);
            // 
            // dtpJadwalCheckOut
            // 
            this.dtpJadwalCheckOut.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpJadwalCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJadwalCheckOut.Location = new System.Drawing.Point(166, 621);
            this.dtpJadwalCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpJadwalCheckOut.Name = "dtpJadwalCheckOut";
            this.dtpJadwalCheckOut.Size = new System.Drawing.Size(298, 26);
            this.dtpJadwalCheckOut.TabIndex = 5;
            this.dtpJadwalCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 626);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jadwal Check Out :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama Tamu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 481);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jenis Kamar :";
            // 
            // cbJenisKamar
            // 
            this.cbJenisKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisKamar.FormattingEnabled = true;
            this.cbJenisKamar.Location = new System.Drawing.Point(675, 478);
            this.cbJenisKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbJenisKamar.Name = "cbJenisKamar";
            this.cbJenisKamar.Size = new System.Drawing.Size(258, 28);
            this.cbJenisKamar.TabIndex = 10;
            this.cbJenisKamar.SelectedIndexChanged += new System.EventHandler(this.cbJenisKamar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 475);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kode Reservasi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 626);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Deposito :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 575);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Down Payment :";
            // 
            // lbKodeReservasi
            // 
            this.lbKodeReservasi.AutoSize = true;
            this.lbKodeReservasi.Location = new System.Drawing.Point(203, 475);
            this.lbKodeReservasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKodeReservasi.Name = "lbKodeReservasi";
            this.lbKodeReservasi.Size = new System.Drawing.Size(14, 20);
            this.lbKodeReservasi.TabIndex = 16;
            this.lbKodeReservasi.Text = "-";
            // 
            // cbNamaTamu
            // 
            this.cbNamaTamu.FormattingEnabled = true;
            this.cbNamaTamu.Location = new System.Drawing.Point(166, 522);
            this.cbNamaTamu.Name = "cbNamaTamu";
            this.cbNamaTamu.Size = new System.Drawing.Size(246, 28);
            this.cbNamaTamu.TabIndex = 19;
            this.cbNamaTamu.SelectedIndexChanged += new System.EventHandler(this.cbNamaTamu_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(553, 530);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nomor Kamar :";
            // 
            // cbNomorKamar
            // 
            this.cbNomorKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomorKamar.FormattingEnabled = true;
            this.cbNomorKamar.Location = new System.Drawing.Point(675, 526);
            this.cbNomorKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNomorKamar.Name = "cbNomorKamar";
            this.cbNomorKamar.Size = new System.Drawing.Size(132, 28);
            this.cbNomorKamar.TabIndex = 23;
            this.cbNomorKamar.SelectedIndexChanged += new System.EventHandler(this.cbNomorKamar_SelectedIndexChanged);
            // 
            // btTambahTamu
            // 
            this.btTambahTamu.Location = new System.Drawing.Point(417, 522);
            this.btTambahTamu.Name = "btTambahTamu";
            this.btTambahTamu.Size = new System.Drawing.Size(47, 28);
            this.btTambahTamu.TabIndex = 24;
            this.btTambahTamu.Text = "...";
            this.btTambahTamu.UseVisualStyleBackColor = true;
            this.btTambahTamu.Click += new System.EventHandler(this.btTambahTamu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pencarian :";
            // 
            // cbCari
            // 
            this.cbCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCari.FormattingEnabled = true;
            this.cbCari.Location = new System.Drawing.Point(179, 70);
            this.cbCari.Name = "cbCari";
            this.cbCari.Size = new System.Drawing.Size(383, 28);
            this.cbCari.TabIndex = 0;
            // 
            // btCari
            // 
            this.btCari.Location = new System.Drawing.Point(568, 69);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(174, 28);
            this.btCari.TabIndex = 1;
            this.btCari.Text = "Cari";
            this.btCari.UseVisualStyleBackColor = true;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(1052, 25);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(174, 49);
            this.btKembali.TabIndex = 28;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = true;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Selesai",
            "Dipesan",
            "Check In",
            "Batal"});
            this.cbStatus.Location = new System.Drawing.Point(179, 36);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(209, 28);
            this.cbStatus.TabIndex = 100;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 20);
            this.label11.TabIndex = 101;
            this.label11.Text = "Berdasarkan Status :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 102;
            this.label12.Text = "Data :";
            // 
            // lbDownPayment
            // 
            this.lbDownPayment.Location = new System.Drawing.Point(685, 575);
            this.lbDownPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDownPayment.Name = "lbDownPayment";
            this.lbDownPayment.Size = new System.Drawing.Size(181, 20);
            this.lbDownPayment.TabIndex = 103;
            this.lbDownPayment.Text = "-";
            this.lbDownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDeposito
            // 
            this.lbDeposito.Location = new System.Drawing.Point(685, 626);
            this.lbDeposito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeposito.Name = "lbDeposito";
            this.lbDeposito.Size = new System.Drawing.Size(181, 20);
            this.lbDeposito.TabIndex = 104;
            this.lbDeposito.Text = "-";
            this.lbDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(417, 36);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(165, 28);
            this.btClear.TabIndex = 106;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FormReservasi
            // 
            this.AcceptButton = this.btTambahTamu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbDeposito);
            this.Controls.Add(this.lbDownPayment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btCari);
            this.Controls.Add(this.cbCari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btTambahTamu);
            this.Controls.Add(this.cbNomorKamar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbNamaTamu);
            this.Controls.Add(this.lbKodeReservasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbJenisKamar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpJadwalCheckOut);
            this.Controls.Add(this.dtpJadwalCheckIn);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btReservasi);
            this.Controls.Add(this.dgvReservasi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReservasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Reservasi";
            this.Load += new System.EventHandler(this.FormReservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservasi;
        private System.Windows.Forms.Button btReservasi;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.DateTimePicker dtpJadwalCheckIn;
        private System.Windows.Forms.DateTimePicker dtpJadwalCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbJenisKamar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbKodeReservasi;
        private System.Windows.Forms.ComboBox cbNamaTamu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNomorKamar;
        private System.Windows.Forms.Button btTambahTamu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCari;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.Button btKembali;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDownPayment;
        private System.Windows.Forms.Label lbDeposito;
        private System.Windows.Forms.Button btClear;
    }
}