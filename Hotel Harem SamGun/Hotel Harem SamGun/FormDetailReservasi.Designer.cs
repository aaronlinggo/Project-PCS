
namespace Hotel_Harem_SamGun
{
    partial class FormDetailReservasi
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
            this.btClear = new System.Windows.Forms.Button();
            this.lbDeposito = new System.Windows.Forms.Label();
            this.lbDownPayment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btKembali = new System.Windows.Forms.Button();
            this.btCari = new System.Windows.Forms.Button();
            this.cbCari = new System.Windows.Forms.ComboBox();
            this.cbNomorKamar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbKodeReservasi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbJenisKamar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpJadwalCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpJadwalCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btBatal = new System.Windows.Forms.Button();
            this.btReservasi = new System.Windows.Forms.Button();
            this.dgvDetailReservasi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudJumlahPenghuniKamar = new System.Windows.Forms.NumericUpDown();
            this.btTambahTamu = new System.Windows.Forms.Button();
            this.cbNamaTamu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.legend99 = new System.Windows.Forms.Panel();
            this.legend1 = new System.Windows.Forms.Panel();
            this.legend0 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cbReservasiBaru = new System.Windows.Forms.CheckBox();
            this.cbKodeReservasi = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbSubtotalBiaya = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReservasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahPenghuniKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(1002, 13);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(118, 33);
            this.btClear.TabIndex = 134;
            this.btClear.Text = "BERSIHKAN";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btBersihkan_Click);
            // 
            // lbDeposito
            // 
            this.lbDeposito.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeposito.Location = new System.Drawing.Point(859, 592);
            this.lbDeposito.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDeposito.Name = "lbDeposito";
            this.lbDeposito.Size = new System.Drawing.Size(201, 31);
            this.lbDeposito.TabIndex = 133;
            this.lbDeposito.Text = "-";
            this.lbDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDownPayment
            // 
            this.lbDownPayment.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDownPayment.Location = new System.Drawing.Point(859, 551);
            this.lbDownPayment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDownPayment.Name = "lbDownPayment";
            this.lbDownPayment.Size = new System.Drawing.Size(201, 31);
            this.lbDownPayment.TabIndex = 132;
            this.lbDownPayment.Text = "-";
            this.lbDownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 26);
            this.label12.TabIndex = 131;
            this.label12.Text = "Nama Tamu - Kode Reservasi :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(276, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 26);
            this.label11.TabIndex = 130;
            this.label11.Text = "Status :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Selesai",
            "Dipesan",
            "Check In",
            "Dibatalkan"});
            this.cbStatus.Location = new System.Drawing.Point(570, 14);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(299, 31);
            this.cbStatus.TabIndex = 129;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btKembali.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKembali.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembali.ForeColor = System.Drawing.Color.White;
            this.btKembali.Location = new System.Drawing.Point(1126, 13);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(118, 33);
            this.btKembali.TabIndex = 127;
            this.btKembali.Text = "KEMBALI";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // btCari
            // 
            this.btCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCari.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCari.ForeColor = System.Drawing.Color.White;
            this.btCari.Location = new System.Drawing.Point(878, 13);
            this.btCari.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(118, 33);
            this.btCari.TabIndex = 109;
            this.btCari.Text = "CARI";
            this.btCari.UseVisualStyleBackColor = false;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // cbCari
            // 
            this.cbCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCari.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCari.FormattingEnabled = true;
            this.cbCari.Location = new System.Drawing.Point(570, 55);
            this.cbCari.Name = "cbCari";
            this.cbCari.Size = new System.Drawing.Size(299, 31);
            this.cbCari.TabIndex = 108;
            // 
            // cbNomorKamar
            // 
            this.cbNomorKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomorKamar.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.cbNomorKamar.FormattingEnabled = true;
            this.cbNomorKamar.Location = new System.Drawing.Point(859, 510);
            this.cbNomorKamar.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.cbNomorKamar.Name = "cbNomorKamar";
            this.cbNomorKamar.Size = new System.Drawing.Size(201, 31);
            this.cbNomorKamar.TabIndex = 124;
            this.cbNomorKamar.SelectedIndexChanged += new System.EventHandler(this.cbNomorKamar_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label10.Location = new System.Drawing.Point(621, 512);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 26);
            this.label10.TabIndex = 123;
            this.label10.Text = "Nomor Kamar :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbKodeReservasi
            // 
            this.lbKodeReservasi.AutoSize = true;
            this.lbKodeReservasi.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKodeReservasi.Location = new System.Drawing.Point(381, 430);
            this.lbKodeReservasi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKodeReservasi.Name = "lbKodeReservasi";
            this.lbKodeReservasi.Size = new System.Drawing.Size(18, 27);
            this.lbKodeReservasi.TabIndex = 121;
            this.lbKodeReservasi.Text = "-";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label9.Location = new System.Drawing.Point(621, 553);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 26);
            this.label9.TabIndex = 120;
            this.label9.Text = "Down Payment :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label8.Location = new System.Drawing.Point(621, 594);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 26);
            this.label8.TabIndex = 119;
            this.label8.Text = "Deposito :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbJenisKamar
            // 
            this.cbJenisKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisKamar.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.cbJenisKamar.FormattingEnabled = true;
            this.cbJenisKamar.Location = new System.Drawing.Point(859, 469);
            this.cbJenisKamar.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.cbJenisKamar.Name = "cbJenisKamar";
            this.cbJenisKamar.Size = new System.Drawing.Size(201, 31);
            this.cbJenisKamar.TabIndex = 117;
            this.cbJenisKamar.SelectedIndexChanged += new System.EventHandler(this.cbJenisKamar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label4.Location = new System.Drawing.Point(621, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 26);
            this.label4.TabIndex = 116;
            this.label4.Text = "Jenis Kamar :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 512);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 26);
            this.label3.TabIndex = 115;
            this.label3.Text = "Nama Tamu :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 635);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 26);
            this.label2.TabIndex = 114;
            this.label2.Text = "Jadwal Check Out :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpJadwalCheckOut
            // 
            this.dtpJadwalCheckOut.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpJadwalCheckOut.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.dtpJadwalCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJadwalCheckOut.Location = new System.Drawing.Point(386, 633);
            this.dtpJadwalCheckOut.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.dtpJadwalCheckOut.Name = "dtpJadwalCheckOut";
            this.dtpJadwalCheckOut.Size = new System.Drawing.Size(201, 29);
            this.dtpJadwalCheckOut.TabIndex = 113;
            this.dtpJadwalCheckOut.ValueChanged += new System.EventHandler(this.dtpJadwalCheckOut_ValueChanged);
            // 
            // dtpJadwalCheckIn
            // 
            this.dtpJadwalCheckIn.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpJadwalCheckIn.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.dtpJadwalCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJadwalCheckIn.Location = new System.Drawing.Point(386, 592);
            this.dtpJadwalCheckIn.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.dtpJadwalCheckIn.Name = "dtpJadwalCheckIn";
            this.dtpJadwalCheckIn.Size = new System.Drawing.Size(201, 29);
            this.dtpJadwalCheckIn.TabIndex = 112;
            this.dtpJadwalCheckIn.ValueChanged += new System.EventHandler(this.dtpJadwalCheckIn_ValueChanged);
            // 
            // btBatal
            // 
            this.btBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBatal.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBatal.ForeColor = System.Drawing.Color.White;
            this.btBatal.Location = new System.Drawing.Point(1126, 509);
            this.btBatal.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(118, 33);
            this.btBatal.TabIndex = 111;
            this.btBatal.Text = "BATAL";
            this.btBatal.UseVisualStyleBackColor = false;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btReservasi
            // 
            this.btReservasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservasi.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReservasi.ForeColor = System.Drawing.Color.White;
            this.btReservasi.Location = new System.Drawing.Point(1126, 468);
            this.btReservasi.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btReservasi.Name = "btReservasi";
            this.btReservasi.Size = new System.Drawing.Size(118, 33);
            this.btReservasi.TabIndex = 110;
            this.btReservasi.Text = "RESERVASI";
            this.btReservasi.UseVisualStyleBackColor = false;
            this.btReservasi.Click += new System.EventHandler(this.btReservasi_Click);
            // 
            // dgvDetailReservasi
            // 
            this.dgvDetailReservasi.AllowUserToAddRows = false;
            this.dgvDetailReservasi.AllowUserToDeleteRows = false;
            this.dgvDetailReservasi.AllowUserToResizeColumns = false;
            this.dgvDetailReservasi.AllowUserToResizeRows = false;
            this.dgvDetailReservasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetailReservasi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetailReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailReservasi.Location = new System.Drawing.Point(21, 100);
            this.dgvDetailReservasi.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.dgvDetailReservasi.Name = "dgvDetailReservasi";
            this.dgvDetailReservasi.ReadOnly = true;
            this.dgvDetailReservasi.RowHeadersVisible = false;
            this.dgvDetailReservasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDetailReservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailReservasi.Size = new System.Drawing.Size(1222, 276);
            this.dgvDetailReservasi.TabIndex = 128;
            this.dgvDetailReservasi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservasi_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 594);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 107;
            this.label1.Text = "Jadwal Check In :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 38);
            this.label6.TabIndex = 135;
            this.label6.Text = "DETAIL RESERVASI";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 553);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 26);
            this.label7.TabIndex = 137;
            this.label7.Text = "Jumlah Penghuni Kamar :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudJumlahPenghuniKamar
            // 
            this.nudJumlahPenghuniKamar.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.nudJumlahPenghuniKamar.Location = new System.Drawing.Point(386, 551);
            this.nudJumlahPenghuniKamar.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.nudJumlahPenghuniKamar.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudJumlahPenghuniKamar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJumlahPenghuniKamar.Name = "nudJumlahPenghuniKamar";
            this.nudJumlahPenghuniKamar.Size = new System.Drawing.Size(201, 29);
            this.nudJumlahPenghuniKamar.TabIndex = 138;
            this.nudJumlahPenghuniKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudJumlahPenghuniKamar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btTambahTamu
            // 
            this.btTambahTamu.Location = new System.Drawing.Point(555, 509);
            this.btTambahTamu.Name = "btTambahTamu";
            this.btTambahTamu.Size = new System.Drawing.Size(33, 33);
            this.btTambahTamu.TabIndex = 139;
            this.btTambahTamu.Text = "...";
            this.btTambahTamu.UseVisualStyleBackColor = true;
            this.btTambahTamu.Click += new System.EventHandler(this.btTambahTamu_Click);
            // 
            // cbNamaTamu
            // 
            this.cbNamaTamu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamaTamu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNamaTamu.Enabled = false;
            this.cbNamaTamu.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.cbNamaTamu.FormattingEnabled = true;
            this.cbNamaTamu.Location = new System.Drawing.Point(386, 510);
            this.cbNamaTamu.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.cbNamaTamu.Name = "cbNamaTamu";
            this.cbNamaTamu.Size = new System.Drawing.Size(164, 31);
            this.cbNamaTamu.TabIndex = 140;
            this.cbNamaTamu.SelectedIndexChanged += new System.EventHandler(this.cbNamaTamu_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.label13.Location = new System.Drawing.Point(48, 502);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 23);
            this.label13.TabIndex = 152;
            this.label13.Text = "Dibatalkan";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.label14.Location = new System.Drawing.Point(48, 476);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 23);
            this.label14.TabIndex = 151;
            this.label14.Text = "Check In";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.label15.Location = new System.Drawing.Point(48, 424);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 23);
            this.label15.TabIndex = 150;
            this.label15.Text = "Selesai";
            // 
            // legend99
            // 
            this.legend99.BackColor = System.Drawing.Color.DarkGray;
            this.legend99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legend99.Location = new System.Drawing.Point(21, 504);
            this.legend99.Name = "legend99";
            this.legend99.Size = new System.Drawing.Size(20, 20);
            this.legend99.TabIndex = 149;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.LightGreen;
            this.legend1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legend1.Location = new System.Drawing.Point(21, 478);
            this.legend1.Name = "legend1";
            this.legend1.Size = new System.Drawing.Size(20, 20);
            this.legend1.TabIndex = 148;
            // 
            // legend0
            // 
            this.legend0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legend0.Location = new System.Drawing.Point(21, 426);
            this.legend0.Name = "legend0";
            this.legend0.Size = new System.Drawing.Size(20, 20);
            this.legend0.TabIndex = 147;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(21, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 149;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.label16.Location = new System.Drawing.Point(48, 450);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 23);
            this.label16.TabIndex = 153;
            this.label16.Text = "Dipesan";
            // 
            // cbReservasiBaru
            // 
            this.cbReservasiBaru.AutoSize = true;
            this.cbReservasiBaru.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.cbReservasiBaru.Location = new System.Drawing.Point(386, 389);
            this.cbReservasiBaru.Name = "cbReservasiBaru";
            this.cbReservasiBaru.Size = new System.Drawing.Size(144, 31);
            this.cbReservasiBaru.TabIndex = 154;
            this.cbReservasiBaru.Text = "Reservasi Baru";
            this.cbReservasiBaru.UseVisualStyleBackColor = true;
            this.cbReservasiBaru.CheckedChanged += new System.EventHandler(this.cbReservasiBaru_CheckedChanged);
            // 
            // cbKodeReservasi
            // 
            this.cbKodeReservasi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKodeReservasi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKodeReservasi.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.cbKodeReservasi.FormattingEnabled = true;
            this.cbKodeReservasi.Location = new System.Drawing.Point(386, 469);
            this.cbKodeReservasi.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.cbKodeReservasi.Name = "cbKodeReservasi";
            this.cbKodeReservasi.Size = new System.Drawing.Size(201, 31);
            this.cbKodeReservasi.TabIndex = 155;
            this.cbKodeReservasi.SelectedIndexChanged += new System.EventHandler(this.cbKodeReservasi_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label17.Location = new System.Drawing.Point(621, 635);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(229, 26);
            this.label17.TabIndex = 156;
            this.label17.Text = "Subtotal Biaya Tambahan :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSubtotalBiaya
            // 
            this.lbSubtotalBiaya.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotalBiaya.Location = new System.Drawing.Point(859, 633);
            this.lbSubtotalBiaya.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSubtotalBiaya.Name = "lbSubtotalBiaya";
            this.lbSubtotalBiaya.Size = new System.Drawing.Size(201, 31);
            this.lbSubtotalBiaya.TabIndex = 157;
            this.lbSubtotalBiaya.Text = "-";
            this.lbSubtotalBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(148, 430);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(229, 26);
            this.label18.TabIndex = 158;
            this.label18.Text = "Kode Reservasi :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormDetailReservasi
            // 
            this.AcceptButton = this.btTambahTamu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btKembali;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbSubtotalBiaya);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbKodeReservasi);
            this.Controls.Add(this.cbReservasiBaru);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.legend99);
            this.Controls.Add(this.legend1);
            this.Controls.Add(this.legend0);
            this.Controls.Add(this.cbNamaTamu);
            this.Controls.Add(this.btTambahTamu);
            this.Controls.Add(this.nudJumlahPenghuniKamar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbDeposito);
            this.Controls.Add(this.lbDownPayment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btCari);
            this.Controls.Add(this.cbCari);
            this.Controls.Add(this.cbNomorKamar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbKodeReservasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbJenisKamar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpJadwalCheckOut);
            this.Controls.Add(this.dtpJadwalCheckIn);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btReservasi);
            this.Controls.Add(this.dgvDetailReservasi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDetailReservasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Reservasi";
            this.Load += new System.EventHandler(this.FormDetailReservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReservasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahPenghuniKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbDeposito;
        private System.Windows.Forms.Label lbDownPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btKembali;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.ComboBox cbCari;
        private System.Windows.Forms.ComboBox cbNomorKamar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbKodeReservasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbJenisKamar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpJadwalCheckOut;
        private System.Windows.Forms.DateTimePicker dtpJadwalCheckIn;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Button btReservasi;
        private System.Windows.Forms.DataGridView dgvDetailReservasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudJumlahPenghuniKamar;
        private System.Windows.Forms.Button btTambahTamu;
        private System.Windows.Forms.ComboBox cbNamaTamu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel legend99;
        private System.Windows.Forms.Panel legend1;
        private System.Windows.Forms.Panel legend0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbReservasiBaru;
        private System.Windows.Forms.ComboBox cbKodeReservasi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbSubtotalBiaya;
        private System.Windows.Forms.Label label18;
    }
}