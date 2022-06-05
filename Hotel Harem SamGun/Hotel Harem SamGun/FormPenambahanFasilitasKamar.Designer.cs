
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
            this.lblNoKamar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnBersihkan2 = new System.Windows.Forms.Button();
            this.dgvFasilitas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKodeReservasi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNamaTamu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATA PENAMBAHAN FASILITAS";
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.AllowUserToAddRows = false;
            this.dgvKeranjang.AllowUserToDeleteRows = false;
            this.dgvKeranjang.AllowUserToResizeColumns = false;
            this.dgvKeranjang.AllowUserToResizeRows = false;
            this.dgvKeranjang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvKeranjang.Location = new System.Drawing.Point(21, 445);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.ReadOnly = true;
            this.dgvKeranjang.RowHeadersVisible = false;
            this.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeranjang.Size = new System.Drawing.Size(660, 214);
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
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "KERANJANG PESANAN";
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(1126, 13);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(118, 33);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesan.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnPesan.ForeColor = System.Drawing.Color.White;
            this.btnPesan.Location = new System.Drawing.Point(1126, 523);
            this.btnPesan.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(118, 33);
            this.btnPesan.TabIndex = 39;
            this.btnPesan.Text = "PESAN";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(1126, 441);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(118, 33);
            this.btnHapus.TabIndex = 38;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(965, 606);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(118, 33);
            this.btnTambah.TabIndex = 37;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbHarga.Location = new System.Drawing.Point(835, 525);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(247, 29);
            this.tbHarga.TabIndex = 32;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbNama.Location = new System.Drawing.Point(835, 484);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(248, 29);
            this.tbNama.TabIndex = 31;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbID.Location = new System.Drawing.Point(835, 443);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(247, 29);
            this.tbID.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label5.Location = new System.Drawing.Point(696, 527);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Harga :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label1.Location = new System.Drawing.Point(696, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nama :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label2.Location = new System.Drawing.Point(696, 445);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label6.Location = new System.Drawing.Point(696, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Jumlah :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numJumlah
            // 
            this.numJumlah.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.numJumlah.Location = new System.Drawing.Point(835, 566);
            this.numJumlah.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(247, 29);
            this.numJumlah.TabIndex = 41;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersihkan.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnBersihkan.ForeColor = System.Drawing.Color.White;
            this.btnBersihkan.Location = new System.Drawing.Point(1126, 482);
            this.btnBersihkan.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(118, 33);
            this.btnBersihkan.TabIndex = 42;
            this.btnBersihkan.Text = "BERSIHKAN";
            this.btnBersihkan.UseVisualStyleBackColor = false;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // lblNoKamar
            // 
            this.lblNoKamar.AutoSize = true;
            this.lblNoKamar.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.lblNoKamar.Location = new System.Drawing.Point(504, 66);
            this.lblNoKamar.Name = "lblNoKamar";
            this.lblNoKamar.Size = new System.Drawing.Size(52, 27);
            this.lblNoKamar.TabIndex = 48;
            this.lblNoKamar.Text = "1305";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label10.Location = new System.Drawing.Point(342, 401);
            this.label10.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 27);
            this.label10.TabIndex = 49;
            this.label10.Text = "Total : Rp. ";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbSubtotal.Location = new System.Drawing.Point(452, 399);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(229, 29);
            this.tbSubtotal.TabIndex = 50;
            this.tbSubtotal.Text = "0";
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbCari.Location = new System.Drawing.Point(673, 15);
            this.tbCari.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(196, 29);
            this.tbCari.TabIndex = 53;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(878, 13);
            this.btnCari.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(118, 33);
            this.btnCari.TabIndex = 54;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnBersihkan2
            // 
            this.btnBersihkan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBersihkan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersihkan2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBersihkan2.ForeColor = System.Drawing.Color.White;
            this.btnBersihkan2.Location = new System.Drawing.Point(1002, 13);
            this.btnBersihkan2.Name = "btnBersihkan2";
            this.btnBersihkan2.Size = new System.Drawing.Size(118, 33);
            this.btnBersihkan2.TabIndex = 55;
            this.btnBersihkan2.Text = "BERSIHKAN";
            this.btnBersihkan2.UseVisualStyleBackColor = false;
            this.btnBersihkan2.Click += new System.EventHandler(this.btnBersihkan2_Click);
            // 
            // dgvFasilitas
            // 
            this.dgvFasilitas.AllowUserToAddRows = false;
            this.dgvFasilitas.AllowUserToDeleteRows = false;
            this.dgvFasilitas.AllowUserToResizeColumns = false;
            this.dgvFasilitas.AllowUserToResizeRows = false;
            this.dgvFasilitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFasilitas.Location = new System.Drawing.Point(21, 105);
            this.dgvFasilitas.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.dgvFasilitas.Name = "dgvFasilitas";
            this.dgvFasilitas.ReadOnly = true;
            this.dgvFasilitas.RowHeadersVisible = false;
            this.dgvFasilitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFasilitas.Size = new System.Drawing.Size(1222, 270);
            this.dgvFasilitas.TabIndex = 11;
            this.dgvFasilitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFasilitas_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label7.Location = new System.Drawing.Point(15, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "Kode Reservasi :";
            // 
            // lblKodeReservasi
            // 
            this.lblKodeReservasi.AutoSize = true;
            this.lblKodeReservasi.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.lblKodeReservasi.Location = new System.Drawing.Point(159, 66);
            this.lblKodeReservasi.Name = "lblKodeReservasi";
            this.lblKodeReservasi.Size = new System.Drawing.Size(170, 27);
            this.lblKodeReservasi.TabIndex = 44;
            this.lblKodeReservasi.Text = "RSV030622KM1111\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label9.Location = new System.Drawing.Point(599, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 27);
            this.label9.TabIndex = 45;
            this.label9.Text = "Nama Tamu :";
            // 
            // lblNamaTamu
            // 
            this.lblNamaTamu.AutoSize = true;
            this.lblNamaTamu.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.lblNamaTamu.Location = new System.Drawing.Point(721, 66);
            this.lblNamaTamu.Name = "lblNamaTamu";
            this.lblNamaTamu.Size = new System.Drawing.Size(124, 27);
            this.lblNamaTamu.TabIndex = 46;
            this.lblNamaTamu.Text = "Kim Min-jeong";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label8.Location = new System.Drawing.Point(363, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 27);
            this.label8.TabIndex = 47;
            this.label8.Text = "Nomor Kamar :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label12.Location = new System.Drawing.Point(604, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 27);
            this.label12.TabIndex = 52;
            this.label12.Text = "Cari :";
            // 
            // FormPenambahanFasilitasKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBersihkan2);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.label12);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPenambahanFasilitasKamar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penambahan Fasilitas Kamar";
            this.Load += new System.EventHandler(this.FormPenambahanFasilitasKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblNoKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnBersihkan2;
        private System.Windows.Forms.DataGridView dgvFasilitas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKodeReservasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNamaTamu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
    }
}