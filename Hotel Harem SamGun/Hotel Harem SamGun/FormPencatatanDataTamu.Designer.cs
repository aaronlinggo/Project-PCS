
namespace Hotel_Harem_SamGun
{
    partial class FormPencatatanDataTamu
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
            this.dgvTamu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.rbLakiLaki = new System.Windows.Forms.RadioButton();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbNegaraAsal = new System.Windows.Forms.TextBox();
            this.tbNomorTelepon = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbKodeTamu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btTambah = new System.Windows.Forms.Button();
            this.btPerbarui = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCari = new System.Windows.Forms.ComboBox();
            this.btCari = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.btBatal = new System.Windows.Forms.Button();
            this.btKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTamu
            // 
            this.dgvTamu.AllowUserToAddRows = false;
            this.dgvTamu.AllowUserToDeleteRows = false;
            this.dgvTamu.AllowUserToResizeColumns = false;
            this.dgvTamu.AllowUserToResizeRows = false;
            this.dgvTamu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTamu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamu.Location = new System.Drawing.Point(21, 59);
            this.dgvTamu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvTamu.Name = "dgvTamu";
            this.dgvTamu.ReadOnly = true;
            this.dgvTamu.RowHeadersVisible = false;
            this.dgvTamu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTamu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamu.Size = new System.Drawing.Size(1222, 400);
            this.dgvTamu.TabIndex = 20;
            this.dgvTamu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTamu_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label1.Location = new System.Drawing.Point(16, 474);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Tamu :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbNama.Location = new System.Drawing.Point(197, 513);
            this.tbNama.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(301, 29);
            this.tbNama.TabIndex = 2;
            this.tbNama.Leave += new System.EventHandler(this.tbNama_Leave);
            // 
            // rbLakiLaki
            // 
            this.rbLakiLaki.AutoSize = true;
            this.rbLakiLaki.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.rbLakiLaki.Location = new System.Drawing.Point(198, 554);
            this.rbLakiLaki.Name = "rbLakiLaki";
            this.rbLakiLaki.Size = new System.Drawing.Size(91, 31);
            this.rbLakiLaki.TabIndex = 3;
            this.rbLakiLaki.TabStop = true;
            this.rbLakiLaki.Text = "Laki-laki";
            this.rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CustomFormat = "d MMMM yyyy";
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(197, 595);
            this.dtpTanggalLahir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(301, 29);
            this.dtpTanggalLahir.TabIndex = 5;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbAlamat.Location = new System.Drawing.Point(708, 472);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(370, 29);
            this.tbAlamat.TabIndex = 7;
            // 
            // tbNegaraAsal
            // 
            this.tbNegaraAsal.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbNegaraAsal.Location = new System.Drawing.Point(197, 636);
            this.tbNegaraAsal.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbNegaraAsal.Name = "tbNegaraAsal";
            this.tbNegaraAsal.Size = new System.Drawing.Size(301, 29);
            this.tbNegaraAsal.TabIndex = 6;
            // 
            // tbNomorTelepon
            // 
            this.tbNomorTelepon.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbNomorTelepon.Location = new System.Drawing.Point(708, 513);
            this.tbNomorTelepon.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbNomorTelepon.Name = "tbNomorTelepon";
            this.tbNomorTelepon.Size = new System.Drawing.Size(370, 29);
            this.tbNomorTelepon.TabIndex = 8;
            this.tbNomorTelepon.TextChanged += new System.EventHandler(this.tbNomorTelepon_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbEmail.Location = new System.Drawing.Point(708, 554);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(370, 29);
            this.tbEmail.TabIndex = 9;
            // 
            // lbKodeTamu
            // 
            this.lbKodeTamu.AutoSize = true;
            this.lbKodeTamu.Location = new System.Drawing.Point(153, 494);
            this.lbKodeTamu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKodeTamu.Name = "lbKodeTamu";
            this.lbKodeTamu.Size = new System.Drawing.Size(10, 13);
            this.lbKodeTamu.TabIndex = 9;
            this.lbKodeTamu.Text = "-";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label2.Location = new System.Drawing.Point(16, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label3.Location = new System.Drawing.Point(16, 556);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jenis Kelamin :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.rbPerempuan.Location = new System.Drawing.Point(295, 554);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(119, 31);
            this.rbPerempuan.TabIndex = 4;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label4.Location = new System.Drawing.Point(16, 597);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tanggal Lahir :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label5.Location = new System.Drawing.Point(527, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alamat :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label6.Location = new System.Drawing.Point(16, 638);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Negara Asal :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label7.Location = new System.Drawing.Point(527, 515);
            this.label7.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nomor Telepon :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label8.Location = new System.Drawing.Point(527, 556);
            this.label8.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btTambah
            // 
            this.btTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTambah.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btTambah.ForeColor = System.Drawing.Color.White;
            this.btTambah.Location = new System.Drawing.Point(1126, 470);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(118, 33);
            this.btTambah.TabIndex = 11;
            this.btTambah.Text = "TAMBAH";
            this.btTambah.UseVisualStyleBackColor = false;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // btPerbarui
            // 
            this.btPerbarui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btPerbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerbarui.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btPerbarui.ForeColor = System.Drawing.Color.White;
            this.btPerbarui.Location = new System.Drawing.Point(1126, 511);
            this.btPerbarui.Name = "btPerbarui";
            this.btPerbarui.Size = new System.Drawing.Size(118, 33);
            this.btPerbarui.TabIndex = 12;
            this.btPerbarui.Text = "UBAH";
            this.btPerbarui.UseVisualStyleBackColor = false;
            this.btPerbarui.Click += new System.EventHandler(this.btPerbarui_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pencarian Nama Tamu :";
            // 
            // cbCari
            // 
            this.cbCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCari.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCari.FormattingEnabled = true;
            this.cbCari.Location = new System.Drawing.Point(223, 14);
            this.cbCari.Name = "cbCari";
            this.cbCari.Size = new System.Drawing.Size(369, 31);
            this.cbCari.TabIndex = 0;
            this.cbCari.SelectedIndexChanged += new System.EventHandler(this.cbCari_SelectedIndexChanged);
            // 
            // btCari
            // 
            this.btCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCari.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btCari.ForeColor = System.Drawing.Color.White;
            this.btCari.Location = new System.Drawing.Point(601, 13);
            this.btCari.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(118, 33);
            this.btCari.TabIndex = 1;
            this.btCari.Text = "CARI";
            this.btCari.UseVisualStyleBackColor = false;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label10.Location = new System.Drawing.Point(527, 597);
            this.label10.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "Status :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.cbStatus.Location = new System.Drawing.Point(708, 596);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(68, 31);
            this.cbStatus.TabIndex = 10;
            this.cbStatus.Text = "Aktif";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // btBatal
            // 
            this.btBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBatal.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btBatal.ForeColor = System.Drawing.Color.White;
            this.btBatal.Location = new System.Drawing.Point(728, 13);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(118, 33);
            this.btBatal.TabIndex = 24;
            this.btBatal.Text = "BERSIHKAN";
            this.btBatal.UseVisualStyleBackColor = false;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKembali.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btKembali.ForeColor = System.Drawing.Color.White;
            this.btKembali.Location = new System.Drawing.Point(1126, 13);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(118, 33);
            this.btKembali.TabIndex = 25;
            this.btKembali.Text = "KEMBALI";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // FormPencatatanDataTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btCari);
            this.Controls.Add(this.cbCari);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btPerbarui);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKodeTamu);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNomorTelepon);
            this.Controls.Add(this.tbNegaraAsal);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.rbLakiLaki);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTamu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormPencatatanDataTamu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pencatatan Data Tamu";
            this.Load += new System.EventHandler(this.FormPencatatanDataTamu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTamu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.RadioButton rbLakiLaki;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbNegaraAsal;
        private System.Windows.Forms.TextBox tbNomorTelepon;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbKodeTamu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Button btPerbarui;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCari;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Button btKembali;
    }
}