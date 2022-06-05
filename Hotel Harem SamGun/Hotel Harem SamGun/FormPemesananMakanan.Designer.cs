
namespace Hotel_Harem_SamGun
{
    partial class FormPemesananMakanan
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbPembelian = new System.Windows.Forms.TextBox();
            this.btnMines = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTamu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "PEMESANAN MAKANAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Daftar Menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 514);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label4.Location = new System.Drawing.Point(614, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nama Makanan :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label5.Location = new System.Drawing.Point(614, 507);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Harga ;";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label6.Location = new System.Drawing.Point(614, 548);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stok :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbNama.Location = new System.Drawing.Point(785, 464);
            this.tbNama.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(299, 29);
            this.tbNama.TabIndex = 13;
            // 
            // tbHarga
            // 
            this.tbHarga.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbHarga.Location = new System.Drawing.Point(785, 505);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(299, 29);
            this.tbHarga.TabIndex = 14;
            // 
            // tbStok
            // 
            this.tbStok.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbStok.Location = new System.Drawing.Point(785, 546);
            this.tbStok.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbStok.Name = "tbStok";
            this.tbStok.ReadOnly = true;
            this.tbStok.Size = new System.Drawing.Size(299, 29);
            this.tbStok.TabIndex = 15;
            // 
            // tbPembelian
            // 
            this.tbPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPembelian.Location = new System.Drawing.Point(826, 628);
            this.tbPembelian.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbPembelian.Multiline = true;
            this.tbPembelian.Name = "tbPembelian";
            this.tbPembelian.ReadOnly = true;
            this.tbPembelian.Size = new System.Drawing.Size(46, 31);
            this.tbPembelian.TabIndex = 17;
            this.tbPembelian.Text = "0";
            this.tbPembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPembelian.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            // 
            // btnMines
            // 
            this.btnMines.Enabled = false;
            this.btnMines.Font = new System.Drawing.Font("Gill Sans MT", 16F);
            this.btnMines.Location = new System.Drawing.Point(784, 627);
            this.btnMines.Name = "btnMines";
            this.btnMines.Size = new System.Drawing.Size(33, 33);
            this.btnMines.TabIndex = 18;
            this.btnMines.Text = "-";
            this.btnMines.UseVisualStyleBackColor = true;
            this.btnMines.Click += new System.EventHandler(this.btnMines_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTambah.Enabled = false;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(967, 627);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(118, 33);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersihkan.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnBersihkan.ForeColor = System.Drawing.Color.White;
            this.btnBersihkan.Location = new System.Drawing.Point(501, 59);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(118, 33);
            this.btnBersihkan.TabIndex = 21;
            this.btnBersihkan.Text = "BERSIHKAN";
            this.btnBersihkan.UseVisualStyleBackColor = false;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPesan.Enabled = false;
            this.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesan.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnPesan.ForeColor = System.Drawing.Color.White;
            this.btnPesan.Location = new System.Drawing.Point(1126, 503);
            this.btnPesan.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(118, 33);
            this.btnPesan.TabIndex = 22;
            this.btnPesan.Text = "PESAN";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(612, 145);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(631, 306);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(606, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "Isi Keranjang";
            // 
            // btnPlus
            // 
            this.btnPlus.Enabled = false;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(881, 627);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 25;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1126, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 33);
            this.button6.TabIndex = 26;
            this.button6.Text = "KEMBALI";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(1126, 462);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(118, 33);
            this.btnHapus.TabIndex = 29;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label9.Location = new System.Drawing.Point(880, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 27);
            this.label9.TabIndex = 30;
            this.label9.Text = "Subtotal : Rp. ";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbSubtotal.Location = new System.Drawing.Point(1014, 105);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(229, 29);
            this.tbSubtotal.TabIndex = 31;
            this.tbSubtotal.Text = "0";
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbKeterangan.Location = new System.Drawing.Point(785, 587);
            this.tbKeterangan.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.ReadOnly = true;
            this.tbKeterangan.Size = new System.Drawing.Size(299, 29);
            this.tbKeterangan.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label3.Location = new System.Drawing.Point(614, 589);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Keterangan :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTamu
            // 
            this.cbTamu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTamu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTamu.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.cbTamu.FormattingEnabled = true;
            this.cbTamu.Location = new System.Drawing.Point(773, 14);
            this.cbTamu.Name = "cbTamu";
            this.cbTamu.Size = new System.Drawing.Size(268, 31);
            this.cbTamu.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label10.Location = new System.Drawing.Point(693, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 27);
            this.label10.TabIndex = 35;
            this.label10.Text = "Tamu :";
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.tbCari.Location = new System.Drawing.Point(97, 61);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(268, 29);
            this.tbCari.TabIndex = 36;
            this.tbCari.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(374, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 38;
            this.button1.Text = "CARI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label13.Location = new System.Drawing.Point(15, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 27);
            this.label13.TabIndex = 39;
            this.label13.Text = "Nama :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.label11.Location = new System.Drawing.Point(614, 630);
            this.label11.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 26);
            this.label11.TabIndex = 40;
            this.label11.Text = "Jumlah Beli :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormPemesananMakanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbTamu);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnMines);
            this.Controls.Add(this.tbPembelian);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormPemesananMakanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pemesanan Makanan";
            this.Load += new System.EventHandler(this.FormPemesananMakanan_Load);
            this.Shown += new System.EventHandler(this.FormPemesananMakanan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbPembelian;
        private System.Windows.Forms.Button btnMines;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTamu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}