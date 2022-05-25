
namespace Hotel_Harem_SamGun
{
    partial class FormPenambahanFasilitasKamar
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
            this.dgvFasilitas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numJumlah = new System.Windows.Forms.NumericUpDown();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKodeReservasi = new System.Windows.Forms.Label();
            this.lblNamaTamu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNoKamar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFasilitas
            // 
            this.dgvFasilitas.AllowUserToAddRows = false;
            this.dgvFasilitas.AllowUserToDeleteRows = false;
            this.dgvFasilitas.AllowUserToResizeColumns = false;
            this.dgvFasilitas.AllowUserToResizeRows = false;
            this.dgvFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFasilitas.Location = new System.Drawing.Point(41, 138);
            this.dgvFasilitas.Name = "dgvFasilitas";
            this.dgvFasilitas.ReadOnly = true;
            this.dgvFasilitas.RowHeadersVisible = false;
            this.dgvFasilitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFasilitas.Size = new System.Drawing.Size(1203, 237);
            this.dgvFasilitas.TabIndex = 11;
            this.dgvFasilitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFasilitas_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "DATA PENAMBAHAN FASILITAS";
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.AllowUserToAddRows = false;
            this.dgvKeranjang.AllowUserToDeleteRows = false;
            this.dgvKeranjang.AllowUserToResizeColumns = false;
            this.dgvKeranjang.AllowUserToResizeRows = false;
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvKeranjang.Location = new System.Drawing.Point(41, 435);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.ReadOnly = true;
            this.dgvKeranjang.RowHeadersVisible = false;
            this.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeranjang.Size = new System.Drawing.Size(507, 214);
            this.dgvKeranjang.TabIndex = 13;
            this.dgvKeranjang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeranjang_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nama";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Harga";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 61;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Jumlah";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 65;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Subtotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(39, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "KERANJANG PESANAN";
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKembali.Location = new System.Drawing.Point(1149, 29);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(79, 36);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.Location = new System.Drawing.Point(994, 588);
            this.btnPesan.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(250, 41);
            this.btnPesan.TabIndex = 39;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(994, 476);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(250, 41);
            this.btnHapus.TabIndex = 38;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(994, 426);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(250, 41);
            this.btnTambah.TabIndex = 37;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.Location = new System.Drawing.Point(725, 538);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(247, 26);
            this.tbHarga.TabIndex = 32;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(725, 487);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(248, 26);
            this.tbNama.TabIndex = 31;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(725, 435);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(247, 26);
            this.tbID.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(572, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Jumlah";
            // 
            // numJumlah
            // 
            this.numJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numJumlah.Location = new System.Drawing.Point(725, 585);
            this.numJumlah.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(247, 26);
            this.numJumlah.TabIndex = 41;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBersihkan.Location = new System.Drawing.Point(994, 530);
            this.btnBersihkan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(250, 41);
            this.btnBersihkan.TabIndex = 42;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(40, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Kode Reservasi :";
            // 
            // lblKodeReservasi
            // 
            this.lblKodeReservasi.AutoSize = true;
            this.lblKodeReservasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKodeReservasi.Location = new System.Drawing.Point(210, 29);
            this.lblKodeReservasi.Name = "lblKodeReservasi";
            this.lblKodeReservasi.Size = new System.Drawing.Size(60, 24);
            this.lblKodeReservasi.TabIndex = 44;
            this.lblKodeReservasi.Text = "label8";
            // 
            // lblNamaTamu
            // 
            this.lblNamaTamu.AutoSize = true;
            this.lblNamaTamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNamaTamu.Location = new System.Drawing.Point(210, 63);
            this.lblNamaTamu.Name = "lblNamaTamu";
            this.lblNamaTamu.Size = new System.Drawing.Size(60, 24);
            this.lblNamaTamu.TabIndex = 46;
            this.lblNamaTamu.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(40, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Nama Tamu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(541, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Nomor Kamar :";
            // 
            // lblNoKamar
            // 
            this.lblNoKamar.AutoSize = true;
            this.lblNoKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNoKamar.Location = new System.Drawing.Point(704, 29);
            this.lblNoKamar.Name = "lblNoKamar";
            this.lblNoKamar.Size = new System.Drawing.Size(60, 24);
            this.lblNoKamar.TabIndex = 48;
            this.lblNoKamar.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(323, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 49;
            this.label10.Text = "TOTAL";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotal.Location = new System.Drawing.Point(488, 394);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(247, 26);
            this.tbSubtotal.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(432, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "Rp. ";
            // 
            // FormPenambahanFasilitasKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNoKamar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNamaTamu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblKodeReservasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.numJumlah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFasilitas);
            this.Controls.Add(this.label3);
            this.Name = "FormPenambahanFasilitasKamar";
            this.Text = "Penambahan Fasilitas Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFasilitas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numJumlah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKodeReservasi;
        private System.Windows.Forms.Label lblNamaTamu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNoKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label11;
    }
}