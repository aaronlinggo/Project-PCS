﻿
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
            this.dgvTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamu.Location = new System.Drawing.Point(13, 64);
            this.dgvTamu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvTamu.Name = "dgvTamu";
            this.dgvTamu.ReadOnly = true;
            this.dgvTamu.RowHeadersVisible = false;
            this.dgvTamu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTamu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamu.Size = new System.Drawing.Size(1238, 431);
            this.dgvTamu.TabIndex = 20;
            this.dgvTamu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTamu_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 501);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Tamu :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(153, 530);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(370, 26);
            this.tbNama.TabIndex = 2;
            this.tbNama.Leave += new System.EventHandler(this.tbNama_Leave);
            // 
            // rbLakiLaki
            // 
            this.rbLakiLaki.AutoSize = true;
            this.rbLakiLaki.Location = new System.Drawing.Point(212, 563);
            this.rbLakiLaki.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rbLakiLaki.Name = "rbLakiLaki";
            this.rbLakiLaki.Size = new System.Drawing.Size(83, 27);
            this.rbLakiLaki.TabIndex = 3;
            this.rbLakiLaki.TabStop = true;
            this.rbLakiLaki.Text = "Laki-laki";
            this.rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CustomFormat = "d MMMM yyyy";
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(153, 602);
            this.dtpTanggalLahir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(192, 26);
            this.dtpTanggalLahir.TabIndex = 5;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(688, 526);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(370, 26);
            this.tbAlamat.TabIndex = 7;
            // 
            // tbNegaraAsal
            // 
            this.tbNegaraAsal.Location = new System.Drawing.Point(153, 640);
            this.tbNegaraAsal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbNegaraAsal.Name = "tbNegaraAsal";
            this.tbNegaraAsal.Size = new System.Drawing.Size(370, 26);
            this.tbNegaraAsal.TabIndex = 6;
            // 
            // tbNomorTelepon
            // 
            this.tbNomorTelepon.Location = new System.Drawing.Point(688, 564);
            this.tbNomorTelepon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbNomorTelepon.Name = "tbNomorTelepon";
            this.tbNomorTelepon.Size = new System.Drawing.Size(370, 26);
            this.tbNomorTelepon.TabIndex = 8;
            this.tbNomorTelepon.TextChanged += new System.EventHandler(this.tbNomorTelepon_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(688, 602);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(370, 26);
            this.tbEmail.TabIndex = 9;
            // 
            // lbKodeTamu
            // 
            this.lbKodeTamu.AutoSize = true;
            this.lbKodeTamu.Location = new System.Drawing.Point(153, 501);
            this.lbKodeTamu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKodeTamu.Name = "lbKodeTamu";
            this.lbKodeTamu.Size = new System.Drawing.Size(15, 23);
            this.lbKodeTamu.TabIndex = 9;
            this.lbKodeTamu.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 533);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 565);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jenis Kelamin :";
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(358, 563);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(101, 27);
            this.rbPerempuan.TabIndex = 4;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 606);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tanggal Lahir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 529);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alamat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 643);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Negara Asal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 567);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nomor Telepon :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 605);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email :";
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(1102, 530);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(117, 67);
            this.btTambah.TabIndex = 11;
            this.btTambah.Text = "TAMBAH";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // btPerbarui
            // 
            this.btPerbarui.Location = new System.Drawing.Point(1102, 603);
            this.btPerbarui.Name = "btPerbarui";
            this.btPerbarui.Size = new System.Drawing.Size(117, 67);
            this.btPerbarui.TabIndex = 12;
            this.btPerbarui.Text = "PERBARUI";
            this.btPerbarui.UseVisualStyleBackColor = true;
            this.btPerbarui.Click += new System.EventHandler(this.btPerbarui_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pencarian Nama Tamu :";
            // 
            // cbCari
            // 
            this.cbCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCari.FormattingEnabled = true;
            this.cbCari.Location = new System.Drawing.Point(183, 19);
            this.cbCari.Name = "cbCari";
            this.cbCari.Size = new System.Drawing.Size(369, 31);
            this.cbCari.TabIndex = 0;
            this.cbCari.SelectedIndexChanged += new System.EventHandler(this.cbCari_SelectedIndexChanged);
            // 
            // btCari
            // 
            this.btCari.Location = new System.Drawing.Point(558, 12);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(150, 43);
            this.btCari.TabIndex = 1;
            this.btCari.Text = "CARI";
            this.btCari.UseVisualStyleBackColor = true;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 638);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Status :";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(688, 637);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(61, 27);
            this.cbStatus.TabIndex = 10;
            this.cbStatus.Text = "Aktif";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(946, 12);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(150, 43);
            this.btBatal.TabIndex = 24;
            this.btBatal.Text = "BERSIHKAN";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(1102, 12);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(150, 43);
            this.btKembali.TabIndex = 25;
            this.btKembali.Text = "KEMBALI";
            this.btKembali.UseVisualStyleBackColor = true;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // FormPencatatanDataTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
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
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormPencatatanDataTamu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pencatatan Data Tamu";
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